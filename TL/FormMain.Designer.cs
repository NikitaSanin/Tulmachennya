
namespace MyDictionary
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonOpenAddForm;
        private System.Windows.Forms.ListBox listBoxSuggestions;
        private System.Windows.Forms.Label labelSuggestions;
        private System.Windows.Forms.Button buttonGoogleSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            labelResult = new Label();
            buttonOpenAddForm = new Button();
            labelSuggestions = new Label();
            listBoxSuggestions = new ListBox();
            buttonGoogleSearch = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            listBoxAllWords = new ListBox();
            label1 = new Label();
            buttonSearchByTag = new Button();
            buttonExportTxt = new Button();
            buttonImportTxt = new Button();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(30, 33);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(204, 27);
            textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(240, 30);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 32);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Пошук";
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelResult
            // 
            labelResult.AllowDrop = true;
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.Location = new Point(30, 86);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(407, 182);
            labelResult.TabIndex = 3;
            // 
            // buttonOpenAddForm
            // 
            buttonOpenAddForm.Location = new Point(30, 289);
            buttonOpenAddForm.Name = "buttonOpenAddForm";
            buttonOpenAddForm.Size = new Size(146, 37);
            buttonOpenAddForm.TabIndex = 4;
            buttonOpenAddForm.Text = "Додати слово";
            buttonOpenAddForm.Click += buttonOpenAddForm_Click;
            // 
            // labelSuggestions
            // 
            labelSuggestions.AutoSize = true;
            labelSuggestions.Location = new Point(454, 86);
            labelSuggestions.Name = "labelSuggestions";
            labelSuggestions.Size = new Size(140, 20);
            labelSuggestions.TabIndex = 5;
            labelSuggestions.Text = "Інші слова з тегом:";
            // 
            // listBoxSuggestions
            // 
            listBoxSuggestions.Location = new Point(454, 106);
            listBoxSuggestions.Name = "listBoxSuggestions";
            listBoxSuggestions.Size = new Size(177, 164);
            listBoxSuggestions.TabIndex = 6;
            // 
            // buttonGoogleSearch
            // 
            buttonGoogleSearch.Location = new Point(337, 30);
            buttonGoogleSearch.Name = "buttonGoogleSearch";
            buttonGoogleSearch.Size = new Size(100, 32);
            buttonGoogleSearch.TabIndex = 2;
            buttonGoogleSearch.Text = "Google 🔍";
            buttonGoogleSearch.Click += buttonGoogleSearch_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(302, 289);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(106, 37);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(182, 289);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(114, 37);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // listBoxAllWords
            // 
            listBoxAllWords.FormattingEnabled = true;
            listBoxAllWords.Location = new Point(657, 106);
            listBoxAllWords.Name = "listBoxAllWords";
            listBoxAllWords.Size = new Size(177, 164);
            listBoxAllWords.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(657, 86);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 10;
            label1.Text = "Всі слова:";
            // 
            // buttonSearchByTag
            // 
            buttonSearchByTag.Location = new Point(454, 289);
            buttonSearchByTag.Name = "buttonSearchByTag";
            buttonSearchByTag.Size = new Size(141, 37);
            buttonSearchByTag.TabIndex = 11;
            buttonSearchByTag.Text = "Пошук за тегом";
            buttonSearchByTag.UseVisualStyleBackColor = true;
            buttonSearchByTag.Click += buttonSearchByTag_Click;
            // 
            // buttonExportTxt
            // 
            buttonExportTxt.Location = new Point(30, 341);
            buttonExportTxt.Name = "buttonExportTxt";
            buttonExportTxt.Size = new Size(94, 29);
            buttonExportTxt.TabIndex = 12;
            buttonExportTxt.Text = "Експорт";
            buttonExportTxt.UseVisualStyleBackColor = true;
            buttonExportTxt.Click += buttonExportTxt_Click;
            // 
            // buttonImportTxt
            // 
            buttonImportTxt.Location = new Point(140, 341);
            buttonImportTxt.Name = "buttonImportTxt";
            buttonImportTxt.Size = new Size(94, 29);
            buttonImportTxt.TabIndex = 13;
            buttonImportTxt.Text = "Імпорт";
            buttonImportTxt.UseVisualStyleBackColor = true;
            buttonImportTxt.Click += buttonImportTxt_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(919, 439);
            Controls.Add(buttonImportTxt);
            Controls.Add(buttonExportTxt);
            Controls.Add(buttonSearchByTag);
            Controls.Add(label1);
            Controls.Add(listBoxAllWords);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearch);
            Controls.Add(buttonGoogleSearch);
            Controls.Add(labelResult);
            Controls.Add(buttonOpenAddForm);
            Controls.Add(labelSuggestions);
            Controls.Add(listBoxSuggestions);
            Name = "FormMain";
            Text = "Словник з тегами";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button buttonEdit;
        private Button buttonDelete;
        private ListBox listBoxAllWords;
        private Label label1;
        private Button buttonSearchByTag;
        private Button buttonExportTxt;
        private Button buttonImportTxt;
    }
}
