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
    public partial class TopScore : Form
    {
        User user;
        List<Quiz> quizList;
        public TopScore(User user, List<Quiz> quizList)
        {
            InitializeComponent();
            this.user = user;
            this.quizList = quizList;
            cb_quizList.Items.Clear();            
            if (quizList.Count > 0)
            {
                cb_quizList.Items.Add("Все викторины");
                foreach (Quiz quiz in quizList)
                {
                    cb_quizList.Items.Add(quiz.Name);
                }
                cb_quizList.SelectedIndex = 0;
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string username = "";
            lb_score.Items.Clear();
            if (cbx_onlyUser.Checked)
                username = user.Name;
            if(cb_quizList.SelectedIndex == 0)
            {                
                foreach (Quiz q in quizList)
                    lb_score.Items.AddRange(q.ShowRecord(username).ToArray());
            }
            else
            {
                lb_score.Items.AddRange(quizList[cb_quizList.SelectedIndex - 1].ShowRecord(username).ToArray());
            }
        }
    }
}
