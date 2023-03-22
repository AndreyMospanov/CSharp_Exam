namespace Victorina
{
    partial class TopScore
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
            this.lb_score = new System.Windows.Forms.ListBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.cb_quizList = new System.Windows.Forms.ComboBox();
            this.cbx_onlyUser = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_score
            // 
            this.lb_score.FormattingEnabled = true;
            this.lb_score.ItemHeight = 15;
            this.lb_score.Location = new System.Drawing.Point(91, 47);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(229, 289);
            this.lb_score.TabIndex = 0;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(162, 387);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "Показать";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // cb_quizList
            // 
            this.cb_quizList.FormattingEnabled = true;
            this.cb_quizList.Location = new System.Drawing.Point(91, 12);
            this.cb_quizList.Name = "cb_quizList";
            this.cb_quizList.Size = new System.Drawing.Size(229, 23);
            this.cb_quizList.TabIndex = 2;
            // 
            // cbx_onlyUser
            // 
            this.cbx_onlyUser.AutoSize = true;
            this.cbx_onlyUser.Location = new System.Drawing.Point(91, 344);
            this.cbx_onlyUser.Name = "cbx_onlyUser";
            this.cbx_onlyUser.Size = new System.Drawing.Size(156, 19);
            this.cbx_onlyUser.TabIndex = 3;
            this.cbx_onlyUser.Text = "Только мои результаты";
            this.cbx_onlyUser.UseVisualStyleBackColor = true;
            // 
            // TopScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.cbx_onlyUser);
            this.Controls.Add(this.cb_quizList);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.lb_score);
            this.Name = "TopScore";
            this.Text = "TopScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lb_score;
        private Button btn_show;
        private ComboBox cb_quizList;
        private CheckBox cbx_onlyUser;
    }
}