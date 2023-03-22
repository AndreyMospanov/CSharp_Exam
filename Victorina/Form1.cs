namespace Victorina
{
    public partial class Form1 : Form
    {
        public AuthForm authForm;
        public TopScore? topScore;
        public QuizSelector? quizSelector;

        public Form1()
        {
            InitializeComponent();
            authForm = new AuthForm();
        }

        private void Form1_Load(object sender, EventArgs e)//при загрузке программы авторизируемс€/регистрируемс€
        {            
            authForm.ShowDialog();
            if(authForm.activeUser == null)
            {                
                MessageBox.Show("ѕользователь не авторизировалс€. ѕриложение будет закрыто");
                this.Close();
            }
        }

        private void btn_startQuiz_Click(object sender, EventArgs e)
        {
            quizSelector = new QuizSelector(authForm.activeUser);
            quizSelector.ShowDialog();
            authForm.activeUser.myScore = quizSelector.user.myScore;//ѕосле прохождени€ викторин обновл€ем рекорды текущего пользовател€
        }

        private void btn_TopSore_Click(object sender, EventArgs e)
        {
            topScore = new TopScore(authForm.activeUser, quizSelector == null ? LoadQuiz() : quizSelector.quizList);
            topScore.ShowDialog();
        }

        private void btn_UserChange_Click(object sender, EventArgs e)
        {
            User temp = authForm.activeUser;
            authForm.users.DeleteUser(authForm.activeUser);
            authForm.Register(temp);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            authForm.users.Save();
        }

        private List<Quiz> LoadQuiz()
        {
            List<Quiz> quizList = new List<Quiz>();
            if (Directory.GetFiles("Quiz").Length > 0)
            {
                foreach (string file in Directory.GetFiles("Quiz"))
                {
                    string nameQ;
                    nameQ = file.Replace(@"Quiz\", "");
                    nameQ = nameQ.Replace(".txt", "");
                    quizList.Add(new Quiz(nameQ));
                }
            }

            return quizList;
        }
    }
}