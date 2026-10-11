using Microsoft.Win32;

namespace Utils
{
    public class Reg
    {
        private const string REG_PATH = @"Software\Drovosekov.Net\MUSEUM CATALOG";

        public static object GetRegValue(string regPath, string regParam)
        {
            RegistryKey wKey = null;
            try
            {
                wKey = Registry.CurrentUser.OpenSubKey(regPath);
                return wKey.GetValue(regParam);
            }
            catch// (Exception ex)
            {
                //logger.Error($"GetRegValue: {regPath} '{regParam}': {ex.Message}");
                return null;
            }
            finally
            {
                wKey?.Close();
            }
        }

        public static void SetRegValueSettings(string regParam, object regValue)
        {
            RegistryKey wKey = null;
            try
            {
                wKey = Registry.CurrentUser.CreateSubKey(REG_PATH);
                wKey.SetValue(regParam, regValue);
            }
            catch// (Exception ex)
            {
                //logger.Error($"SetRegValue: {regParam} '{regValue}': {ex.Message}");
            }
            finally
            {
                wKey?.Close();
            }
        }

        public static string GetRegValueString(string name) => GetRegValueSettings(name).ToString();
        public static int GetRegValueInt(string name) => int.Parse(GetRegValueString(name));

        public static string RegTempValue => GetRegValue("Environment", "TEMP") as string;

        public static object GetRegValueSettings(string regParam) => GetRegValue(REG_PATH, regParam);

    }
}
