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
    public partial class LoginPanel: Form
    {
        
        public OrdersPanel NewOrdersPAnel;
       

        public LoginPanel()
        {
            InitializeComponent();
        }
        public static class ControllID
        {
            public static string IdName { get; set; }
            public static string IdEmail { get; set; }
            public static string Credentials { get; set; }
            public static string Reciver { get; set; }
            public static string SmtpString { get; set; }
        }
       

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            ControllID.IdEmail = EmailText.Text;
           
        }

        private  void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZALOGUJ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameText.Text) || string.IsNullOrEmpty(EmailText.Text) ||!EmailText.Text.Contains('@') || !EmailText.Text.Contains('.'))
            {
                WarningText.ForeColor = Color.Red;
                WarningText.Text = "Nie podales nazwy uzytkownika lub e-mail jest nie poprawny";

            }
            else
            {
                NewOrdersPAnel = new OrdersPanel();

                NewOrdersPAnel.Show();
                this.Hide();
            }

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            ControllID.IdName = NameText.Text;
        }

        private void passText_TextChanged(object sender, EventArgs e)
        {
            passText.PasswordChar = '*';
            passText.MaxLength = 20;
            ControllID.Credentials = passText.Text;
        }
    }
}
