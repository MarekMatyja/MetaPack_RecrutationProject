namespace MetaPackRecrutationProject
{
    partial class OrdersPanel
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
            this.ComapanyName = new System.Windows.Forms.Label();
            this.ClientText = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.ClientDataText = new System.Windows.Forms.Label();
            this.ClientEmail = new System.Windows.Forms.Label();
            this.MainList = new System.Windows.Forms.ListBox();
            this.SummarList = new System.Windows.Forms.ListView();
            this.negative = new System.Windows.Forms.Button();
            this.Positive = new System.Windows.Forms.Button();
            this.QTY = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.GroupList = new System.Windows.Forms.ListBox();
            this.Sum = new System.Windows.Forms.TextBox();
            this.FinalSum = new System.Windows.Forms.Label();
            this.ZL = new System.Windows.Forms.Label();
            this.SendEmail = new System.Windows.Forms.Button();
            this.Usun = new System.Windows.Forms.Button();
            this.AddNotes = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.WrongConfText = new System.Windows.Forms.Label();
            this.EmailConfig = new System.Windows.Forms.Button();
            this.OrdersHistory = new System.Windows.Forms.ListView();
            this.OH_Text = new System.Windows.Forms.Label();
            this.HistoryDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComapanyName
            // 
            this.ComapanyName.AutoSize = true;
            this.ComapanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComapanyName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComapanyName.Location = new System.Drawing.Point(250, 10);
            this.ComapanyName.Name = "ComapanyName";
            this.ComapanyName.Size = new System.Drawing.Size(242, 31);
            this.ComapanyName.TabIndex = 0;
            this.ComapanyName.Text = "Restauracja Marka";
            // 
            // ClientText
            // 
            this.ClientText.AutoSize = true;
            this.ClientText.Location = new System.Drawing.Point(12, 46);
            this.ClientText.Name = "ClientText";
            this.ClientText.Size = new System.Drawing.Size(65, 13);
            this.ClientText.TabIndex = 1;
            this.ClientText.Text = "Uzytkownik:";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(84, 45);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(0, 13);
            this.ClientName.TabIndex = 2;
            // 
            // ClientDataText
            // 
            this.ClientDataText.AutoSize = true;
            this.ClientDataText.Location = new System.Drawing.Point(12, 59);
            this.ClientDataText.Name = "ClientDataText";
            this.ClientDataText.Size = new System.Drawing.Size(100, 13);
            this.ClientDataText.TabIndex = 4;
            this.ClientDataText.Text = "Dane Uzytkownika:";
            // 
            // ClientEmail
            // 
            this.ClientEmail.AutoSize = true;
            this.ClientEmail.Location = new System.Drawing.Point(118, 59);
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.Size = new System.Drawing.Size(0, 13);
            this.ClientEmail.TabIndex = 5;
            // 
            // MainList
            // 
            this.MainList.FormattingEnabled = true;
            this.MainList.Location = new System.Drawing.Point(15, 79);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(150, 290);
            this.MainList.TabIndex = 6;
            this.MainList.SelectedIndexChanged += new System.EventHandler(this.MainList_SelectedIndexChanged);
            // 
            // SummarList
            // 
            this.SummarList.Location = new System.Drawing.Point(622, 79);
            this.SummarList.Name = "SummarList";
            this.SummarList.Size = new System.Drawing.Size(480, 290);
            this.SummarList.TabIndex = 8;
            this.SummarList.UseCompatibleStateImageBehavior = false;
            this.SummarList.SelectedIndexChanged += new System.EventHandler(this.SummarList_SelectedIndexChanged);
            this.SummarList.DoubleClick += new System.EventHandler(this.Usun_Click_1);
            // 
            // negative
            // 
            this.negative.Location = new System.Drawing.Point(482, 141);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(20, 20);
            this.negative.TabIndex = 9;
            this.negative.Text = "-";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // Positive
            // 
            this.Positive.Location = new System.Drawing.Point(540, 142);
            this.Positive.Name = "Positive";
            this.Positive.Size = new System.Drawing.Size(20, 20);
            this.Positive.TabIndex = 10;
            this.Positive.Text = "+";
            this.Positive.UseVisualStyleBackColor = true;
            this.Positive.Click += new System.EventHandler(this.Positive_Click);
            // 
            // QTY
            // 
            this.QTY.Location = new System.Drawing.Point(508, 142);
            this.QTY.Name = "QTY";
            this.QTY.Size = new System.Drawing.Size(26, 20);
            this.QTY.TabIndex = 11;
            this.QTY.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(482, 168);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(80, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Dodaj";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // GroupList
            // 
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(171, 79);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(270, 290);
            this.GroupList.TabIndex = 13;
            this.GroupList.DoubleClick += new System.EventHandler(this.Add_Click);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(988, 375);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(65, 20);
            this.Sum.TabIndex = 14;
            // 
            // FinalSum
            // 
            this.FinalSum.AutoSize = true;
            this.FinalSum.Location = new System.Drawing.Point(901, 378);
            this.FinalSum.Name = "FinalSum";
            this.FinalSum.Size = new System.Drawing.Size(81, 13);
            this.FinalSum.TabIndex = 15;
            this.FinalSum.Text = "Calkowita Cena";
            // 
            // ZL
            // 
            this.ZL.AutoSize = true;
            this.ZL.Location = new System.Drawing.Point(1059, 378);
            this.ZL.Name = "ZL";
            this.ZL.Size = new System.Drawing.Size(20, 13);
            this.ZL.TabIndex = 16;
            this.ZL.Text = "ZL";
            // 
            // SendEmail
            // 
            this.SendEmail.Location = new System.Drawing.Point(904, 420);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(159, 29);
            this.SendEmail.TabIndex = 17;
            this.SendEmail.Text = "Zloz Zamowienie";
            this.SendEmail.UseVisualStyleBackColor = true;
            this.SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // Usun
            // 
            this.Usun.Location = new System.Drawing.Point(622, 372);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(99, 23);
            this.Usun.TabIndex = 18;
            this.Usun.Text = "Usun z Listy";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click_1);
            // 
            // AddNotes
            // 
            this.AddNotes.Location = new System.Drawing.Point(622, 420);
            this.AddNotes.Name = "AddNotes";
            this.AddNotes.Size = new System.Drawing.Size(160, 30);
            this.AddNotes.TabIndex = 19;
            this.AddNotes.Text = "Uwagi do Zamowienia";
            this.AddNotes.UseVisualStyleBackColor = true;
            this.AddNotes.Click += new System.EventHandler(this.AddNotes_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(1023, 45);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(35, 13);
            this.Date.TabIndex = 21;
            this.Date.Text = "label1";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(1023, 58);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(35, 13);
            this.Time.TabIndex = 22;
            this.Time.Text = "label1";
            // 
            // WrongConfText
            // 
            this.WrongConfText.AutoSize = true;
            this.WrongConfText.Location = new System.Drawing.Point(822, 404);
            this.WrongConfText.Name = "WrongConfText";
            this.WrongConfText.Size = new System.Drawing.Size(35, 13);
            this.WrongConfText.TabIndex = 23;
            this.WrongConfText.Text = "label1";
            // 
            // EmailConfig
            // 
            this.EmailConfig.Location = new System.Drawing.Point(1069, 420);
            this.EmailConfig.Name = "EmailConfig";
            this.EmailConfig.Size = new System.Drawing.Size(75, 23);
            this.EmailConfig.TabIndex = 20;
            this.EmailConfig.Text = "Konfiguracja";
            this.EmailConfig.UseVisualStyleBackColor = true;
            this.EmailConfig.Click += new System.EventHandler(this.EmailConfig_Click);
            // 
            // OrdersHistory
            // 
            this.OrdersHistory.Location = new System.Drawing.Point(15, 420);
            this.OrdersHistory.Name = "OrdersHistory";
            this.OrdersHistory.Size = new System.Drawing.Size(330, 229);
            this.OrdersHistory.TabIndex = 24;
            this.OrdersHistory.UseCompatibleStateImageBehavior = false;
            this.OrdersHistory.SelectedIndexChanged += new System.EventHandler(this.OrdersHistory_SelectedIndexChanged);
            // 
            // OH_Text
            // 
            this.OH_Text.AutoSize = true;
            this.OH_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OH_Text.Location = new System.Drawing.Point(116, 392);
            this.OH_Text.Name = "OH_Text";
            this.OH_Text.Size = new System.Drawing.Size(172, 25);
            this.OH_Text.TabIndex = 25;
            this.OH_Text.Text = "Historia Zamowien";
            // 
            // HistoryDetails
            // 
            this.HistoryDetails.Location = new System.Drawing.Point(351, 420);
            this.HistoryDetails.Multiline = true;
            this.HistoryDetails.Name = "HistoryDetails";
            this.HistoryDetails.Size = new System.Drawing.Size(211, 229);
            this.HistoryDetails.TabIndex = 26;
            // 
            // OrdersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.HistoryDetails);
            this.Controls.Add(this.OH_Text);
            this.Controls.Add(this.OrdersHistory);
            this.Controls.Add(this.WrongConfText);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.EmailConfig);
            this.Controls.Add(this.AddNotes);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.SendEmail);
            this.Controls.Add(this.ZL);
            this.Controls.Add(this.FinalSum);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.QTY);
            this.Controls.Add(this.Positive);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.SummarList);
            this.Controls.Add(this.MainList);
            this.Controls.Add(this.ClientEmail);
            this.Controls.Add(this.ClientDataText);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ClientText);
            this.Controls.Add(this.ComapanyName);
            this.Name = "OrdersPanel";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrdersPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComapanyName;
        private System.Windows.Forms.Label ClientText;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label ClientDataText;
        private System.Windows.Forms.Label ClientEmail;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.ListView SummarList;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button Positive;
        private System.Windows.Forms.TextBox QTY;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox GroupList;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Label FinalSum;
        private System.Windows.Forms.Label ZL;
        private System.Windows.Forms.Button SendEmail;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.Button AddNotes;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label WrongConfText;
        private System.Windows.Forms.Button EmailConfig;
        private System.Windows.Forms.ListView OrdersHistory;
        private System.Windows.Forms.Label OH_Text;
        private System.Windows.Forms.TextBox HistoryDetails;
    }
}