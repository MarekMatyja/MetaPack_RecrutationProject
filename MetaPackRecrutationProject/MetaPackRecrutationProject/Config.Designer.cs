namespace MetaPackRecrutationProject
{
    partial class Config
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EmailUser = new System.Windows.Forms.Label();
            this.Approve = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.EmailReciver = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Gmail = new System.Windows.Forms.RadioButton();
            this.WP = new System.Windows.Forms.RadioButton();
            this.Hotmail = new System.Windows.Forms.RadioButton();
            this.smtp = new System.Windows.Forms.Label();
            this.smtpText = new System.Windows.Forms.TextBox();
            this.smtpInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailUser
            // 
            this.EmailUser.AutoSize = true;
            this.EmailUser.Location = new System.Drawing.Point(12, 150);
            this.EmailUser.Name = "EmailUser";
            this.EmailUser.Size = new System.Drawing.Size(131, 13);
            this.EmailUser.TabIndex = 1;
            this.EmailUser.Text = "Adress Email Uzyrkownika";
            // 
            // Approve
            // 
            this.Approve.Location = new System.Drawing.Point(184, 296);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(75, 23);
            this.Approve.TabIndex = 2;
            this.Approve.Text = "Zatwierdz";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(238, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // EmailReciver
            // 
            this.EmailReciver.AutoSize = true;
            this.EmailReciver.Location = new System.Drawing.Point(235, 150);
            this.EmailReciver.Name = "EmailReciver";
            this.EmailReciver.Size = new System.Drawing.Size(107, 13);
            this.EmailReciver.TabIndex = 5;
            this.EmailReciver.Text = "Adres Email Odbiorcy";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 198);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(34, 13);
            this.Password.TabIndex = 6;
            this.Password.Text = "Haslo";
            // 
            // Gmail
            // 
            this.Gmail.AutoSize = true;
            this.Gmail.Location = new System.Drawing.Point(92, 43);
            this.Gmail.Name = "Gmail";
            this.Gmail.Size = new System.Drawing.Size(51, 17);
            this.Gmail.TabIndex = 7;
            this.Gmail.TabStop = true;
            this.Gmail.Text = "Gmail";
            this.Gmail.UseVisualStyleBackColor = true;
            // 
            // WP
            // 
            this.WP.AutoSize = true;
            this.WP.Location = new System.Drawing.Point(184, 43);
            this.WP.Name = "WP";
            this.WP.Size = new System.Drawing.Size(102, 17);
            this.WP.TabIndex = 8;
            this.WP.TabStop = true;
            this.WP.Text = "WirtualnaPolska";
            this.WP.UseVisualStyleBackColor = true;
            // 
            // Hotmail
            // 
            this.Hotmail.AutoSize = true;
            this.Hotmail.Location = new System.Drawing.Point(306, 43);
            this.Hotmail.Name = "Hotmail";
            this.Hotmail.Size = new System.Drawing.Size(60, 17);
            this.Hotmail.TabIndex = 9;
            this.Hotmail.TabStop = true;
            this.Hotmail.Text = "Hotmail";
            this.Hotmail.UseVisualStyleBackColor = true;
            // 
            // smtp
            // 
            this.smtp.AutoSize = true;
            this.smtp.Location = new System.Drawing.Point(162, 9);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(165, 13);
            this.smtp.TabIndex = 10;
            this.smtp.Text = "Wybierz z ktorej poczty kozystasz";
            // 
            // smtpText
            // 
            this.smtpText.Location = new System.Drawing.Point(144, 89);
            this.smtpText.Name = "smtpText";
            this.smtpText.Size = new System.Drawing.Size(198, 20);
            this.smtpText.TabIndex = 11;
            this.smtpText.TextChanged += new System.EventHandler(this.smtpText_TextChanged);
            // 
            // smtpInfo
            // 
            this.smtpInfo.AutoSize = true;
            this.smtpInfo.Location = new System.Drawing.Point(153, 73);
            this.smtpInfo.Name = "smtpInfo";
            this.smtpInfo.Size = new System.Drawing.Size(174, 13);
            this.smtpInfo.TabIndex = 12;
            this.smtpInfo.Text = "Lub podaj adres smtp swojej poczty";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 357);
            this.Controls.Add(this.smtpInfo);
            this.Controls.Add(this.smtpText);
            this.Controls.Add(this.smtp);
            this.Controls.Add(this.Hotmail);
            this.Controls.Add(this.WP);
            this.Controls.Add(this.Gmail);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.EmailReciver);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.EmailUser);
            this.Controls.Add(this.textBox1);
            this.Name = "Config";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EmailUser;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label EmailReciver;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.RadioButton Gmail;
        private System.Windows.Forms.RadioButton WP;
        private System.Windows.Forms.RadioButton Hotmail;
        private System.Windows.Forms.Label smtp;
        private System.Windows.Forms.TextBox smtpText;
        private System.Windows.Forms.Label smtpInfo;
    }
}