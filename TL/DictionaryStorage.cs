using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MyDictionary
{
    public static class DictionaryStorage
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dictionary.json");

        public static void Save(List<DictionaryEntry> entries)
        {
            var json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<DictionaryEntry> Load()
        {
            if (!File.Exists(filePath))
                return new List<DictionaryEntry>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<DictionaryEntry>>(json) ?? new List<DictionaryEntry>();
        }
    }
}
