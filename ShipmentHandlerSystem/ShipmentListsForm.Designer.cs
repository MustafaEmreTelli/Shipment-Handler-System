namespace ShipmentHandlerSystem
{
    partial class ShipmentListsForm
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
            this.DataGridViewList = new System.Windows.Forms.DataGridView();
            this.Shipment2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Shipment1 = new System.Windows.Forms.TextBox();
            this.ListIDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateList = new System.Windows.Forms.Button();
            this.AddShipmentList = new System.Windows.Forms.Button();
            this.RemoveShipmentList = new System.Windows.Forms.Button();
            this.Shipment5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Shipment4 = new System.Windows.Forms.TextBox();
            this.Shipment3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewList
            // 
            this.DataGridViewList.AllowUserToAddRows = false;
            this.DataGridViewList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewList.ColumnHeadersHeight = 30;
            this.DataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewList.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewList.Name = "DataGridViewList";
            this.DataGridViewList.Size = new System.Drawing.Size(408, 336);
            this.DataGridViewList.TabIndex = 59;
            this.DataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewList_CellContentClick);
            // 
            // Shipment2
            // 
            this.Shipment2.Location = new System.Drawing.Point(502, 122);
            this.Shipment2.Name = "Shipment2";
            this.Shipment2.Size = new System.Drawing.Size(133, 20);
            this.Shipment2.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Shipment 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Shipment 1";
            // 
            // Shipment1
            // 
            this.Shipment1.Location = new System.Drawing.Point(502, 78);
            this.Shipment1.Name = "Shipment1";
            this.Shipment1.Size = new System.Drawing.Size(133, 20);
            this.Shipment1.TabIndex = 100;
            // 
            // ListIDBox
            // 
            this.ListIDBox.Location = new System.Drawing.Point(502, 34);
            this.ListIDBox.Name = "ListIDBox";
            this.ListIDBox.Size = new System.Drawing.Size(133, 20);
            this.ListIDBox.TabIndex = 99;
            this.ListIDBox.TextChanged += new System.EventHandler(this.Item1IDBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "List ID";
            // 
            // UpdateList
            // 
            this.UpdateList.Location = new System.Drawing.Point(502, 305);
            this.UpdateList.Name = "UpdateList";
            this.UpdateList.Size = new System.Drawing.Size(68, 47);
            this.UpdateList.TabIndex = 106;
            this.UpdateList.Text = "Update ";
            this.UpdateList.UseVisualStyleBackColor = true;
            this.UpdateList.Click += new System.EventHandler(this.UpdateList_Click);
            // 
            // AddShipmentList
            // 
            this.AddShipmentList.Location = new System.Drawing.Point(436, 305);
            this.AddShipmentList.Name = "AddShipmentList";
            this.AddShipmentList.Size = new System.Drawing.Size(60, 47);
            this.AddShipmentList.TabIndex = 105;
            this.AddShipmentList.Text = "Add List";
            this.AddShipmentList.UseVisualStyleBackColor = true;
            this.AddShipmentList.Click += new System.EventHandler(this.AddShipmentList_Click);
            // 
            // RemoveShipmentList
            // 
            this.RemoveShipmentList.Location = new System.Drawing.Point(576, 305);
            this.RemoveShipmentList.Name = "RemoveShipmentList";
            this.RemoveShipmentList.Size = new System.Drawing.Size(62, 47);
            this.RemoveShipmentList.TabIndex = 104;
            this.RemoveShipmentList.Text = "Remove List";
            this.RemoveShipmentList.UseVisualStyleBackColor = true;
            this.RemoveShipmentList.Click += new System.EventHandler(this.RemoveShipmentList_Click);
            // 
            // Shipment5
            // 
            this.Shipment5.Location = new System.Drawing.Point(502, 251);
            this.Shipment5.Name = "Shipment5";
            this.Shipment5.Size = new System.Drawing.Size(133, 20);
            this.Shipment5.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Shipment 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "Shipment 4";
            // 
            // Shipment4
            // 
            this.Shipment4.Location = new System.Drawing.Point(502, 204);
            this.Shipment4.Name = "Shipment4";
            this.Shipment4.Size = new System.Drawing.Size(133, 20);
            this.Shipment4.TabIndex = 109;
            // 
            // Shipment3
            // 
            this.Shipment3.Location = new System.Drawing.Point(502, 164);
            this.Shipment3.Name = "Shipment3";
            this.Shipment3.Size = new System.Drawing.Size(133, 20);
            this.Shipment3.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "Shipment 3";
            // 
            // ShipmentListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(647, 360);
            this.Controls.Add(this.Shipment5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Shipment4);
            this.Controls.Add(this.Shipment3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UpdateList);
            this.Controls.Add(this.AddShipmentList);
            this.Controls.Add(this.RemoveShipmentList);
            this.Controls.Add(this.Shipment2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Shipment1);
            this.Controls.Add(this.ListIDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridViewList);
            this.Name = "ShipmentListsForm";
            this.Text = "ShipmentListsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewList;
        private System.Windows.Forms.TextBox Shipment2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Shipment1;
        private System.Windows.Forms.TextBox ListIDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateList;
        private System.Windows.Forms.Button AddShipmentList;
        private System.Windows.Forms.Button RemoveShipmentList;
        private System.Windows.Forms.TextBox Shipment5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Shipment4;
        private System.Windows.Forms.TextBox Shipment3;
        private System.Windows.Forms.Label label6;
    }
}