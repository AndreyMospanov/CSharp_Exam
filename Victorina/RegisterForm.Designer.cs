namespace Victorina
{
    partial class RegisterForm
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
            this.tb_passw = new System.Windows.Forms.TextBox();
            this.lbl_log = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_day = new System.Windows.Forms.ComboBox();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(122, 55);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(213, 23);
            this.tb_login.TabIndex = 0;
            // 
            // tb_passw
            // 
            this.tb_passw.Location = new System.Drawing.Point(122, 103);
            this.tb_passw.Name = "tb_passw";
            this.tb_passw.Size = new System.Drawing.Size(213, 23);
            this.tb_passw.TabIndex = 1;
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.Location = new System.Drawing.Point(48, 55);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(41, 15);
            this.lbl_log.TabIndex = 2;
            this.lbl_log.Text = "Логин";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(48, 106);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(49, 15);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения";
            // 
            // cb_day
            // 
            this.cb_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_day.FormattingEnabled = true;
            this.cb_day.Location = new System.Drawing.Point(122, 148);
            this.cb_day.Name = "cb_day";
            this.cb_day.Size = new System.Drawing.Size(38, 23);
            this.cb_day.TabIndex = 5;
            // 
            // cb_month
            // 
            this.cb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(166, 148);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(91, 23);
            this.cb_month.TabIndex = 6;
            // 
            // cb_year
            // 
            this.cb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(263, 148);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(72, 23);
            this.cb_year.TabIndex = 7;
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(184, 214);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(151, 23);
            this.btn_reg.TabIndex = 8;
            this.btn_reg.Text = "Зарегистрироваться";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(85, 214);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.cb_day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.tb_passw);
            this.Controls.Add(this.tb_login);
            this.Name = "RegisterForm";
            this.Text = "Зарегистрировать или изменить данные";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_login;
        private TextBox tb_passw;
        private Label lbl_log;
        private Label lbl_pass;
        private Label label3;
        private ComboBox cb_day;
        private ComboBox cb_month;
        private ComboBox cb_year;
        private Button btn_reg;
        private Button btn_cancel;
    }
}