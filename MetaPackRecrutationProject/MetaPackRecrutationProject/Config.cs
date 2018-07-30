using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaPackRecrutationProject
{
    public partial class Config : Form
    {
      
        
        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            textBox1.Text = LoginPanel.ControllID.IdEmail;
            textBox2.Text = LoginPanel.ControllID.Credentials;
            textBox3.Text = LoginPanel.ControllID.Reciver;
            Gmail.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            LoginPanel.ControllID.IdEmail = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 20;
            LoginPanel.ControllID.Credentials = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            LoginPanel.ControllID.Reciver = textBox3.Text;
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            if (Gmail.Checked ==true)
            {
                LoginPanel.ControllID.SmtpString = "smtp.gmail.com";
            }
            else if (WP.Checked == true)
            {
                LoginPanel.ControllID.SmtpString = "smtp.wp.pl";
            }
            else if (Hotmail.Checked == true)
            {
                LoginPanel.ControllID.SmtpString = "smtp.hotmail.com";
            }
            else
            {
                LoginPanel.ControllID.SmtpString = smtpText.Text;
                    
            }
            
            this.Close();
        }

        private void smtpText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(smtpText.Text))
            {
                Gmail.Checked = false;
                WP.Checked = false;
                Hotmail.Checked = false;
            }
        }
    }
}
