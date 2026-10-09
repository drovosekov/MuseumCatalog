using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MuseumCatalog.Data;
using MuseumCatalog.Models;

namespace MuseumCatalog.Views
{
    public partial class ExhibitEditorForm : Form
    {
        private readonly ExhibitRepository _repo;
        private readonly StoragePlaceRepository _placeRepo;
        private readonly Exhibit _exhibit;
        private readonly string _dbPath;
        private byte[] _photoData;
        private TextBox[] autoCompliteTextBoxes;

        public Exhibit ResultExhibit { get; private set; }

        public ExhibitEditorForm() { InitializeComponent(); }

        /// <summary>
        /// Редактирование существующей карточки или создание новой.
        /// </summary>
        public ExhibitEditorForm(string dbPath, Exhibit existing) : this()
        {
            _repo = new ExhibitRepository(dbPath);
            _placeRepo = new StoragePlaceRepository(dbPath);
            _exhibit = existing ?? new Exhibit();
            _dbPath = dbPath;

            LoadPlaces();

            if (existing is not null)
            {
                this.Text = "Редактирование карточки #" + existing.ID;
                PopulateFields(existing);
            }
            else
            {
                this.Text = "Новая карточка";
                DpTimeStamp.Value = DateTime.Now;
                DpTimeStamp.Checked = true;
            }

        }

        private void ExhibitEditorForm_Load(object sender, EventArgs e)
        {
            autoCompliteTextBoxes = new TextBox[] { TxtSource, TxtMaterialTechnique, TxtItemName, TxtCondition };
            initAutoCompliteTextBoxes();
        }

        private void initAutoCompliteTextBoxes()
        {
            try
            {
                foreach (var textBox in autoCompliteTextBoxes)
                {
                    // Включаем режим автозаполнения
                    textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                    var customSource = new AutoCompleteStringCollection();

                    // Загружаем сохраненную историю из БД по имени TextBox.Name
                    var history = AutoCompliteTextValues.GetHistory(_dbPath, textBox.Name);
                    customSource.AddRange(history.ToArray());

                    textBox.AutoCompleteCustomSource = customSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке истории: {ex.Message}", "initAutoCompliteTextBoxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Просмотр карточки в режиме только чтения (из журнала).
        /// </summary>
        public ExhibitEditorForm(string dbPath, Exhibit snapshot, bool readOnly) : this()
        {
            _repo = new ExhibitRepository(dbPath);
            _placeRepo = new StoragePlaceRepository(dbPath);
            _exhibit = snapshot ?? new Exhibit();

            LoadPlaces();

            if (readOnly)
            {
                this.Text = $"Просмотр карточки # {_exhibit.ID} (из журнала)";
                PopulateFields(_exhibit);
                SetReadOnly();
            }
        }

        private void PopulateFields(Exhibit ex)
        {
            TxtCipher.Text = ex.Cipher;
            TxtKPNumber.Text = ex.KPNumber;
            if (ex.TimeStamp.HasValue)
            {
                DpTimeStamp.Value = ex.TimeStamp.Value;
                DpTimeStamp.Checked = true;
            }
            else
            {
                DpTimeStamp.Checked = false;
            }
            TxtSource.Text = ex.Source;
            TxtActNumber.Text = ex.ActNumber;
            TxtMaterialTechnique.Text = ex.MaterialTechnique;
            TxtItemName.Text = ex.ItemName;
            TxtDescription.Text = ex.Description;
            TxtSize.Text = ex.Size;
            TxtCondition.Text = ex.Condition;
            if (ex.StoragePlaceID.HasValue)
            {
                CbStoragePlace.SelectedValue = ex.StoragePlaceID.Value;
            }
            else
            {
                CbStoragePlace.SelectedIndex = -1; // Сброс выбора, если места нет
            }
            _photoData = ex.Photo;
            ShowPhoto();
        }

        private void SetReadOnly()
        {
            TxtCipher.ReadOnly = true;
            TxtKPNumber.ReadOnly = true;
            DpTimeStamp.Enabled = false;
            TxtSource.ReadOnly = true;
            TxtActNumber.ReadOnly = true;
            TxtMaterialTechnique.ReadOnly = true;
            TxtItemName.ReadOnly = true;
            TxtDescription.ReadOnly = true;
            TxtSize.ReadOnly = true;
            TxtCondition.ReadOnly = true;
            CbStoragePlace.Enabled = false;
            BtnLoadPhoto.Visible = false;
            BtnClearPhoto.Visible = false;
            BtnSave.Visible = false;
            BtnCancel.Text = "Закрыть";
        }

        private void LoadPlaces()
        {
            List<StoragePlace> places = _placeRepo.GetAll();
            CbStoragePlace.DisplayMember = "PlaceName";
            CbStoragePlace.ValueMember = "ID";
            CbStoragePlace.DataSource = places;
        }

        private void BtnLoadPhoto_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Изображения (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            _photoData = File.ReadAllBytes(ofd.FileName);
            ShowPhoto();
        }

        private void BtnClearPhoto_Click(object sender, EventArgs e)
        {
            _photoData = null;
            PicPhoto.Image = null;
        }

        private void BtnViewPhoto_Click(object sender, EventArgs e)
        {
            if (_photoData == null || _photoData.Length == 0)
            {
                MessageBox.Show("Фото не прикреплено.", "Просмотр",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string title = "Фото: " + (TxtItemName.Text ?? "без названия");
            using PhotoViewerForm viewer = new(_photoData, title);
            viewer.ShowDialog();
        }

        private void PicPhoto_DoubleClick(object sender, EventArgs e)
        {
            BtnViewPhoto_Click(sender, e);
        }

        private void ShowPhoto()
        {
            if (_photoData == null || _photoData.Length == 0) return;
            try
            {
                using MemoryStream ms = new(_photoData);
                PicPhoto.Image = Image.FromStream(ms);
            }
            catch { }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _exhibit.Cipher = TxtCipher.Text;
            _exhibit.KPNumber = TxtKPNumber.Text;
            _exhibit.TimeStamp = DpTimeStamp.Checked ? DpTimeStamp.Value : null;
            _exhibit.Source = TxtSource.Text;
            _exhibit.ActNumber = TxtActNumber.Text;
            _exhibit.MaterialTechnique = TxtMaterialTechnique.Text;
            _exhibit.ItemName = TxtItemName.Text;
            _exhibit.Description = TxtDescription.Text;
            _exhibit.Size = TxtSize.Text;
            _exhibit.Condition = TxtCondition.Text;
            _exhibit.StoragePlaceID = CbStoragePlace.SelectedValue != null
                ? Convert.ToInt32(CbStoragePlace.SelectedValue)
                : null;
            _exhibit.Photo = _photoData;

            if (_exhibit.ID == 0)
            {
                _exhibit.ID = _repo.Insert(_exhibit);
            }
            else
            {
                _repo.Update(_exhibit);
            }
            SaveAutocomplite();

            ResultExhibit = _exhibit;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveAutocomplite()
        {

            try
            {
                foreach (var textBox in autoCompliteTextBoxes)
                {
                    string text = textBox.Text.Trim();

                    if (!string.IsNullOrEmpty(text))
                    {
                        // Если такого значения еще нет в локальных подсказках TextBox'а
                        if (!textBox.AutoCompleteCustomSource.Contains(text))
                        {
                            // Добавляем в выпадающий список на форме
                            textBox.AutoCompleteCustomSource.Add(text);

                            // Сохраняем в базу данных SQLite раздельно по имени поля
                            AutoCompliteTextValues.SaveValue(_dbPath, textBox.Name, text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "SaveAutocomplite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
