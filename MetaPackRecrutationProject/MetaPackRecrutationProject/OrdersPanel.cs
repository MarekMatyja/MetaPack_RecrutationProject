using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;



namespace MetaPackRecrutationProject
{
   
    public partial class OrdersPanel : Form
    {
        int index = 0;
        int qty = 0;
        ListViewItem iteam,iteamHistory;
        string[] arr;
        string[] arrHistory;
        public int sum;
        public int TotalSum;
        public Notes Uwagi;
        public string sString = "";
       
        public bool meilSent = false;
        Timer timer;
      
        Config LogPanel;


        public OrdersPanel()
        {
            InitializeComponent();

          

        }
       

        private void OrdersPanel_Load(object sender, EventArgs e)
        {
            //passing data from login panel
            ClientName.Text = LoginPanel.ControllID.IdName;
           

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            Date.Text = DateTime.Now.ToShortDateString();
            Time.Text = DateTime.Now.ToString("HH:mm:ss");

            WrongConfText.Visible = false;


            Sum.Enabled = false;

            SummarList.Sorting = SortOrder.Ascending;

            MainList.DataSource = ListData.MaineGroupData;

          



            SummarList.View = View.Details;
            SummarList.FullRowSelect = true;

            arr = new string[3];
            SummarList.Columns.Add("Nazwa Produktu", 270);
            SummarList.Columns.Add("Ilosc", 70);
            SummarList.Columns.Add("Suma", 70);


            //--------historai zamowien konfiguracja
            OrdersHistory.View = View.Details;
            OrdersHistory.FullRowSelect = true;
            OrdersHistory.GridLines = true;

            arrHistory = new string[5];
            OrdersHistory.Columns.Add("Lp.",40);
            OrdersHistory.Columns.Add("Data Zamowienia",100);
            OrdersHistory.Columns.Add("Godzina", 100);
            OrdersHistory.Columns.Add("Laczna Kwota",100);
            
            

            


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("HH:mm:ss");


            if (SummarList.Items.Count > 0)
            {
                SendEmail.Visible = true;
            }
            else
            {
                SendEmail.Visible = false;
            }

            ClientEmail.Text = LoginPanel.ControllID.IdEmail;

           



        }

