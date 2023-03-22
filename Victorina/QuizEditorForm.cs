using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victorina
{
    public partial class QuizEditorForm : Form
    {
        List<Quiz> quizList;
        Quiz activeQuiz;
        int activeIndex = 0;
        bool modifedQuestion = false;
        public QuizEditorForm(ref List<Quiz> quizList)
        {
            InitializeComponent();
            this.quizList = quizList;            
            clb_answers.CheckOnClick = true;//выделение с одного щелчка
            if (quizList.Count > 0)
            {
                foreach (var item in quizList)
                {
                    cb_quizList.Items.Add(item.Name);
                }
                cb_quizList.SelectedIndex = 0;
                activeQuiz = quizList[0];
                ShowQuestion(activeIndex);
            }
        }

        private void QuizEditorForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_createQuiz_Click(object sender, EventArgs e)//Создать викторину
        {
            int index;
            cb_quizList.Items.Add(tb_quizName.Text);
            cb_quizList.SelectedItem = tb_quizName.Text;
            quizList.Add(new Quiz(tb_quizName.Text));
            index = cb_quizList.Items.Count - 1;
            cb_quizList.SelectedItem = cb_quizList.Items[index];
            activeQuiz = quizList[index];
            lbl_message.Text = $"Викторина {tb_quizName.Text} создана";
            tb_quizName.Text = String.Empty;
            activeIndex = 0;
            ShowQuestion(activeIndex);
        }

        private void cb_quizList_SelectedIndexChanged(object sender, EventArgs e)//смена активной викторины в списке
        {
            int index = cb_quizList.SelectedIndex;
            if(quizList.Count > index)
            {
                activeQuiz = quizList[index];
                activeIndex = 0;
                ShowQuestion(activeIndex);
                lbl_message.Text = $"Викторина {tb_quizName.Text} выбрана";
            }          
        }

        private void ShowQuestion(int index)//показать вопрос
        {            
            if (index >= 20)
                index = 19;
            else if (index <= 0)
                index = 0;

            if(activeQuiz.Count > index)//Если вопрос уже существует, то показываем его
            {
                Question temp = activeQuiz.GetQuestion(index);
                rtb_question.Text = temp.question;
                clb_answers.Items.Clear();
                clb_answers.Items.AddRange(temp.answers);

                
                foreach(int value in temp.correct)
                {
                    clb_answers.SetItemChecked(value, true);
                }

                tb_score.Text = temp.score.ToString();
            }
            else//если вопрос не существует, то чистим форму
            {
                ClearForms();
            }

            modifedQuestion = false;            
            lbl_actualQuestion.Text = $"Вопрос №{index + 1}";
        }

        private bool AddQuestion()//добавить вопрос
        {
            if (!int.TryParse(tb_score.Text, out int score))
            {
                MessageBox.Show("Количество очков за правильный ответ не назначено или назначено неверно");
                return false;
            }

            int[] correct = new int[clb_answers.CheckedIndices.Count];
            for (int i = 0; i < correct.Length; i++)
                correct[i] = clb_answers.CheckedIndices[i];

            if(correct.Length == 0)
            {
                MessageBox.Show("Вы не задали правильные ответы");
                return false;
            }

            string[] answers = new string[clb_answers.Items.Count];
            for (int i = 0; i < answers.Length; i++)
                answers[i] = clb_answers.Items[i].ToString();

            if (answers.Length == 0)
            {
                MessageBox.Show("Вы не ввели варианты ответов");
                return false;
            }
                        
            activeQuiz.Add(new Question(rtb_question.Text, answers, correct, score));
            return true;
        }

        private void ClearForms()//очистить формы ввода данных
        {
            tb_score.Text = String.Empty;
            rtb_question.Text = String.Empty;
            clb_answers.Items.Clear();
        }

        private void btn_addAnswer_Click(object sender, EventArgs e)//добавить варианты ответа
        {
            clb_answers.Items.Add(tb_addAnswer.Text);
            lbl_message.Text = $"Вариант ответа {tb_addAnswer.Text} добавлен";
            tb_addAnswer.Text = String.Empty;
            SetModifed();
        }

        private void btn_deleteAnswer_Click(object sender, EventArgs e)//Удалить один из ответов
        {
            int index;
            if (clb_answers.SelectedIndex != -1)
            {
                index = clb_answers.SelectedIndex;
                clb_answers.Items.RemoveAt(index);
                SetModifed();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)//Следующий вопрос
        {
            if(modifedQuestion)
            {
                if (AddQuestion())
                    ShowQuestion(++activeIndex);
            }
            else            
                ShowQuestion(++activeIndex);
        }

        private void btn_previous_Click(object sender, EventArgs e)//Предыдущий вопрос
        {
            if(modifedQuestion)
            {
                if (AddQuestion())
                    ShowQuestion(--activeIndex);
            }
            else
                ShowQuestion(--activeIndex);                        
        }

        private void btn_deleteQuestion_Click(object sender, EventArgs e)//Удалить вопрос
        {
            activeQuiz.Delete(activeIndex);
            ShowQuestion(--activeIndex);
        }

        private void btn_saveQuiz_Click(object sender, EventArgs e)//Сохранить викторину
        {
            activeQuiz.Save();
        }

        private void SetModifed()//вопрос считается изменённым
        {           
            if(!modifedQuestion)
            {
                lbl_actualQuestion.Text += '*';
                modifedQuestion = true;
            }            
        }

        private void rtb_question_TextChanged(object sender, EventArgs e)//вопрос считается изменённым если меняется текст вопроса
        {
            SetModifed();            
        }

        private void tb_score_TextChanged(object sender, EventArgs e)//вопрос считается изменённым если меняется количество очков
        {            
            SetModifed();
        }

        private void QuizEditorForm_FormClosing(object sender, FormClosingEventArgs e)//Сохранение викторин при закрытии формы
        {
            DialogResult dr = MessageBox.Show("При отмене все несохранённые изменения будут потеряны", "Сохранить все викторины?", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                foreach (Quiz q in quizList)
                    q.Save();
            }             
        }
    }
}
