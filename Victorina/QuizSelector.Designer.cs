namespace Victorina
{
    partial class QuizSelector
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
            this.cb_quizList = new System.Windows.Forms.ComboBox();
            this.btn_startQuiz = new System.Windows.Forms.Button();
            this.btn_editQuiz = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_quizList
            // 
            this.cb_quizList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_quizList.FormattingEnabled = true;
            this.cb_quizList.Location = new System.Drawing.Point(72, 26);
            this.cb_quizList.Name = "cb_quizList";
            this.cb_quizList.Size = new System.Drawing.Size(252, 23);
            this.cb_quizList.TabIndex = 0;
            // 
            // btn_startQuiz
            // 
            this.btn_startQuiz.Location = new System.Drawing.Point(121, 64);
            this.btn_startQuiz.Name = "btn_startQuiz";
            this.btn_startQuiz.Size = new System.Drawing.Size(159, 23);
            this.btn_startQuiz.TabIndex = 1;
            this.btn_startQuiz.Text = "Начать викторину";
            this.btn_startQuiz.UseVisualStyleBackColor = true;
            this.btn_startQuiz.Click += new System.EventHandler(this.btn_startQuiz_Click);
            // 
            // btn_editQuiz
            // 
            this.btn_editQuiz.Location = new System.Drawing.Point(121, 93);
            this.btn_editQuiz.Name = "btn_editQuiz";
            this.btn_editQuiz.Size = new System.Drawing.Size(159, 23);
            this.btn_editQuiz.TabIndex = 2;
            this.btn_editQuiz.Text = "Редактировать викторины";
            this.btn_editQuiz.UseVisualStyleBackColor = true;
            this.btn_editQuiz.Click += new System.EventHandler(this.btn_editQuiz_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(121, 122);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(159, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // QuizSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 156);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_editQuiz);
            this.Controls.Add(this.btn_startQuiz);
            this.Controls.Add(this.cb_quizList);
            this.Name = "QuizSelector";
            this.Text = "QuizSelector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizSelector_FormClosing);
            this.Load += new System.EventHandler(this.QuizSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cb_quizList;
        private Button btn_startQuiz;
        private Button btn_editQuiz;
        private Button btn_exit;
    }
}