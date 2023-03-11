namespace ShipmentHandlerSystem
{
    partial class ShipmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentsForm));
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShipmentDescription = new System.Windows.Forms.TextBox();
            this.UpdateClient = new System.Windows.Forms.Button();
            this.AddShipment = new System.Windows.Forms.Button();
            this.DeliveryTypeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ShipmentIDBox = new System.Windows.Forms.TextBox();
            this.RemoveShipment = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DataGridViewShipment = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Item1IDBox = new System.Windows.Forms.TextBox();
            this.Item2IDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Item3IDBox = new System.Windows.Forms.TextBox();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PickupID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ShipmentList = new System.Windows.Forms.Button();
            this.userControl11 = new ShipmentHandlerSystem.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 48);
            this.button3.TabIndex = 84;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(751, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Delivery Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Shipment Description";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ShipmentDescription
            // 
            this.ShipmentDescription.Location = new System.Drawing.Point(714, 183);
            this.ShipmentDescription.Name = "ShipmentDescription";
            this.ShipmentDescription.Size = new System.Drawing.Size(238, 20);
            this.ShipmentDescription.TabIndex = 76;
            this.ShipmentDescription.TextChanged += new System.EventHandler(this.ShipmentDescription_TextChanged);
            // 
            // UpdateClient
            // 
            this.UpdateClient.Location = new System.Drawing.Point(725, 370);
            this.UpdateClient.Name = "UpdateClient";
            this.UpdateClient.Size = new System.Drawing.Size(95, 41);
            this.UpdateClient.TabIndex = 72;
            this.UpdateClient.Text = "Update ";
            this.UpdateClient.UseVisualStyleBackColor = true;
            this.UpdateClient.Click += new System.EventHandler(this.UpdateClient_Click);
            // 
            // AddShipment
            // 
            this.AddShipment.Location = new System.Drawing.Point(608, 370);
            this.AddShipment.Name = "AddShipment";
            this.AddShipment.Size = new System.Drawing.Size(88, 41);
            this.AddShipment.TabIndex = 71;
            this.AddShipment.Text = "Add Shipment";
            this.AddShipment.UseVisualStyleBackColor = true;
            this.AddShipment.Click += new System.EventHandler(this.AddShipment_Click);
            // 
            // DeliveryTypeBox
            // 
            this.DeliveryTypeBox.Location = new System.Drawing.Point(829, 130);
            this.DeliveryTypeBox.Name = "DeliveryTypeBox";
            this.DeliveryTypeBox.Size = new System.Drawing.Size(122, 20);
            this.DeliveryTypeBox.TabIndex = 64;
            this.DeliveryTypeBox.TextChanged += new System.EventHandler(this.DeliveryTypeBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ShipmentIDBox
            // 
            this.ShipmentIDBox.Location = new System.Drawing.Point(625, 129);
            this.ShipmentIDBox.Name = "ShipmentIDBox";
            this.ShipmentIDBox.Size = new System.Drawing.Size(113, 20);
            this.ShipmentIDBox.TabIndex = 62;
            this.ShipmentIDBox.TextChanged += new System.EventHandler(this.ShipmentIDBox_TextChanged);
            // 
            // RemoveShipment
            // 
            this.RemoveShipment.Location = new System.Drawing.Point(843, 370);
            this.RemoveShipment.Name = "RemoveShipment";
            this.RemoveShipment.Size = new System.Drawing.Size(92, 41);
            this.RemoveShipment.TabIndex = 61;
            this.RemoveShipment.Text = "Remove Shipment";
            this.RemoveShipment.UseVisualStyleBackColor = true;
            this.RemoveShipment.Click += new System.EventHandler(this.RemoveShipment_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 60;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DataGridViewShipment
            // 
            this.DataGridViewShipment.AllowUserToAddRows = false;
            this.DataGridViewShipment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewShipment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewShipment.ColumnHeadersHeight = 30;
            this.DataGridViewShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewShipment.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewShipment.Location = new System.Drawing.Point(12, 75);
            this.DataGridViewShipment.Name = "DataGridViewShipment";
            this.DataGridViewShipment.Size = new System.Drawing.Size(569, 336);
            this.DataGridViewShipment.TabIndex = 58;
            this.DataGridViewShipment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewShipment_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(737, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 89;
            this.label13.Text = "Shipments";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Shipment Weight";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(714, 224);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(79, 20);
            this.WeightBox.TabIndex = 91;
            this.WeightBox.TextChanged += new System.EventHandler(this.WeightBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Item 1 ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Item1IDBox
            // 
            this.Item1IDBox.Location = new System.Drawing.Point(714, 254);
            this.Item1IDBox.Name = "Item1IDBox";
            this.Item1IDBox.Size = new System.Drawing.Size(79, 20);
            this.Item1IDBox.TabIndex = 93;
            this.Item1IDBox.TextChanged += new System.EventHandler(this.Item1IDBox_TextChanged);
            // 
            // Item2IDBox
            // 
            this.Item2IDBox.Location = new System.Drawing.Point(714, 283);
            this.Item2IDBox.Name = "Item2IDBox";
            this.Item2IDBox.Size = new System.Drawing.Size(79, 20);
            this.Item2IDBox.TabIndex = 94;
            this.Item2IDBox.TextChanged += new System.EventHandler(this.Item2IDBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Item 2 ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Item 3 ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Item3IDBox
            // 
            this.Item3IDBox.Location = new System.Drawing.Point(714, 313);
            this.Item3IDBox.Name = "Item3IDBox";
            this.Item3IDBox.Size = new System.Drawing.Size(79, 20);
            this.Item3IDBox.TabIndex = 97;
            this.Item3IDBox.TextChanged += new System.EventHandler(this.Item3IDBox_TextChanged);
            // 
            // ClientID
            // 
            this.ClientID.Location = new System.Drawing.Point(873, 223);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(79, 20);
            this.ClientID.TabIndex = 98;
            this.ClientID.TextChanged += new System.EventHandler(this.ClientID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(820, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Client ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PickupID
            // 
            this.PickupID.Location = new System.Drawing.Point(872, 258);
            this.PickupID.Name = "PickupID";
            this.PickupID.Size = new System.Drawing.Size(79, 20);
            this.PickupID.TabIndex = 100;
            this.PickupID.TextChanged += new System.EventHandler(this.PickupID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(813, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "Pickup ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(170, 46);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(256, 23);
            this.Search.TabIndex = 102;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ShipmentID ",
            "Delivery_Type ",
            "Shipment_Description ",
            "Shipment_Weight\t",
            "Item1 ",
            "Item2 ",
            "Item3 ",
            "Client ",
            "Pickup "});
            this.comboBox1.Location = new System.Drawing.Point(320, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 103;
            // 
            // ShipmentList
            // 
            this.ShipmentList.Location = new System.Drawing.Point(485, 21);
            this.ShipmentList.Name = "ShipmentList";
            this.ShipmentList.Size = new System.Drawing.Size(96, 48);
            this.ShipmentList.TabIndex = 104;
            this.ShipmentList.Text = "Show Shipment Lists";
            this.ShipmentList.UseVisualStyleBackColor = true;
            this.ShipmentList.Click += new System.EventHandler(this.ShipmentList_Click);
            // 
            // userControl11
            // 
            this.userControl11.HoverImg = ((System.Drawing.Image)(resources.GetObject("userControl11.HoverImg")));
            this.userControl11.Image = ((System.Drawing.Image)(resources.GetObject("userControl11.Image")));
            this.userControl11.Location = new System.Drawing.Point(707, 6);
            this.userControl11.Name = "userControl11";
            this.userControl11.NormalImg = null;
            this.userControl11.Size = new System.Drawing.Size(139, 80);
            this.userControl11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userControl11.TabIndex = 85;
            this.userControl11.TabStop = false;
            this.userControl11.Click += new System.EventHandler(this.userControl11_Click);
            // 
            // ShipmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(964, 429);
            this.Controls.Add(this.ShipmentList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PickupID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ClientID);
            this.Controls.Add(this.Item3IDBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Item2IDBox);
            this.Controls.Add(this.Item1IDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ShipmentDescription);
            this.Controls.Add(this.UpdateClient);
            this.Controls.Add(this.AddShipment);
            this.Controls.Add(this.DeliveryTypeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShipmentIDBox);
            this.Controls.Add(this.RemoveShipment);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGridViewShipment);
            this.Name = "ShipmentsForm";
            this.Text = "ShipmentsForm";
            this.Load += new System.EventHandler(this.ShipmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControl1 userControl11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ShipmentDescription;
        private System.Windows.Forms.Button UpdateClient;
        private System.Windows.Forms.Button AddShipment;
        private System.Windows.Forms.TextBox DeliveryTypeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ShipmentIDBox;
        private System.Windows.Forms.Button RemoveShipment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DataGridViewShipment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Item1IDBox;
        private System.Windows.Forms.TextBox Item2IDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Item3IDBox;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PickupID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ShipmentList;
    }
}