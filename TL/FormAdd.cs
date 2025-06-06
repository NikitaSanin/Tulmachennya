using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MyDictionary;

namespace MyDictionary
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var word = textBoxWord.Text.Trim();
            var meaning = textBoxMeaning.Text.Trim();
            var tag = textBoxTag.Text.Trim();

            if (!string.IsNullOrWhiteSpace(word) && !string.IsNullOrWhiteSpace(meaning))
            {
                DictionaryManager.Words.Add(new DictionaryEntry
                {
                    Word = word,
                    Meaning = meaning,
                    Tag = tag
                });
                DictionaryStorage.Save(DictionaryManager.Words);

                MessageBox.Show("Слово додано!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть слово та значення.");
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTag_TextChanged(object sender, EventArgs e)
        {

        }
    }
}