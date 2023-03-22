namespace CSharp_Exam_Mospanov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.translate_btn = new System.Windows.Forms.Button();
            this.ForeignText = new System.Windows.Forms.RichTextBox();
            this.TranslatedText = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.Export_Btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // translate_btn
            // 
            this.translate_btn.Location = new System.Drawing.Point(343, 263);
            this.translate_btn.Name = "translate_btn";
            this.translate_btn.Size = new System.Drawing.Size(93, 23);
            this.translate_btn.TabIndex = 0;
            this.translate_btn.Text = "Перевести";
            this.translate_btn.UseVisualStyleBackColor = true;
            this.translate_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForeignText
            // 
            this.ForeignText.Location = new System.Drawing.Point(80, 76);
            this.ForeignText.Name = "ForeignText";
            this.ForeignText.Size = new System.Drawing.Size(265, 161);
            this.ForeignText.TabIndex = 1;
            this.ForeignText.Text = "";
            // 
            // TranslatedText
            // 
            this.TranslatedText.Location = new System.Drawing.Point(431, 76);
            this.TranslatedText.Name = "TranslatedText";
            this.TranslatedText.Size = new System.Drawing.Size(265, 161);
            this.TranslatedText.TabIndex = 2;
            this.TranslatedText.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(266, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(638, 12);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(107, 52);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Редактирование словарей";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // Export_Btn
            // 
            this.Export_Btn.Location = new System.Drawing.Point(597, 329);
            this.Export_Btn.Name = "Export_Btn";
            this.Export_Btn.Size = new System.Drawing.Size(148, 23);
            this.Export_Btn.TabIndex = 5;
            this.Export_Btn.Text = "Экспортировать в файл";
            this.Export_Btn.UseVisualStyleBackColor = true;
            this.Export_Btn.Click += new System.EventHandler(this.Export_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 364);
            this.Controls.Add(this.Export_Btn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TranslatedText);
            this.Controls.Add(this.ForeignText);
            this.Controls.Add(this.translate_btn);
            this.Name = "Form1";
            this.Text = "Словарь";
            this.ResumeLayout(false);

        }

        #endregion

        private Button translate_btn;
        private RichTextBox ForeignText;
        private RichTextBox TranslatedText;
        private ComboBox comboBox1;
        private Button EditBtn;
        private Button Export_Btn;
        private SaveFileDialog saveFileDialog1;
    }
}