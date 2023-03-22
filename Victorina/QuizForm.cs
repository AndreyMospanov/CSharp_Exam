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
    public partial class QuizForm : Form
    {
        Quiz currentQuiz;
        int activeIndex = 0;
        public int score = 0;
        bool[] correctAnswers;
        public QuizForm(Quiz quiz)
        {
            InitializeComponent();
            this.currentQuiz = quiz;
            correctAnswers = new bool[currentQuiz.Count];
            correctAnswers = Enumerable.Repeat(false, correctAnswers.Length).ToArray();
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            if(activeIndex == currentQuiz.Count)
            {
                ShowResults();
            }
            else
            {
                rtb_question.Text = currentQuiz.questions[activeIndex].question;
                clb_answers.Items.Clear();
                clb_answers.Items.AddRange(currentQuiz.questions[activeIndex].answers);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (activeIndex == -1)
            {
                this.Close();
                return;
            }                

            int thisScore = 0;
            List<int> temp = new List<int>();
            
            for (int i = 0; i < clb_answers.CheckedItems.Count; i++)
            {
                temp.Add(clb_answers.CheckedIndices[i]);
            }
            thisScore += currentQuiz.questions[activeIndex].Solve(temp.ToArray());
            score += thisScore;
            if (thisScore != 0)
                correctAnswers[activeIndex] = true;
            ++activeIndex;
            ShowQuestion();
        }

        private void ShowResults()
        {
            rtb_question.Text = $"Викторина завершена. Вы набрали {score} очков\nПравильно отвеченные вопросы отмечены галочкой";
            clb_answers.Items.Clear();
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                clb_answers.Items.Add($"{currentQuiz.questions[i].question}");
                if (correctAnswers[i]) 
                    clb_answers.SetItemChecked(i, true);
            }
            activeIndex = -1;
        }
    }
}
