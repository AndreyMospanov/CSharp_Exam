namespace Victorina
{
    partial class QuizForm
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
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.clb_answers = new System.Windows.Forms.CheckedListBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_question
            // 
            this.rtb_question.Location = new System.Drawing.Point(36, 26);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.Size = new System.Drawing.Size(212, 220);
            this.rtb_question.TabIndex = 0;
            this.rtb_question.Text = "";
            // 
            // clb_answers
            // 
            this.clb_answers.FormattingEnabled = true;
            this.clb_answers.Location = new System.Drawing.Point(308, 26);
            this.clb_answers.Name = "clb_answers";
            this.clb_answers.Size = new System.Drawing.Size(277, 220);
            this.clb_answers.TabIndex = 5;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(454, 252);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(131, 46);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "Следующий вопрос";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 321);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.clb_answers);
            this.Controls.Add(this.rtb_question);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtb_question;
        private CheckedListBox clb_answers;
        private Button btn_next;
    }
}