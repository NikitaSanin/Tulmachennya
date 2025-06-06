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

namespace Tulmachennya
{
    public partial class FormSearchByTag : Form
    {
        public FormSearchByTag()
        {
            InitializeComponent();
            listViewWords.View = View.Tile;
            listViewWords.FullRowSelect = true;
            listViewWords.MultiSelect = false;
            listViewWords.TileSize = new System.Drawing.Size(200, 30);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string tag = textBoxTag.Text.Trim();

            var results = DictionaryManager.Words
                .Where(w => w.Tag.Equals(tag, StringComparison.OrdinalIgnoreCase))
                .Select(w => w.Word)
                .ToList();

            listViewWords.Items.Clear();

            foreach (var word in results)
            {
                ListViewItem item = new ListViewItem(word);
                listViewWords.Items.Add(item);
            }

            if (results.Count == 0)
            {
                MessageBox.Show("Слів з таким тегом не знайдено.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (listViewWords.SelectedItems.Count > 0)
            {
                string selectedWord = listViewWords.SelectedItems[0].Text;
                var entry = DictionaryManager.Words.FirstOrDefault(w => w.Word == selectedWord);

                if (entry != null)
                {
                    MessageBox.Show($"Слово: {entry.Word}\nЗначення: {entry.Meaning}", "Перегляд слова", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
