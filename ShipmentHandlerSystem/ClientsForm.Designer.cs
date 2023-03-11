namespace ShipmentHandlerSystem
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.DataGridViewClient = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CustomerIDBox = new System.Windows.Forms.TextBox();
            this.CustomerNameBox = new System.Windows.Forms.TextBox();
            this.CustomerTelephoneBox = new System.Windows.Forms.TextBox();
            this.CustomerSurnameBox = new System.Windows.Forms.TextBox();
            this.CustomerCountryBox = new System.Windows.Forms.TextBox();
            this.AdressInformationBox = new System.Windows.Forms.TextBox();
            this.CustomerEmailBox = new System.Windows.Forms.TextBox();
            this.PostalCodeBox = new System.Windows.Forms.TextBox();
            this.CustomerStateBox = new System.Windows.Forms.TextBox();
            this.CustomerCityBox = new System.Windows.Forms.TextBox();
            this.AdditionalInformationBox = new System.Windows.Forms.TextBox();
            this.UpdateClient = new System.Windows.Forms.Button();
            this.AddClient = new System.Windows.Forms.Button();
            this.RemoveClient = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userControl14 = new ShipmentHandlerSystem.UserControl1();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl14)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewClient
            // 
            this.DataGridViewClient.AllowUserToAddRows = false;
            this.DataGridViewClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewClient.ColumnHeadersHeight = 30;
            this.DataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewClient.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewClient.Location = new System.Drawing.Point(12, 82);
            this.DataGridViewClient.Name = "DataGridViewClient";
            this.DataGridViewClient.Size = new System.Drawing.Size(589, 379);
            this.DataGridViewClient.TabIndex = 59;
            this.DataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClient_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ClientID ",
            "Client_Name",
            "Client_Surname",
            "Telephone ",
            "Email ",
            "Adress_Information ",
            "Country ",
            "City_Town ",
            "State_Province_Country ",
            "Postal_Code ",
            "Additional_Information "});
            this.comboBox1.Location = new System.Drawing.Point(320, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 107;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(170, 53);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(256, 23);
            this.Search.TabIndex = 106;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(12, 28);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(96, 48);
            this.Refresh.TabIndex = 105;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 104;
            // 
            // CustomerIDBox
            // 
            this.CustomerIDBox.Location = new System.Drawing.Point(648, 118);
            this.CustomerIDBox.Name = "CustomerIDBox";
            this.CustomerIDBox.Size = new System.Drawing.Size(109, 20);
            this.CustomerIDBox.TabIndex = 108;
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.Location = new System.Drawing.Point(648, 157);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(109, 20);
            this.CustomerNameBox.TabIndex = 109;
            // 
            // CustomerTelephoneBox
            // 
            this.CustomerTelephoneBox.Location = new System.Drawing.Point(836, 118);
            this.CustomerTelephoneBox.Name = "CustomerTelephoneBox";
            this.CustomerTelephoneBox.Size = new System.Drawing.Size(103, 20);
            this.CustomerTelephoneBox.TabIndex = 111;
            // 
            // CustomerSurnameBox
            // 
            this.CustomerSurnameBox.Location = new System.Drawing.Point(836, 157);
            this.CustomerSurnameBox.Name = "CustomerSurnameBox";
            this.CustomerSurnameBox.Size = new System.Drawing.Size(103, 20);
            this.CustomerSurnameBox.TabIndex = 110;
            // 
            // CustomerCountryBox
            // 
            this.CustomerCountryBox.Location = new System.Drawing.Point(836, 194);
            this.CustomerCountryBox.Name = "CustomerCountryBox";
            this.CustomerCountryBox.Size = new System.Drawing.Size(103, 20);
            this.CustomerCountryBox.TabIndex = 115;
            // 
            // AdressInformationBox
            // 
            this.AdressInformationBox.Location = new System.Drawing.Point(726, 235);
            this.AdressInformationBox.Name = "AdressInformationBox";
            this.AdressInformationBox.Size = new System.Drawing.Size(213, 20);
            this.AdressInformationBox.TabIndex = 114;
            // 
            // CustomerEmailBox
            // 
            this.CustomerEmailBox.Location = new System.Drawing.Point(648, 194);
            this.CustomerEmailBox.Name = "CustomerEmailBox";
            this.CustomerEmailBox.Size = new System.Drawing.Size(109, 20);
            this.CustomerEmailBox.TabIndex = 112;
            // 
            // PostalCodeBox
            // 
            this.PostalCodeBox.Location = new System.Drawing.Point(836, 278);
            this.PostalCodeBox.Name = "PostalCodeBox";
            this.PostalCodeBox.Size = new System.Drawing.Size(103, 20);
            this.PostalCodeBox.TabIndex = 118;
            // 
            // CustomerStateBox
            // 
            this.CustomerStateBox.Location = new System.Drawing.Point(836, 314);
            this.CustomerStateBox.Name = "CustomerStateBox";
            this.CustomerStateBox.Size = new System.Drawing.Size(103, 20);
            this.CustomerStateBox.TabIndex = 117;
            // 
            // CustomerCityBox
            // 
            this.CustomerCityBox.Location = new System.Drawing.Point(648, 278);
            this.CustomerCityBox.Name = "CustomerCityBox";
            this.CustomerCityBox.Size = new System.Drawing.Size(109, 20);
            this.CustomerCityBox.TabIndex = 116;
            // 
            // AdditionalInformationBox
            // 
            this.AdditionalInformationBox.Location = new System.Drawing.Point(726, 349);
            this.AdditionalInformationBox.Name = "AdditionalInformationBox";
            this.AdditionalInformationBox.Size = new System.Drawing.Size(219, 20);
            this.AdditionalInformationBox.TabIndex = 119;
            // 
            // UpdateClient
            // 
            this.UpdateClient.Location = new System.Drawing.Point(729, 417);
            this.UpdateClient.Name = "UpdateClient";
            this.UpdateClient.Size = new System.Drawing.Size(95, 41);
            this.UpdateClient.TabIndex = 122;
            this.UpdateClient.Text = "Update ";
            this.UpdateClient.UseVisualStyleBackColor = true;
            this.UpdateClient.Click += new System.EventHandler(this.UpdateClient_Click);
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(612, 417);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(88, 41);
            this.AddClient.TabIndex = 121;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // RemoveClient
            // 
            this.RemoveClient.Location = new System.Drawing.Point(847, 417);
            this.RemoveClient.Name = "RemoveClient";
            this.RemoveClient.Size = new System.Drawing.Size(92, 41);
            this.RemoveClient.TabIndex = 120;
            this.RemoveClient.Text = "Remove Client";
            this.RemoveClient.UseVisualStyleBackColor = true;
            this.RemoveClient.Click += new System.EventHandler(this.RemoveClient_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(624, 121);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 123;
            this.ID.Text = "ID";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Location = new System.Drawing.Point(772, 121);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(58, 13);
            this.Telephone.TabIndex = 124;
            this.Telephone.Text = "Telephone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(781, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 127;
            this.label3.Text = "Email";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(787, 197);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(43, 13);
            this.Country.TabIndex = 128;
            this.Country.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 129;
            this.label4.Text = "Adress Information";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(612, 281);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(24, 13);
            this.City.TabIndex = 130;
            this.City.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 131;
            this.label5.Text = "Postal Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 132;
            this.label6.Text = "Additional Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(767, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 133;
            this.label7.Text = "State/District";
            // 
            // userControl14
            // 
            this.userControl14.HoverImg = null;
            this.userControl14.Image = ((System.Drawing.Image)(resources.GetObject("userControl14.Image")));
            this.userControl14.Location = new System.Drawing.Point(708, 12);
            this.userControl14.Name = "userControl14";
            this.userControl14.NormalImg = null;
            this.userControl14.Size = new System.Drawing.Size(163, 73);
            this.userControl14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userControl14.TabIndex = 134;
            this.userControl14.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(758, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 135;
            this.label13.Text = "Clients";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(951, 470);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.userControl14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.UpdateClient);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.RemoveClient);
            this.Controls.Add(this.AdditionalInformationBox);
            this.Controls.Add(this.PostalCodeBox);
            this.Controls.Add(this.CustomerStateBox);
            this.Controls.Add(this.CustomerCityBox);
            this.Controls.Add(this.CustomerCountryBox);
            this.Controls.Add(this.AdressInformationBox);
            this.Controls.Add(this.CustomerEmailBox);
            this.Controls.Add(this.CustomerTelephoneBox);
            this.Controls.Add(this.CustomerSurnameBox);
            this.Controls.Add(this.CustomerNameBox);
            this.Controls.Add(this.CustomerIDBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGridViewClient);
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewClient;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox CustomerIDBox;
        private System.Windows.Forms.TextBox CustomerNameBox;
        private System.Windows.Forms.TextBox CustomerTelephoneBox;
        private System.Windows.Forms.TextBox CustomerSurnameBox;
        private System.Windows.Forms.TextBox CustomerCountryBox;
        private System.Windows.Forms.TextBox AdressInformationBox;
        private System.Windows.Forms.TextBox CustomerEmailBox;
        private System.Windows.Forms.TextBox PostalCodeBox;
        private System.Windows.Forms.TextBox CustomerStateBox;
        private System.Windows.Forms.TextBox CustomerCityBox;
        private System.Windows.Forms.TextBox AdditionalInformationBox;
        private System.Windows.Forms.Button UpdateClient;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button RemoveClient;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private UserControl1 userControl14;
        private System.Windows.Forms.Label label13;
    }
}