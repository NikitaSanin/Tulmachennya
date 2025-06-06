namespace TL
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxWord = new TextBox();
            textBoxMeaning = new TextBox();
            textBoxTag = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            word = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(44, 52);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(195, 27);
            textBoxWord.TabIndex = 0;
            textBoxWord.TextChanged += textBoxWord_TextChanged;
            // 
            // textBoxMeaning
            // 
            textBoxMeaning.Location = new Point(44, 108);
            textBoxMeaning.Multiline = true;
            textBoxMeaning.Name = "textBoxMeaning";
            textBoxMeaning.ScrollBars = ScrollBars.Vertical;
            textBoxMeaning.Size = new Size(350, 154);
            textBoxMeaning.TabIndex = 1;
            textBoxMeaning.TextChanged += textBoxMeaning_TextChanged;
            // 
            // textBoxTag
            // 
            textBoxTag.Location = new Point(44, 288);
            textBoxTag.Name = "textBoxTag";
            textBoxTag.Size = new Size(195, 27);
            textBoxTag.TabIndex = 2;
            textBoxTag.TextChanged += textBoxTag_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(44, 358);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(300, 358);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // word
            // 
            word.AutoSize = true;
            word.Location = new Point(44, 29);
            word.Name = "word";
            word.Size = new Size(55, 20);
            word.TabIndex = 5;
            word.Text = "Слово:";
            word.Click += word_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 85);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 6;
            label1.Text = "Значення:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 265);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 7;
            label2.Text = "Тег:";
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(word);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxTag);
            Controls.Add(textBoxMeaning);
            Controls.Add(textBoxWord);
            Name = "FormEdit";
            Text = "FormEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWord;
        private TextBox textBoxMeaning;
        private TextBox textBoxTag;
        private Button buttonSave;
        private Button buttonCancel;
        private Label word;
        private Label label1;
        private Label label2;
    }
}