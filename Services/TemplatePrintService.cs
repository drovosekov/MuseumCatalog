using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using MuseumCatalog.Models;

namespace MuseumCatalog.Services
{
    public static class TemplatePrintService
    {
        public static string GenerateDocument(Exhibit exhibit, string museumName, string templatePath, string outputDir)
        {
            string fileName = "Карточка_" + exhibit.Cipher + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".docx";
            fileName = string.Join("_", fileName.Split(Path.GetInvalidFileNameChars()));
            string outputPath = Path.Combine(outputDir, fileName);
            PrintExhibit(exhibit, museumName, templatePath, outputPath);
            return outputPath;
        }

        public static void PrintExhibit(Exhibit exhibit, string museumName, string templatePath, string outputPath)
        {
            File.Copy(templatePath, outputPath, true);

            using WordprocessingDocument doc = WordprocessingDocument.Open(outputPath, true);
            ReplaceInDocument(doc, exhibit, museumName);
            doc.Save();
        }

        public static string PrintMultipleExhibits(List<Exhibit> exhibits, string museumName, string templatePath, string outputDir)
        {
            string baseName = "Карточки_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            for (int i = 0; i < exhibits.Count; i++)
            {
                string suffix = exhibits.Count > 1 ? "_" + (i + 1) : "";
                string outputPath = Path.Combine(outputDir, baseName + suffix + ".docx");
                PrintExhibit(exhibits[i], museumName, templatePath, outputPath);
            }

            return Path.Combine(outputDir, baseName + ".docx");
        }

        private static void ReplaceInDocument(WordprocessingDocument doc, Exhibit exhibit, string museumName)
        {
            Dictionary<string, string> replacements = BuildReplacements(exhibit, museumName);

            Body body = doc.MainDocumentPart.Document.Body;
            foreach (Paragraph paragraph in body.Descendants<Paragraph>())
            {
                ReplaceInParagraph(paragraph, replacements);
            }

            foreach (HeaderPart headerPart in doc.MainDocumentPart.HeaderParts)
            {
                foreach (Paragraph paragraph in headerPart.RootElement.Descendants<Paragraph>())
                {
                    ReplaceInParagraph(paragraph, replacements);
                }
            }

            foreach (FooterPart footerPart in doc.MainDocumentPart.FooterParts)
            {
                foreach (Paragraph paragraph in footerPart.RootElement.Descendants<Paragraph>())
                {
                    ReplaceInParagraph(paragraph, replacements);
                }
            }
        }

        private static Dictionary<string, string> BuildReplacements(Exhibit exhibit, string museumName)
        {
            return new Dictionary<string, string>
            {
                ["{MUSEUM_TITLE}"] = museumName ?? "",
                ["{EXPONATE_NAME}"] = exhibit.ItemName ?? "",
                ["{SHIFR}"] = exhibit.Cipher ?? "",
                ["{KP_NUM}"] = exhibit.KPNumber ?? "",
                ["{DESCRIPTION}"] = exhibit.Description ?? "",
                ["{DATE_TIME}"] = exhibit.TimeStamp?.ToString("yyyy-MM-dd") ?? "",
                ["{SOURCE_FROM}"] = exhibit.Source ?? "",
                ["{AKT}"] = exhibit.ActNumber ?? "",
                ["{MATHERIAL}"] = exhibit.MaterialTechnique ?? "",
                ["{SIZE}"] = exhibit.Size ?? "",
                ["{SAVED_STATE}"] = exhibit.Condition ?? "",
                ["{SAVED_PLACE}"] = exhibit.StoragePlaceName ?? ""
            };
        }

        private static void ReplaceInParagraph(Paragraph paragraph, Dictionary<string, string> replacements)
        {
            List<Text> textElements = paragraph.Descendants<Text>().ToList();
            if (textElements.Count == 0) return;

            string fullText = string.Join("", textElements.Select(t => t.Text));

            string newText = fullText;
            foreach (var kv in replacements)
            {
                if (newText.Contains(kv.Key))
                {
                    newText = newText.Replace(kv.Key, kv.Value);
                }
            }

            newText = Regex.Replace(newText, @"\{[A-Z_]+\}", "");

            if (newText != fullText)
            {
                textElements[0].Text = newText;
                textElements[0].Space = SpaceProcessingModeValues.Preserve;
                for (int i = 1; i < textElements.Count; i++)
                {
                    textElements[i].Text = "";
                }
            }
        }
    }
}
