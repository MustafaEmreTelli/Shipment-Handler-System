using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentHandlerSystem
{
    public partial class ShipmentsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UI7Q9JV;Initial Catalog=ShipmentHandler; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public ShipmentsForm()
        {
            InitializeComponent();
            LoadShipments();
        }
        public void LoadShipments()
        {
            DataGridViewShipment.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tblShipment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewShipment.DataSource = dataSet.Tables[0];
        }
        public void Refresh()
        {
            cmd = new SqlCommand("SELECT * FROM tblShipment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewShipment.DataSource = dataSet.Tables[0];
        }
        private void ShipmentsForm_Load(object sender, EventArgs e)
        {

        }

        private void DataGridViewShipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShipmentIDBox.Text = DataGridViewShipment.Rows[e.RowIndex].Cells[0].Value.ToString();
            DeliveryTypeBox.Text = DataGridViewShipment.Rows[e.RowIndex].Cells[1].Value.ToString();
            ShipmentDescription.Text = DataGridViewShipment.Rows[e.RowIndex].Cells[2].Value.ToString();
            WeightBox.Text = DataGridViewShipment.Rows[e.RowIndex].Cells[3].Value.ToString();
            Item1IDBox.Text = DataGridViewShipment.Rows[e.RowIndex].Cells[4].Value.ToString();
            Item2IDBox.Text = DataGridViewShipment.Rows[e.RowIndex].Cells[5].Value.ToString();
            Item3IDBox.Text = DataGridViewShipment.Rows[e.RowIndex].Cells[6].Value.ToString();
            ClientID.Text = DataGridViewShipment.Rows[e.RowIndex].Cells[7].Value.ToString();
            PickupID.Text = DataGridViewShipment.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void AddShipment_Click(object sender, EventArgs e)
        {
            if (ShipmentIDBox.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO tblShipment (ShipmentID,Delivery_Type,Shipment_Description,Shipment_Weight,Item1,Item2,Item3,Client,Pickup) values (@ShipmentID,@Delivery_Type,@Shipment_Description,@Shipment_Weight,@Item1,@Item2,@Item3,@Client,@Pickup)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@ShipmentID", ShipmentIDBox.Text);
                cmd.Parameters.AddWithValue("@Delivery_Type", DeliveryTypeBox.Text);
                cmd.Parameters.AddWithValue("@Shipment_Description", ShipmentDescription.Text);
                cmd.Parameters.AddWithValue("@Shipment_Weight", WeightBox.Text);
                cmd.Parameters.AddWithValue("@Item1", Item1IDBox.Text);
                cmd.Parameters.AddWithValue("@Item2", Item2IDBox.Text);
                cmd.Parameters.AddWithValue("@Item3", Item3IDBox.Text);
                cmd.Parameters.AddWithValue("@Client", ClientID.Text);
                cmd.Parameters.AddWithValue("@Pickup", PickupID.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                ShipmentIDBox.Clear();
                DeliveryTypeBox.Clear();
                ShipmentDescription.Clear();
                Item1IDBox.Clear();
                Item2IDBox.Clear();
                Item3IDBox.Clear();
                ClientID.Clear();
                PickupID.Clear();

                MessageBox.Show("Shipment is saved to the system succesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Shipment ID can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh();
        }

        private void UpdateClient_Click(object sender, EventArgs e)
        {
            if (ShipmentIDBox.Text != "")
            {
                cmd = new SqlCommand("update tblShipment set Delivery_Type=@Delivery_Type,Shipment_Description=@Shipment_Description, Shipment_Weight=@Shipment_Weight,Item1=@Item1,Item2=@Item2,Item3=@Item3,Client=@Client,Pickup=@Pickup where ShipmentID=@ShipmentID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ShipmentID", ShipmentIDBox.Text);
                cmd.Parameters.AddWithValue("@Delivery_Type", DeliveryTypeBox.Text);
                cmd.Parameters.AddWithValue("@Shipment_Description", ShipmentDescription.Text);
                cmd.Parameters.AddWithValue("@Shipment_Weight", WeightBox.Text);
                cmd.Parameters.AddWithValue("@Item1", Item1IDBox.Text);
                cmd.Parameters.AddWithValue("@Item2", Item2IDBox.Text);
                cmd.Parameters.AddWithValue("@Item3", Item3IDBox.Text);
                cmd.Parameters.AddWithValue("@Client", ClientID.Text);
                cmd.Parameters.AddWithValue("@Pickup", PickupID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Shipment is Updated Successfully");
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select a Shipment to Update");
            }

            Refresh();
        }

        private void RemoveShipment_Click(object sender, EventArgs e)
        {
            if (ShipmentIDBox.Text != "")
            {
                cmd = new SqlCommand("delete tblShipment where ShipmentID=@Shipment", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Shipment", ShipmentIDBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Shipment is removed from the system Successfully!");
            }
            else
            {
                MessageBox.Show("Please Select an Item to Delete");
            }
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SearchType = comboBox1.Text;
            string Search = textBox1.Text;
            cmd = new SqlCommand("SELECT * FROM tblShipment where " + SearchType + " = '" + Search + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewShipment.DataSource = dataSet.Tables[0];
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PickupID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item3IDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Item2IDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item1IDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WeightBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ShipmentDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeliveryTypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ShipmentIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControl11_Click(object sender, EventArgs e)
        {

        }

        private void ShipmentList_Click(object sender, EventArgs e)
        {
            var newForm = new ShipmentListsForm();
            newForm.Show();
        }
    }
}
