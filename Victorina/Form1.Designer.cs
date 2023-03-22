namespace Victorina
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
            this.btn_startQuiz = new System.Windows.Forms.Button();
            this.btn_TopSore = new System.Windows.Forms.Button();
            this.btn_UserChange = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startQuiz
            // 
            this.btn_startQuiz.Location = new System.Drawing.Point(98, 60);
            this.btn_startQuiz.Name = "btn_startQuiz";
            this.btn_startQuiz.Size = new System.Drawing.Size(237, 23);
            this.btn_startQuiz.TabIndex = 0;
            this.btn_startQuiz.Text = "Начать викторину";
            this.btn_startQuiz.UseVisualStyleBackColor = true;
            this.btn_startQuiz.Click += new System.EventHandler(this.btn_startQuiz_Click);
            // 
            // btn_TopSore
            // 
            this.btn_TopSore.Location = new System.Drawing.Point(98, 101);
            this.btn_TopSore.Name = "btn_TopSore";
            this.btn_TopSore.Size = new System.Drawing.Size(237, 23);
            this.btn_TopSore.TabIndex = 1;
            this.btn_TopSore.Text = "Зал славы";
            this.btn_TopSore.UseVisualStyleBackColor = true;
            this.btn_TopSore.Click += new System.EventHandler(this.btn_TopSore_Click);
            // 
            // btn_UserChange
            // 
            this.btn_UserChange.Location = new System.Drawing.Point(98, 140);
            this.btn_UserChange.Name = "btn_UserChange";
            this.btn_UserChange.Size = new System.Drawing.Size(237, 23);
            this.btn_UserChange.TabIndex = 3;
            this.btn_UserChange.Text = "Изменить игрока";
            this.btn_UserChange.UseVisualStyleBackColor = true;
            this.btn_UserChange.Click += new System.EventHandler(this.btn_UserChange_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(98, 179);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(237, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Выйти";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 315);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_UserChange);
            this.Controls.Add(this.btn_TopSore);
            this.Controls.Add(this.btn_startQuiz);
            this.Name = "Form1";
            this.Text = "Викторина";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_startQuiz;
        private Button btn_TopSore;
        private Button btn_UserChange;
        private Button btn_Exit;
    }
}