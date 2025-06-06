namespace MyDictionary
{
    partial class FormAdd
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.TextBox textBoxMeaning;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;

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
            textBoxWord = new TextBox();
            textBoxMeaning = new TextBox();
            textBoxTag = new TextBox();
            buttonSave = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(30, 30);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.PlaceholderText = "Слово";
            textBoxWord.Size = new Size(100, 27);
            textBoxWord.TabIndex = 0;
            // 
            // textBoxMeaning
            // 
            textBoxMeaning.Location = new Point(30, 63);
            textBoxMeaning.Name = "textBoxMeaning";
            textBoxMeaning.PlaceholderText = "Значення";
            textBoxMeaning.Size = new Size(225, 27);
            textBoxMeaning.TabIndex = 1;
            // 
            // textBoxTag
            // 
            textBoxTag.Location = new Point(30, 96);
            textBoxTag.Name = "textBoxTag";
            textBoxTag.PlaceholderText = "Тег";
            textBoxTag.Size = new Size(100, 27);
            textBoxTag.TabIndex = 2;
            textBoxTag.TextChanged += textBoxTag_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(30, 158);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(92, 30);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Зберегти";
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(180, 158);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 30);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Назад";
            buttonBack.Click += buttonBack_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(378, 282);
            Controls.Add(textBoxWord);
            Controls.Add(textBoxMeaning);
            Controls.Add(textBoxTag);
            Controls.Add(buttonSave);
            Controls.Add(buttonBack);
            Name = "Form2";
            Text = "Додати слово";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}