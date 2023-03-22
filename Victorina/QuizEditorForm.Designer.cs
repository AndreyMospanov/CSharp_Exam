namespace Victorina
{
    partial class QuizEditorForm
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
            this.tb_quizName = new System.Windows.Forms.TextBox();
            this.btn_createQuiz = new System.Windows.Forms.Button();
            this.lbl_newQuizName = new System.Windows.Forms.Label();
            this.lbl_activeQuiz = new System.Windows.Forms.Label();
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.clb_answers = new System.Windows.Forms.CheckedListBox();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.tb_addAnswer = new System.Windows.Forms.TextBox();
            this.btn_addAnswer = new System.Windows.Forms.Button();
            this.lbl_actualQuestion = new System.Windows.Forms.Label();
            this.btn_deleteAnswer = new System.Windows.Forms.Button();
            this.btn_deleteQuestion = new System.Windows.Forms.Button();
            this.btn_saveQuiz = new System.Windows.Forms.Button();
            this.lbl_debug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_quizList
            // 
            this.cb_quizList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_quizList.FormattingEnabled = true;
            this.cb_quizList.Location = new System.Drawing.Point(386, 31);
            this.cb_quizList.Name = "cb_quizList";
            this.cb_quizList.Size = new System.Drawing.Size(270, 23);
            this.cb_quizList.TabIndex = 0;
            this.cb_quizList.SelectedIndexChanged += new System.EventHandler(this.cb_quizList_SelectedIndexChanged);
            // 
            // tb_quizName
            // 
            this.tb_quizName.Location = new System.Drawing.Point(12, 31);
            this.tb_quizName.Name = "tb_quizName";
            this.tb_quizName.Size = new System.Drawing.Size(256, 23);
            this.tb_quizName.TabIndex = 1;
            // 
            // btn_createQuiz
            // 
            this.btn_createQuiz.Location = new System.Drawing.Point(274, 12);
            this.btn_createQuiz.Name = "btn_createQuiz";
            this.btn_createQuiz.Size = new System.Drawing.Size(106, 42);
            this.btn_createQuiz.TabIndex = 2;
            this.btn_createQuiz.Text = "Создать викторину";
            this.btn_createQuiz.UseVisualStyleBackColor = true;
            this.btn_createQuiz.Click += new System.EventHandler(this.btn_createQuiz_Click);
            // 
            // lbl_newQuizName
            // 
            this.lbl_newQuizName.AutoSize = true;
            this.lbl_newQuizName.Location = new System.Drawing.Point(12, 9);
            this.lbl_newQuizName.Name = "lbl_newQuizName";
            this.lbl_newQuizName.Size = new System.Drawing.Size(160, 15);
            this.lbl_newQuizName.TabIndex = 3;
            this.lbl_newQuizName.Text = "Название новой викторины";
            // 
            // lbl_activeQuiz
            // 
            this.lbl_activeQuiz.AutoSize = true;
            this.lbl_activeQuiz.Location = new System.Drawing.Point(386, 9);
            this.lbl_activeQuiz.Name = "lbl_activeQuiz";
            this.lbl_activeQuiz.Size = new System.Drawing.Size(130, 15);
            this.lbl_activeQuiz.TabIndex = 4;
            this.lbl_activeQuiz.Text = "Выбранная викторина";
            // 
            // rtb_question
            // 
            this.rtb_question.Location = new System.Drawing.Point(12, 147);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.Size = new System.Drawing.Size(256, 96);
            this.rtb_question.TabIndex = 5;
            this.rtb_question.Text = "";
            this.rtb_question.TextChanged += new System.EventHandler(this.rtb_question_TextChanged);
            // 
            // clb_answers
            // 
            this.clb_answers.FormattingEnabled = true;
            this.clb_answers.Location = new System.Drawing.Point(386, 147);
            this.clb_answers.Name = "clb_answers";
            this.clb_answers.Size = new System.Drawing.Size(270, 94);
            this.clb_answers.TabIndex = 6;
            // 
            // tb_score
            // 
            this.tb_score.Location = new System.Drawing.Point(239, 266);
            this.tb_score.Name = "tb_score";
            this.tb_score.Size = new System.Drawing.Size(29, 23);
            this.tb_score.TabIndex = 7;
            this.tb_score.TextChanged += new System.EventHandler(this.tb_score_TextChanged);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(12, 269);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(226, 15);
            this.lbl_score.TabIndex = 8;
            this.lbl_score.Text = "Количество очков за правильный ответ";
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(174, 320);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(94, 50);
            this.btn_previous.TabIndex = 9;
            this.btn_previous.Text = "Предыдущий вопрос";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(386, 320);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(94, 50);
            this.btn_Next.TabIndex = 10;
            this.btn_Next.Text = "Следующий вопрос";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_message.Location = new System.Drawing.Point(12, 78);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(170, 21);
            this.lbl_message.TabIndex = 11;
            this.lbl_message.Text = "системное сообщение";
            // 
            // tb_addAnswer
            // 
            this.tb_addAnswer.Location = new System.Drawing.Point(386, 108);
            this.tb_addAnswer.Name = "tb_addAnswer";
            this.tb_addAnswer.Size = new System.Drawing.Size(270, 23);
            this.tb_addAnswer.TabIndex = 12;
            // 
            // btn_addAnswer
            // 
            this.btn_addAnswer.Location = new System.Drawing.Point(274, 107);
            this.btn_addAnswer.Name = "btn_addAnswer";
            this.btn_addAnswer.Size = new System.Drawing.Size(106, 23);
            this.btn_addAnswer.TabIndex = 13;
            this.btn_addAnswer.Text = "Добавить ответ";
            this.btn_addAnswer.UseVisualStyleBackColor = true;
            this.btn_addAnswer.Click += new System.EventHandler(this.btn_addAnswer_Click);
            // 
            // lbl_actualQuestion
            // 
            this.lbl_actualQuestion.AutoSize = true;
            this.lbl_actualQuestion.Location = new System.Drawing.Point(13, 124);
            this.lbl_actualQuestion.Name = "lbl_actualQuestion";
            this.lbl_actualQuestion.Size = new System.Drawing.Size(64, 15);
            this.lbl_actualQuestion.TabIndex = 14;
            this.lbl_actualQuestion.Text = "Вопрос №";
            // 
            // btn_deleteAnswer
            // 
            this.btn_deleteAnswer.Location = new System.Drawing.Point(274, 136);
            this.btn_deleteAnswer.Name = "btn_deleteAnswer";
            this.btn_deleteAnswer.Size = new System.Drawing.Size(106, 23);
            this.btn_deleteAnswer.TabIndex = 15;
            this.btn_deleteAnswer.Text = "Удалить ответ";
            this.btn_deleteAnswer.UseVisualStyleBackColor = true;
            this.btn_deleteAnswer.Click += new System.EventHandler(this.btn_deleteAnswer_Click);
            // 
            // btn_deleteQuestion
            // 
            this.btn_deleteQuestion.Location = new System.Drawing.Point(274, 322);
            this.btn_deleteQuestion.Name = "btn_deleteQuestion";
            this.btn_deleteQuestion.Size = new System.Drawing.Size(106, 48);
            this.btn_deleteQuestion.TabIndex = 16;
            this.btn_deleteQuestion.Text = "Удалить вопрос";
            this.btn_deleteQuestion.UseVisualStyleBackColor = true;
            this.btn_deleteQuestion.Click += new System.EventHandler(this.btn_deleteQuestion_Click);
            // 
            // btn_saveQuiz
            // 
            this.btn_saveQuiz.Location = new System.Drawing.Point(274, 60);
            this.btn_saveQuiz.Name = "btn_saveQuiz";
            this.btn_saveQuiz.Size = new System.Drawing.Size(106, 42);
            this.btn_saveQuiz.TabIndex = 17;
            this.btn_saveQuiz.Text = "Сохранить викторину";
            this.btn_saveQuiz.UseVisualStyleBackColor = true;
            this.btn_saveQuiz.Click += new System.EventHandler(this.btn_saveQuiz_Click);
            // 
            // lbl_debug
            // 
            this.lbl_debug.AutoSize = true;
            this.lbl_debug.Location = new System.Drawing.Point(513, 365);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(44, 15);
            this.lbl_debug.TabIndex = 18;
            this.lbl_debug.Text = "debug:";
            // 
            // QuizEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 389);
            this.Controls.Add(this.lbl_debug);
            this.Controls.Add(this.btn_saveQuiz);
            this.Controls.Add(this.btn_deleteQuestion);
            this.Controls.Add(this.btn_deleteAnswer);
            this.Controls.Add(this.lbl_actualQuestion);
            this.Controls.Add(this.btn_addAnswer);
            this.Controls.Add(this.tb_addAnswer);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.tb_score);
            this.Controls.Add(this.clb_answers);
            this.Controls.Add(this.rtb_question);
            this.Controls.Add(this.lbl_activeQuiz);
            this.Controls.Add(this.lbl_newQuizName);
            this.Controls.Add(this.btn_createQuiz);
            this.Controls.Add(this.tb_quizName);
            this.Controls.Add(this.cb_quizList);
            this.Name = "QuizEditorForm";
            this.Text = "Редактор Викторин";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_quizList;
        private TextBox tb_quizName;
        private Button btn_createQuiz;
        private Label lbl_newQuizName;
        private Label lbl_activeQuiz;
        private RichTextBox rtb_question;
        private CheckedListBox clb_answers;
        private TextBox tb_score;
        private Label lbl_score;
        private Button btn_previous;
        private Button btn_Next;
        private Label lbl_message;
        private TextBox tb_addAnswer;
        private Button btn_addAnswer;
        private Label lbl_actualQuestion;
        private Button btn_deleteAnswer;
        private Button btn_deleteQuestion;
        private Button btn_saveQuiz;
        private Label lbl_debug;
    }
}