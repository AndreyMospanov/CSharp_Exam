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
    public partial class QuizSelector : Form
    {
        public List<Quiz> quizList;
        public QuizForm? quizForm;
        internal QuizEditorForm? quizEditorForm;
        public User user;
        public QuizSelector(User user)
        {
            InitializeComponent();            
            quizList = new List<Quiz>();
            this.user = user;
            if (!Directory.Exists("Quiz"))
                Directory.CreateDirectory("Quiz");

            LoadQuiz();                        
            RefreshData();
        }

        private void QuizSelector_Load(object sender, EventArgs e) { }
        
        private void btn_startQuiz_Click(object sender, EventArgs e)
        {
            quizList.Add(RandomQuiz());//создаём случайную викторину каждый раз разную при нажатии кнопки прохождения викторины
            quizForm = new QuizForm(quizList[cb_quizList.SelectedIndex]);
            quizForm.ShowDialog();           
            quizList[cb_quizList.SelectedIndex].AddScore(user.Name, quizForm.score);
            user.AddScore(quizList[cb_quizList.SelectedIndex].Name, quizForm.score);
            quizList.Remove(quizList[quizList.Count - 1]);//удаляем случайную викторину после прохождения
        }

        private void LoadQuiz()
        {
            if(Directory.GetFiles("Quiz").Length > 0)
            {
                foreach (string file in Directory.GetFiles("Quiz"))
                {
                    string nameQ;
                    nameQ = file.Replace(@"Quiz\", "");
                    nameQ = nameQ.Replace(".txt", "");                    
                    quizList.Add(new Quiz(nameQ));
                }
            }            
        }

        private void btn_editQuiz_Click(object sender, EventArgs e)
        {            
            quizEditorForm = new QuizEditorForm(ref quizList);
            quizEditorForm.ShowDialog();            
            RefreshData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshData()
        {
            cb_quizList.Items.Clear();
            if(quizList.Count > 0)
            {
                foreach (Quiz quiz in quizList)
                {
                    cb_quizList.Items.Add(quiz.Name);
                }
                cb_quizList.Items.Add("Викторина со случайными вопросами");
                cb_quizList.SelectedIndex = 0;
            }            
        }

        private void QuizSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Quiz quiz in quizList)
            {
                quiz.Save();
            }
        }

        private Quiz RandomQuiz()
        {
            Quiz result = new Quiz("Викторина со случайными вопросами");
            Random rnd = new Random(); ;
            foreach(Quiz quiz in quizList)
            {
                List<int> nums = new List<int>();
                int reallyRandom;
                int count = quiz.Count / quizList.Count < 0 ? 1 : quiz.Count / quizList.Count;//регулируем количество вопросов в зависимости от количества викторин и вопросов в них
                
                for (int i = 0; i < count; i++)
                {                    
                    do
                    {
                        reallyRandom = rnd.Next(0, quiz.Count);
                    }
                    while (nums.Contains(reallyRandom));//перебираем уже бывшие номера во избежание повторений                    
                    nums.Add(reallyRandom);

                    result.Add(quiz.GetQuestion(reallyRandom));
                } 
            }

            return result;
        }
    }
}
