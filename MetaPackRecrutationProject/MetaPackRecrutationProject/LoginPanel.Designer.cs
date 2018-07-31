namespace MetaPackRecrutationProject
{
    partial class LoginPanel
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.WarningText = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(150, 200);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(200, 50);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.ZALOGUJ_Click);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(150, 110);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(200, 20);
            this.EmailText.TabIndex = 2;
            this.EmailText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(150, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(130, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Podaj nazwe uzytkownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj swoj e-mail";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(150, 71);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(200, 20);
            this.NameText.TabIndex = 1;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // WarningText
            // 
            this.WarningText.AutoSize = true;
            this.WarningText.Location = new System.Drawing.Point(150, 20);
            this.WarningText.Name = "WarningText";
            this.WarningText.Size = new System.Drawing.Size(0, 13);
            this.WarningText.TabIndex = 5;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(150, 133);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(146, 13);
            this.pass.TabIndex = 6;
            this.pass.Text = "Podaj haslo do swojego meila";
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(150, 149);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(200, 20);
            this.passText.TabIndex = 3;
            this.passText.TextChanged += new System.EventHandler(this.passText_TextChanged);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.WarningText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginPanel";
            this.Text = "LoginPanel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label WarningText;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox passText;
    }
}