        private void MainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainList.SelectedIndex)
            {
                case 0:
                    ResetTextBox();
                    List<ProductData> PizzaGroup = new List<ProductData>();
                    PizzaGroup.Add(new ProductData() { ProductName = "Margheritta  20 zl" ,ProductPrice =20});
                    PizzaGroup.Add(new ProductData() { ProductName = "Vegetariana  22 zl ", ProductPrice = 22 });
                    PizzaGroup.Add(new ProductData() { ProductName = "Tosca        25 zl", ProductPrice = 25 });
                    PizzaGroup.Add(new ProductData() { ProductName = "Venecia      25 zl", ProductPrice = 25 });
                    GroupList.DataSource = null;
                    GroupList.DataSource = PizzaGroup;
                    GroupList.DisplayMember = "ProductName";
                    GroupList.ValueMember = "ProductPrice"; 
                    break;
                case 1:
                    ResetTextBox();
                    List<ProductData> PizzaAddons = new List<ProductData>();
                    PizzaAddons.Add(new ProductData() { ProductName = "Podwojny Ser  2 zl", ProductPrice = 2 });
                    PizzaAddons.Add(new ProductData() { ProductName = "Salami        2 zl", ProductPrice = 2 });
                    PizzaAddons.Add(new ProductData() { ProductName = "Szynka        2 zl", ProductPrice = 2 });
                    PizzaAddons.Add(new ProductData() { ProductName = "Pieczarki     2 zl", ProductPrice = 2 });
                    GroupList.DataSource = null;
                    GroupList.DataSource = PizzaAddons;
                    GroupList.DisplayMember = "ProductName";
                    GroupList.ValueMember = "ProductPrice";
                    break;
                case 2:
                    ResetTextBox();
                    List<ProductData> MaineMeal = new List<ProductData>();
                    MaineMeal.Add(new ProductData() { ProductName = "Schabowy z frytkami/ryżem/ziemniakami  30 zl", ProductPrice = 30 });
                    MaineMeal.Add(new ProductData() { ProductName = "Ryba z frytkami                        28 zl ", ProductPrice = 28 });
                    MaineMeal.Add(new ProductData() { ProductName = "Placek po węgiersku                    27 zl ", ProductPrice = 27 });
                    GroupList.DataSource = null;
                    GroupList.DataSource = MaineMeal;
                    GroupList.DisplayMember = "ProductName";
                    GroupList.ValueMember = "ProductPrice";
                    break;
                case 3:
                    ResetTextBox();
                    List<ProductData> MaineMealAddons = new List<ProductData>();
                    MaineMealAddons.Add(new ProductData() { ProductName = "Bar sałatkowy  5 zl", ProductPrice = 5 });
                    MaineMealAddons.Add(new ProductData() { ProductName = "Zestaw sosów   6 zl", ProductPrice = 6 });
                    GroupList.DataSource = null;
                    GroupList.DataSource = MaineMealAddons;
                    GroupList.DisplayMember = "ProductName";
                    GroupList.ValueMember = "ProductPrice";
                    break;
                case 4:
                    ResetTextBox();
                    List<ProductData> Soups = new List<ProductData>();
                    Soups.Add(new ProductData() { ProductName = "Pomidorowa   12 zl", ProductPrice = 12 });
                    Soups.Add(new ProductData() { ProductName = "Rosół        10 zl ", ProductPrice = 10 });
                    GroupList.DataSource = null;
                    GroupList.DataSource = Soups;
                    GroupList.DisplayMember = "ProductName";
                    GroupList.ValueMember = "ProductPrice";
                    break;
                case 5:
                    ResetTextBox();
                    List<ProductData> SoftDrinks = new List<ProductData>();
                    SoftDrinks.Add(new ProductData() { ProductName = "Kawa      5 zl", ProductPrice = 5 });
                    SoftDrinks.Add(new ProductData() { ProductName = "Herbata   5 zl ", ProductPrice = 5 });
                    SoftDrinks.Add(new ProductData() { ProductName = "Cola      5 zl ", ProductPrice = 5 });
                    GroupList.DataSource = null;
                    GroupList.DataSource = SoftDrinks;
                    GroupList.DisplayMember = "ProductName";
                    GroupList.ValueMember = "ProductPrice";
                    break;
            }


        }

        private void Positive_Click(object sender, EventArgs e)
        {
           
            qty += 1;
            QTY.Text = qty.ToString();
        }

        private void negative_Click(object sender, EventArgs e)
        {
           
          
            if (qty >0)
            {
                qty -= 1;
            }
            else
            {
                return;
            }
            QTY.Text = qty.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(QTY.Text,"0-9"))
            {
                QTY.Text = QTY.Text.Remove(QTY.Text.Length - 1);
            }
            QTY.Text = qty.ToString();
        }

        private void SummarList_SelectedIndexChanged(object sender, EventArgs e)
        {

          




        }

        private void Add_Click(object sender, EventArgs e)
        {

           

            sum = (int)GroupList.SelectedValue * qty;
            string product = GroupList.SelectedItem.ToString();
            string toremove = GroupList.SelectedValue.ToString()+"zl";
            int c = product.IndexOf(toremove);

            arr[0] = product.Remove(c, toremove.Length);
            arr[1] = QTY.Text;
            arr[2] = sum.ToString()+ ".00 zl" ;
          
            if (qty >0)
            {
              
                iteam = new ListViewItem(arr);
                SummarList.Items.Add(iteam);

            }
            else
            {
                return;
            }

            TotalSum  = sum +TotalSum;
            Sum.Text = TotalSum.ToString() + ".00 zl";
            ResetTextBox();
          

        }
        void ResetTextBox()
        {
            qty = 0;
            QTY.Text = qty.ToString();
        }




        protected void SendEmail_Click(object sender, EventArgs e)
        {
            //---------------------------------Port 587/20 for mail // wstepny kod
            string SummaryBoxIteams = "";
            for (int i = 0; i < SummarList.Items.Count; i++)
            {
                SummaryBoxIteams += SummarList.Items[i].Text + " x " + SummarList.Items[i].SubItems[1].Text + " = " + SummarList.Items[i].SubItems[2].Text + "\n";
            }

            try
            {
                SmtpClient MeilClient = new SmtpClient();
                MeilClient.Host = LoginPanel.ControllID.SmtpString;
                MeilClient.Port = 587;
                MeilClient.EnableSsl = true;
                MeilClient.Credentials = new NetworkCredential(LoginPanel.ControllID.IdEmail, LoginPanel.ControllID.Credentials);

                MailMessage message = new MailMessage();
                message.From = new MailAddress(LoginPanel.ControllID.IdEmail);
                message.To.Add(LoginPanel.ControllID.Reciver);
                message.Subject = "Zamowienie";
                message.Body =  "Data : " + Date.Text + "\n" +
                                "Godzina: " + Time.Text + "\n" + 
                                "Zamowienie: " + "\n" +
                                 SummaryBoxIteams +
                                "Uwagi do Zamowienia:  " + Notes.SavedData.SavedText + "\n" +
                                "Laczna Kwota: " + Sum.Text;

                MeilClient.Send(message);
                arrHistory[0] = index.ToString();
                arrHistory[1] = Date.Text;
                arrHistory[2] = Time.Text;
                arrHistory[3] = TotalSum.ToString()+ ".00 zl";
                arrHistory[4] = SummaryBoxIteams;
                iteamHistory = new ListViewItem(arrHistory);
                OrdersHistory.Items.Add(iteamHistory);
                foreach (ListViewItem item in SummarList.Items)
                {
                    item.Remove();
                }
                TotalSum = 0;
                message.Dispose();
                WrongConfText.Visible = false;
                Notes.SavedData.SavedText = null;
            }
            catch
            {
                WrongConfText.Visible = true;
                WrongConfText.ForeColor = Color.Red;
                WrongConfText.Text = "Skonfiguruj poprawnie swoje dane poprawnie oraz podaj Email odbiorcy";
            }
            index++;
           

           


        }
        private void SendEmail_Completed(object sender , EventArgs e)
        {
            SummarList.Clear();
            SendEmail.Visible = true;
        }

        private void Usun_Click_1(object sender, EventArgs e)
        {
         

            for (int i = 0; i < SummarList.Items.Count; i++)
            {
                if (SummarList.Items[i].Selected)
                {
                    string exten = SummarList.Items[i].SubItems[2].Text;
                    string toremove = ".00 zl";
                    int c = exten.IndexOf(toremove);
                    TotalSum = TotalSum - int.Parse(exten.Remove(c, toremove.Length));
                    Sum.Text = TotalSum.ToString();
                    SummarList.Items[i].Remove();
                }

            }
        }

        private void AddNotes_Click(object sender, EventArgs e)
        {
            if (Uwagi== null)
            {

                Uwagi = new Notes(Notes.SavedData.SavedText);
                Uwagi.FormClosing += new FormClosingEventHandler(Uwagi_FormClosing);
            }
          
                Uwagi.Show();
                     
        }
        private void Uwagi_FormClosing(object sender, EventArgs e)
        {
            Uwagi = null;
        }

        private void EmailConfig_Click(object sender, EventArgs e)
        {
            WrongConfText.Text = "";
            if (LogPanel == null)
            {
                LogPanel = new Config();
                LogPanel.FormClosing += new FormClosingEventHandler(LogPanel_FormClosing);
            }
            LogPanel.Show();
        }

        private void OrdersHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < OrdersHistory.Items.Count; i++)
            {
                if (OrdersHistory.Items[i].Selected)
                {
                    HistoryDetails.Text = OrdersHistory.Items[i].SubItems[4].Text;
                }

            }
        }

        private void LogPanel_FormClosing(object sender, EventArgs e)
        {
            LogPanel = null;
        }

       
    }
  
}
