using System;
using System.Configuration;

namespace ConfigManager
{
    public class AppSettingsProvider
    {
        private static string _JsonFilePath { get; set; }
        public static string JsonFilePath
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(_JsonFilePath)) _JsonFilePath = GetAppSetting("JsonFilePath");
                    return _JsonFilePath;
                }
                catch { return null; }
            }
        }
        private static int? _MinSkillLevel { get; set; }
        public static int MinSkillLevel
        {
            get
            {
                try
                {
                    if (!_MinSkillLevel.HasValue) _MinSkillLevel = Convert.ToInt32(GetAppSetting("MinSkillLevel"));
                    return _MinSkillLevel.Value;
                }
                catch { return 0; }
            }
        }

        private static string GetAppSetting(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch
            {
                return null;
            }
        }
    }
}
