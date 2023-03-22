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
    public partial class AuthForm : Form
    {
        public UserPool users = new UserPool();
        RegisterForm regForm;
        public User activeUser;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void auth_btn_Click(object sender, EventArgs e)
        {
            activeUser = users.Authorize(tb_login.Text, tb_pass.Text);          
            if (activeUser == null)
                MessageBox.Show("авторизация не удалась. Попробуйте ещё раз.");
            else
                this.Close();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            Register();
        }

        public void Register(User? toChange = null)
        {
            regForm = new RegisterForm(ref users, toChange);
            regForm.ShowDialog();            
            activeUser = users.LastRegistered();
            tb_login.Text = activeUser.Name;
            tb_pass.Text = "введите пароль";
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
