namespace Victorina
{
    partial class AuthForm
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
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.auth_btn = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.login_lbl = new System.Windows.Forms.Label();
            this.passw_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(84, 49);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(212, 23);
            this.tb_login.TabIndex = 0;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(84, 95);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(212, 23);
            this.tb_pass.TabIndex = 1;
            // 
            // auth_btn
            // 
            this.auth_btn.Location = new System.Drawing.Point(32, 146);
            this.auth_btn.Name = "auth_btn";
            this.auth_btn.Size = new System.Drawing.Size(124, 23);
            this.auth_btn.TabIndex = 2;
            this.auth_btn.Text = "Авторизоваться";
            this.auth_btn.UseVisualStyleBackColor = true;
            this.auth_btn.Click += new System.EventHandler(this.auth_btn_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(211, 146);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(129, 23);
            this.reg_btn.TabIndex = 3;
            this.reg_btn.Text = "Зарегистрироваться";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(32, 52);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(41, 15);
            this.login_lbl.TabIndex = 4;
            this.login_lbl.Text = "Логин";
            // 
            // passw_lbl
            // 
            this.passw_lbl.AutoSize = true;
            this.passw_lbl.Location = new System.Drawing.Point(32, 98);
            this.passw_lbl.Name = "passw_lbl";
            this.passw_lbl.Size = new System.Drawing.Size(49, 15);
            this.passw_lbl.TabIndex = 5;
            this.passw_lbl.Text = "Пароль";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 193);
            this.Controls.Add(this.passw_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.auth_btn);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_login);
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_login;
        private TextBox tb_pass;
        private Button auth_btn;
        private Button reg_btn;
        private Label login_lbl;
        private Label passw_lbl;
    }
}