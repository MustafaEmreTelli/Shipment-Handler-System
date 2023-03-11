namespace ShipmentHandlerSystem
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.userControl11 = new ShipmentHandlerSystem.UserControl1();
            this.SearchItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.DataGridViewInv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemBrandBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemPriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemTypeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemIDBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Controls.Add(this.SearchItem);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 96);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 49);
            this.button3.TabIndex = 19;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userControl11
            // 
            this.userControl11.HoverImg = ((System.Drawing.Image)(resources.GetObject("userControl11.HoverImg")));
            this.userControl11.Image = ((System.Drawing.Image)(resources.GetObject("userControl11.Image")));
            this.userControl11.Location = new System.Drawing.Point(702, 7);
            this.userControl11.Name = "userControl11";
            this.userControl11.NormalImg = null;
            this.userControl11.Size = new System.Drawing.Size(99, 60);
            this.userControl11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userControl11.TabIndex = 18;
            this.userControl11.TabStop = false;
            this.userControl11.Click += new System.EventHandler(this.userControl11_Click_1);
            // 
            // SearchItem
            // 
            this.SearchItem.Location = new System.Drawing.Point(177, 44);
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.Size = new System.Drawing.Size(290, 23);
            this.SearchItem.TabIndex = 17;
            this.SearchItem.Text = "ID Search";
            this.SearchItem.UseVisualStyleBackColor = true;
            this.SearchItem.Click += new System.EventHandler(this.SearchItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(712, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RemoveItem
            // 
            this.RemoveItem.Location = new System.Drawing.Point(807, 324);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(75, 41);
            this.RemoveItem.TabIndex = 16;
            this.RemoveItem.Text = "Remove Item";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // DataGridViewInv
            // 
            this.DataGridViewInv.AllowUserToAddRows = false;
            this.DataGridViewInv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewInv.ColumnHeadersHeight = 30;
            this.DataGridViewInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewInv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewInv.Location = new System.Drawing.Point(12, 73);
            this.DataGridViewInv.Name = "DataGridViewInv";
            this.DataGridViewInv.Size = new System.Drawing.Size(590, 292);
            this.DataGridViewInv.TabIndex = 1;
            this.DataGridViewInv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Brand";
            // 
            // ItemBrandBox
            // 
            this.ItemBrandBox.Location = new System.Drawing.Point(662, 276);
            this.ItemBrandBox.Name = "ItemBrandBox";
            this.ItemBrandBox.Size = new System.Drawing.Size(225, 20);
            this.ItemBrandBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price";
            // 
            // ItemPriceBox
            // 
            this.ItemPriceBox.Location = new System.Drawing.Point(662, 240);
            this.ItemPriceBox.Name = "ItemPriceBox";
            this.ItemPriceBox.Size = new System.Drawing.Size(225, 20);
            this.ItemPriceBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Type";
            // 
            // ItemTypeBox
            // 
            this.ItemTypeBox.Location = new System.Drawing.Point(662, 201);
            this.ItemTypeBox.Name = "ItemTypeBox";
            this.ItemTypeBox.Size = new System.Drawing.Size(225, 20);
            this.ItemTypeBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.Location = new System.Drawing.Point(662, 164);
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(225, 20);
            this.ItemNameBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ItemIDBox
            // 
            this.ItemIDBox.Location = new System.Drawing.Point(662, 123);
            this.ItemIDBox.Name = "ItemIDBox";
            this.ItemIDBox.Size = new System.Drawing.Size(225, 20);
            this.ItemIDBox.TabIndex = 17;
            this.ItemIDBox.TextChanged += new System.EventHandler(this.ItemIDBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(726, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 28;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ItemID ",
            "Item_Name ",
            "Item_Type ",
            "Item_Price",
            "Item_Brand",
            "\t"});
            this.comboBox1.Location = new System.Drawing.Point(357, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 148;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(903, 373);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemBrandBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemPriceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemTypeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ItemIDBox);
            this.Controls.Add(this.DataGridViewInv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RemoveItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridViewInv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.Button SearchItem;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemBrandBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemPriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ItemIDBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}