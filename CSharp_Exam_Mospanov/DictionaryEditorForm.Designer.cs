namespace CSharp_Exam_Mospanov
{
    partial class DictionaryEditorForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreateDict_Btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddTranslate_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Translated_Word = new System.Windows.Forms.ListBox();
            this.DeleteTranslate_Btn = new System.Windows.Forms.Button();
            this.DeleteWord_Btn = new System.Windows.Forms.Button();
            this.Change_Btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Выберите словарь или создайте новый";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreateDict_Btn
            // 
            this.CreateDict_Btn.Location = new System.Drawing.Point(383, 12);
            this.CreateDict_Btn.Name = "CreateDict_Btn";
            this.CreateDict_Btn.Size = new System.Drawing.Size(135, 23);
            this.CreateDict_Btn.TabIndex = 1;
            this.CreateDict_Btn.Text = "Создать словарь";
            this.CreateDict_Btn.UseVisualStyleBackColor = true;
            this.CreateDict_Btn.Click += new System.EventHandler(this.CreateDict_Btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddTranslate_Btn
            // 
            this.AddTranslate_Btn.Location = new System.Drawing.Point(220, 231);
            this.AddTranslate_Btn.Name = "AddTranslate_Btn";
            this.AddTranslate_Btn.Size = new System.Drawing.Size(115, 40);
            this.AddTranslate_Btn.TabIndex = 4;
            this.AddTranslate_Btn.Text = "Добавить перевод";
            this.AddTranslate_Btn.UseVisualStyleBackColor = true;
            this.AddTranslate_Btn.Click += new System.EventHandler(this.AddTranslate_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Иностранное слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Добавить перевод";
            // 
            // Translated_Word
            // 
            this.Translated_Word.FormattingEnabled = true;
            this.Translated_Word.ItemHeight = 15;
            this.Translated_Word.Location = new System.Drawing.Point(317, 161);
            this.Translated_Word.Name = "Translated_Word";
            this.Translated_Word.Size = new System.Drawing.Size(199, 64);
            this.Translated_Word.TabIndex = 7;
            this.Translated_Word.ValueMemberChanged += new System.EventHandler(this.Translated_Word_ValueMemberChanged);
            // 
            // DeleteTranslate_Btn
            // 
            this.DeleteTranslate_Btn.Location = new System.Drawing.Point(401, 231);
            this.DeleteTranslate_Btn.Name = "DeleteTranslate_Btn";
            this.DeleteTranslate_Btn.Size = new System.Drawing.Size(115, 40);
            this.DeleteTranslate_Btn.TabIndex = 8;
            this.DeleteTranslate_Btn.Text = "Удалить перевод";
            this.DeleteTranslate_Btn.UseVisualStyleBackColor = true;
            this.DeleteTranslate_Btn.Click += new System.EventHandler(this.DeleteTranslate_Btn_Click);
            // 
            // DeleteWord_Btn
            // 
            this.DeleteWord_Btn.Location = new System.Drawing.Point(31, 231);
            this.DeleteWord_Btn.Name = "DeleteWord_Btn";
            this.DeleteWord_Btn.Size = new System.Drawing.Size(115, 40);
            this.DeleteWord_Btn.TabIndex = 9;
            this.DeleteWord_Btn.Text = "Удалить слово";
            this.DeleteWord_Btn.UseVisualStyleBackColor = true;
            this.DeleteWord_Btn.Click += new System.EventHandler(this.DeleteWord_Btn_Click);
            // 
            // Change_Btn
            // 
            this.Change_Btn.Location = new System.Drawing.Point(81, 140);
            this.Change_Btn.Name = "Change_Btn";
            this.Change_Btn.Size = new System.Drawing.Size(105, 21);
            this.Change_Btn.TabIndex = 10;
            this.Change_Btn.Text = "Исправить на:";
            this.Change_Btn.UseVisualStyleBackColor = true;
            this.Change_Btn.Click += new System.EventHandler(this.Change_Btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 23);
            this.textBox2.TabIndex = 11;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(383, 41);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(135, 23);
            this.Save_Btn.TabIndex = 12;
            this.Save_Btn.Text = "Сохранить словарь";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(317, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 23);
            this.textBox3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Существующий перевод";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(37, 197);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(16, 15);
            this.stateLabel.TabIndex = 15;
            this.stateLabel.Text = "...";
            // 
            // DictionaryEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 302);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Change_Btn);
            this.Controls.Add(this.DeleteWord_Btn);
            this.Controls.Add(this.DeleteTranslate_Btn);
            this.Controls.Add(this.Translated_Word);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddTranslate_Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CreateDict_Btn);
            this.Controls.Add(this.comboBox1);
            this.Name = "DictionaryEditorForm";
            this.Text = "Редактор словарей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DictionaryEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.DictionaryEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Button CreateDict_Btn;
        private TextBox textBox1;
        private Button AddTranslate_Btn;
        private Label label1;
        private Label label2;
        private ListBox Translated_Word;
        private Button DeleteTranslate_Btn;
        private Button DeleteWord_Btn;
        private Button Change_Btn;
        private TextBox textBox2;
        private Button Save_Btn;
        private TextBox textBox3;
        private Label label3;
        private Label stateLabel;
    }
}