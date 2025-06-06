namespace Tulmachennya
{
    partial class FormSearchByTag
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
            label1 = new Label();
            listViewWords = new ListView();
            textBoxTag = new TextBox();
            buttonFind = new Button();
            buttonView = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Введіть тег:";
            // 
            // listViewWords
            // 
            listViewWords.FullRowSelect = true;
            listViewWords.Location = new Point(12, 86);
            listViewWords.MultiSelect = false;
            listViewWords.Name = "listViewWords";
            listViewWords.Size = new Size(347, 197);
            listViewWords.TabIndex = 1;
            listViewWords.UseCompatibleStateImageBehavior = false;
            listViewWords.View = View.Tile;
            // 
            // textBoxTag
            // 
            textBoxTag.Location = new Point(12, 41);
            textBoxTag.Name = "textBoxTag";
            textBoxTag.Size = new Size(247, 27);
            textBoxTag.TabIndex = 2;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(265, 40);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(94, 29);
            buttonFind.TabIndex = 3;
            buttonFind.Text = "Пошук";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(12, 289);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(112, 30);
            buttonView.TabIndex = 4;
            buttonView.Text = "Перегляд";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(265, 290);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Закрити";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormSearchByTag
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 410);
            Controls.Add(buttonClose);
            Controls.Add(buttonView);
            Controls.Add(buttonFind);
            Controls.Add(textBoxTag);
            Controls.Add(listViewWords);
            Controls.Add(label1);
            Name = "FormSearchByTag";
            Text = "FormSearchByTag";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewWords;
        private TextBox textBoxTag;
        private Button buttonFind;
        private Button buttonView;
        private Button buttonClose;
    }
}