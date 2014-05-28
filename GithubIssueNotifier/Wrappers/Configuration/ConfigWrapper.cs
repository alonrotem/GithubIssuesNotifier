using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace GithubIssueNotifier.Wrappers.Configuration
{
    internal static class ConfigWrapper
    {
        public static void SetValues(string key, List<string> values)
        {
            ConfigWrapper.SetValue(key, String.Join(ConfigWrapper.Delimiter, values.ToArray()));
        }

        public static void SetValue(string key, string value)
        {
            if (ConfigWrapper.SettingsSection.Settings[key] == null)
            {
                ConfigWrapper.SettingsSection.Settings.Add(key, value);
            }
            else
                ConfigWrapper.SettingsSection.Settings[key].Value = value;

            ConfigWrapper.config.Save(ConfigurationSaveMode.Full);
        }

        public static string GetValue(string key)
        {
            return ConfigWrapper.GetValue(key, null);
        }

        public static string GetValue(string key, string valueToSetIfNotExisting)
        {
            var configElement = ConfigWrapper.SettingsSection.Settings[key];
            if (configElement != null)
                return configElement.Value;
            else
            {
                if (!string.IsNullOrWhiteSpace(valueToSetIfNotExisting))
                {
                    ConfigWrapper.SetValue(key, valueToSetIfNotExisting);
                    return valueToSetIfNotExisting;
                }
            }
            return null;
        }

        public static List<string> GetValues(string key)
        {
            string value = ConfigWrapper.GetValue(key);
            if (value != null)
            {
                return value.Split(new string[] { ConfigWrapper.Delimiter }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            else
                return new List<string>();
        }

        private static AppSettingsSection SettingsSection
        {
            get
            {
                if (ConfigWrapper.config == null)
                {
                    ConfigWrapper.config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                }
                return config.AppSettings;
            }
        }
        private static System.Configuration.Configuration config = null;
        private const string Delimiter = ";;;";
    }
}
