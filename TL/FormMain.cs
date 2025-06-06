using System.Collections.Generic;
using MyDictionary;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Tulmachennya;
using TL;

namespace MyDictionary
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void RefreshWordList()
        {
            listBoxAllWords.Items.Clear();
            listBoxAllWords.Items.AddRange(DictionaryManager.Words.Select(w => w.Word).ToArray());
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchWord = textBoxSearch.Text.Trim();

            var entry = DictionaryManager.Words.FirstOrDefault(w => w.Word.Equals(searchWord, StringComparison.OrdinalIgnoreCase));

            if (entry != null)
            {
                labelResult.Text = $"Значення: {entry.Meaning}";
                var related = DictionaryManager.Words
                    .Where(w => w.Tag == entry.Tag && !w.Word.Equals(entry.Word, StringComparison.OrdinalIgnoreCase))
                    .Select(w => w.Word)
                    .ToList();

                listBoxSuggestions.Items.Clear();
                listBoxSuggestions.Items.AddRange(related.ToArray());
            }
            else
            {
                labelResult.Text = "Слово не знайдено.";
                listBoxSuggestions.Items.Clear();
            }
        }

        private void buttonOpenAddForm_Click(object sender, EventArgs e)
        {
            FormAdd addForm = new FormAdd();
            addForm.ShowDialog();
        }

        private void buttonGoogleSearch_Click(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text.Trim();
            if (!string.IsNullOrEmpty(query))
            {
                string url = "https://www.google.com/search?q=" + Uri.EscapeDataString(query);
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DictionaryManager.Words = DictionaryStorage.Load();
            RefreshWordList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxAllWords.SelectedItem == null)
            {
                MessageBox.Show("Виберіть слово для видалення.");
                return;
            }

            string selectedWord = listBoxAllWords.SelectedItem.ToString();
            var entry = DictionaryManager.Words.FirstOrDefault(w => w.Word == selectedWord);

            if (entry != null)
            {
                var result = MessageBox.Show($"Ви дійсно хочете видалити слово \"{entry.Word}\"?", "Підтвердження", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DictionaryManager.Words.Remove(entry);
                    DictionaryStorage.Save(DictionaryManager.Words);
                    RefreshWordList();
                    labelResult.Text = "";
                    listBoxSuggestions.Items.Clear();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxAllWords.SelectedItem == null)
            {
                MessageBox.Show("Виберіть слово для редагування.");
                return;
            }

            string selectedWord = listBoxAllWords.SelectedItem.ToString();
            var entry = DictionaryManager.Words.FirstOrDefault(w => w.Word == selectedWord);

            if (entry != null)
            {
                FormEdit editForm = new FormEdit(entry);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    DictionaryStorage.Save(DictionaryManager.Words);
                    RefreshWordList();
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonSearchByTag_Click(object sender, EventArgs e)
        {
            FormSearchByTag tagForm = new FormSearchByTag();
            tagForm.ShowDialog();
        }

        private void buttonExportTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt";
            saveDialog.Title = "Зберегти список слів у TXT";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    foreach (var word in DictionaryManager.Words)
                    {
                        writer.WriteLine($"{word.Word} - {word.Meaning} - {word.Tag}");
                    }
                }

                MessageBox.Show("Список слів збережено у текстовий файл.");
            }
        }

        private void buttonImportTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text Files (*.txt)|*.txt";
            openDialog.Title = "Завантажити список слів з TXT";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadAllLines(openDialog.FileName);
                var imported = new List<DictionaryEntry>();

                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { " - " }, StringSplitOptions.None);
                    if (parts.Length == 3)
                    {
                        imported.Add(new DictionaryEntry
                        {
                            Word = parts[0].Trim(),
                            Meaning = parts[1].Trim(),
                            Tag = parts[2].Trim()
                        });
                    }
                }

                if (imported.Count > 0)
                {
                    DictionaryManager.Words = imported;
                    DictionaryStorage.Save(imported);
                    RefreshWordList();
                    MessageBox.Show("Список слів завантажено з файлу.");
                }
                else
                {
                    MessageBox.Show("Формат файлу некоректний або порожній.");
                }
            }
        }
    }
}

