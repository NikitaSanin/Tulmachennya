using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDictionary;
using Tulmachennya;


namespace TL
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }
        private DictionaryEntry _entry;

        public FormEdit(DictionaryEntry entry)
        {
            InitializeComponent();
            _entry = entry;

            textBoxWord.Text = entry.Word;
            textBoxMeaning.Text = entry.Meaning;
            textBoxTag.Text = entry.Tag;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _entry.Word = textBoxWord.Text.Trim();
            _entry.Meaning = textBoxMeaning.Text.Trim();
            _entry.Tag = textBoxTag.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void word_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMeaning_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
