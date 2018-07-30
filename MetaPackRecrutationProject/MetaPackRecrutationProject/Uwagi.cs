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
    public partial class Notes : Form
    {

        public static Notes instance;

       public static class SavedData
        {
            public static string SavedText { get; set; }
        }
       

        public Notes(string txt)
        {
           
            instance = this;

            InitializeComponent();
            textBox1.Text = txt;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            SavedData.SavedText = textBox1.Text;
        }

        private void Save_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

       


        private void Notes_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
