namespace ShipmentHandlerSystem
{
    partial class PickupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickupForm));
            this.Search = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.UpdatePickup = new System.Windows.Forms.Button();
            this.AddPickup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PickupLicenseBox = new System.Windows.Forms.TextBox();
            this.RemovePickup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DriverIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DriverNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DriverSurnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentLocationBox = new System.Windows.Forms.TextBox();
            this.ShipmentListBox = new System.Windows.Forms.TextBox();
            this.CurrentShipmentBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridViewPickups = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.LiveLocationButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.userControl11 = new ShipmentHandlerSystem.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPickups)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(156, 56);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(268, 23);
            this.Search.TabIndex = 129;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(733, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 116;
            this.label13.Text = "Pickups";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 41);
            this.button3.TabIndex = 114;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdatePickup
            // 
            this.UpdatePickup.Location = new System.Drawing.Point(257, 474);
            this.UpdatePickup.Name = "UpdatePickup";
            this.UpdatePickup.Size = new System.Drawing.Size(95, 41);
            this.UpdatePickup.TabIndex = 110;
            this.UpdatePickup.Text = "Update ";
            this.UpdatePickup.UseVisualStyleBackColor = true;
            this.UpdatePickup.Click += new System.EventHandler(this.UpdatePickup_Click);
            // 
            // AddPickup
            // 
            this.AddPickup.Location = new System.Drawing.Point(156, 474);
            this.AddPickup.Name = "AddPickup";
            this.AddPickup.Size = new System.Drawing.Size(95, 41);
            this.AddPickup.TabIndex = 109;
            this.AddPickup.Text = "Add Pickup";
            this.AddPickup.UseVisualStyleBackColor = true;
            this.AddPickup.Click += new System.EventHandler(this.AddPickup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "License";
            // 
            // PickupLicenseBox
            // 
            this.PickupLicenseBox.Location = new System.Drawing.Point(95, 365);
            this.PickupLicenseBox.Name = "PickupLicenseBox";
            this.PickupLicenseBox.Size = new System.Drawing.Size(178, 20);
            this.PickupLicenseBox.TabIndex = 106;
            // 
            // RemovePickup
            // 
            this.RemovePickup.Location = new System.Drawing.Point(358, 474);
            this.RemovePickup.Name = "RemovePickup";
            this.RemovePickup.Size = new System.Drawing.Size(95, 41);
            this.RemovePickup.TabIndex = 105;
            this.RemovePickup.Text = "Remove Pickup";
            this.RemovePickup.UseVisualStyleBackColor = true;
            this.RemovePickup.Click += new System.EventHandler(this.RemovePickup_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 104;
            // 
            // DriverIDBox
            // 
            this.DriverIDBox.Location = new System.Drawing.Point(95, 391);
            this.DriverIDBox.Name = "DriverIDBox";
            this.DriverIDBox.Size = new System.Drawing.Size(178, 20);
            this.DriverIDBox.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Driver ID";
            // 
            // DriverNameBox
            // 
            this.DriverNameBox.Location = new System.Drawing.Point(95, 416);
            this.DriverNameBox.Name = "DriverNameBox";
            this.DriverNameBox.Size = new System.Drawing.Size(178, 20);
            this.DriverNameBox.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "Driver Name";
            // 
            // DriverSurnameBox
            // 
            this.DriverSurnameBox.Location = new System.Drawing.Point(95, 442);
            this.DriverSurnameBox.Name = "DriverSurnameBox";
            this.DriverSurnameBox.Size = new System.Drawing.Size(178, 20);
            this.DriverSurnameBox.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 135;
            this.label3.Text = "Driver Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 136;
            this.label4.Text = "Current_Location";
            // 
            // CurrentLocationBox
            // 
            this.CurrentLocationBox.Location = new System.Drawing.Point(385, 365);
            this.CurrentLocationBox.Name = "CurrentLocationBox";
            this.CurrentLocationBox.Size = new System.Drawing.Size(175, 20);
            this.CurrentLocationBox.TabIndex = 137;
            // 
            // ShipmentListBox
            // 
            this.ShipmentListBox.Location = new System.Drawing.Point(385, 391);
            this.ShipmentListBox.Name = "ShipmentListBox";
            this.ShipmentListBox.Size = new System.Drawing.Size(175, 20);
            this.ShipmentListBox.TabIndex = 138;
            // 
            // CurrentShipmentBox
            // 
            this.CurrentShipmentBox.Location = new System.Drawing.Point(385, 420);
            this.CurrentShipmentBox.Name = "CurrentShipmentBox";
            this.CurrentShipmentBox.Size = new System.Drawing.Size(175, 20);
            this.CurrentShipmentBox.TabIndex = 139;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 142;
            this.label7.Text = "Shipment List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 143;
            this.label5.Text = "Current Shipment";
            // 
            // DataGridViewPickups
            // 
            this.DataGridViewPickups.AllowUserToAddRows = false;
            this.DataGridViewPickups.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewPickups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewPickups.ColumnHeadersHeight = 30;
            this.DataGridViewPickups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewPickups.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewPickups.Location = new System.Drawing.Point(12, 85);
            this.DataGridViewPickups.Name = "DataGridViewPickups";
            this.DataGridViewPickups.Size = new System.Drawing.Size(549, 250);
            this.DataGridViewPickups.TabIndex = 144;
            this.DataGridViewPickups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPickups_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(598, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 430);
            this.panel1.TabIndex = 145;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(343, 430);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // LiveLocationButton
            // 
            this.LiveLocationButton.Location = new System.Drawing.Point(465, 30);
            this.LiveLocationButton.Name = "LiveLocationButton";
            this.LiveLocationButton.Size = new System.Drawing.Size(95, 41);
            this.LiveLocationButton.TabIndex = 146;
            this.LiveLocationButton.Text = "Show Live Location";
            this.LiveLocationButton.UseVisualStyleBackColor = true;
            this.LiveLocationButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pickup_License ",
            "Driver_ID ",
            "Driver_Name ",
            "Driver_Surname ",
            "Current_Location ",
            "Current_Shipment ",
            "Shipment_List ",
            "\t"});
            this.comboBox1.Location = new System.Drawing.Point(311, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 147;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userControl11
            // 
            this.userControl11.HoverImg = ((System.Drawing.Image)(resources.GetObject("userControl11.HoverImg")));
            this.userControl11.Image = ((System.Drawing.Image)(resources.GetObject("userControl11.Image")));
            this.userControl11.Location = new System.Drawing.Point(702, 2);
            this.userControl11.Name = "userControl11";
            this.userControl11.NormalImg = null;
            this.userControl11.Size = new System.Drawing.Size(127, 77);
            this.userControl11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userControl11.TabIndex = 115;
            this.userControl11.TabStop = false;
            // 
            // PickupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(971, 537);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LiveLocationButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridViewPickups);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CurrentShipmentBox);
            this.Controls.Add(this.ShipmentListBox);
            this.Controls.Add(this.CurrentLocationBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DriverSurnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DriverNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DriverIDBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UpdatePickup);
            this.Controls.Add(this.AddPickup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PickupLicenseBox);
            this.Controls.Add(this.RemovePickup);
            this.Controls.Add(this.textBox1);
            this.Name = "PickupForm";
            this.Text = "PickupForm";
            this.Load += new System.EventHandler(this.PickupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPickups)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label13;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button UpdatePickup;
        private System.Windows.Forms.Button AddPickup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PickupLicenseBox;
        private System.Windows.Forms.Button RemovePickup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DriverIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DriverNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DriverSurnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentLocationBox;
        private System.Windows.Forms.TextBox ShipmentListBox;
        private System.Windows.Forms.TextBox CurrentShipmentBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataGridViewPickups;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LiveLocationButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}