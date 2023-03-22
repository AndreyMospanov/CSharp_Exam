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
    public partial class RegisterForm : Form
    {        
        public UserPool users;
        User? changeUser;
        public RegisterForm(ref UserPool users, User? toChange = null)
        {
            InitializeComponent();
            this.users = users;
            btn_reg.Text = "Зарегистрироваться";
            if (toChange != null)
            {
                tb_login.Text = toChange.Name;
                btn_reg.Text = "Изменить";
                changeUser = toChange;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            ComboBoxesFill();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            users.Register(tb_login.Text.Trim(), tb_passw.Text, $"{cb_day.SelectedItem}/{cb_month.SelectedItem}/{cb_year.SelectedItem}", changeUser == null ? new Dictionary<string, List<int>>() : changeUser.myScore);            
            this.Close();
        }

        private void ComboBoxesFill()
        {
            for (int i = 1; i <= 31; i++)
                cb_day.Items.Add(i);
            

            for(int i = 1; i <= 12; i++)
                cb_month.Items.Add(i);

            for (int i = 2020; i >= 1900; i--)
                cb_year.Items.Add(i);

            cb_day.SelectedItem = cb_day.Items[0];
            cb_month.SelectedItem = cb_month.Items[0];
            cb_year.SelectedItem = cb_year.Items[0];
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            users.Save();
        }
    }
}
