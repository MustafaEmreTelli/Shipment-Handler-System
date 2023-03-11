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
    
    public partial class PickupForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UI7Q9JV;Initial Catalog=ShipmentHandler; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public PickupForm()
        {
            InitializeComponent();
            LoadPickups();
        }

        public void LoadPickups()
        {
            DataGridViewPickups.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tblPickup", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewPickups.DataSource = dataSet.Tables[0];
        }
        public void Refresh()
        {
            cmd = new SqlCommand("SELECT * FROM tblPickup", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewPickups.DataSource = dataSet.Tables[0];
        }
        private void PickupForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder queryadress = new StringBuilder();
            queryadress.Append("https://www.google.com/maps?q=");
            queryadress.Append(" " + CurrentLocationBox.Text);

            webBrowser1.Navigate(queryadress.ToString());
        }

        private void DataGridViewPickups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PickupLicenseBox.Text = DataGridViewPickups.Rows[e.RowIndex].Cells[0].Value.ToString();
            DriverIDBox.Text = DataGridViewPickups.Rows[e.RowIndex].Cells[1].Value.ToString();
            DriverNameBox.Text = DataGridViewPickups.Rows[e.RowIndex].Cells[2].Value.ToString();
            DriverSurnameBox.Text = DataGridViewPickups.Rows[e.RowIndex].Cells[3].Value.ToString();
            CurrentLocationBox.Text = DataGridViewPickups.Rows[e.RowIndex].Cells[4].Value.ToString();
            CurrentShipmentBox.Text = DataGridViewPickups.Rows[e.RowIndex].Cells[5].Value.ToString();
            ShipmentListBox.Text = DataGridViewPickups.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void AddPickup_Click(object sender, EventArgs e)
        {
            if (PickupLicenseBox.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO tblPickup (Pickup_License,Driver_ID,Driver_Name,Driver_Surname,Current_Location,Current_Shipment,Shipment_List) values (@Pickup_License,@Driver_ID,@Driver_Name,@Driver_Surname,@Current_Location,@Current_Shipment,@Shipment_List)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@Pickup_License", PickupLicenseBox.Text);
                cmd.Parameters.AddWithValue("@Driver_ID", DriverIDBox.Text);
                cmd.Parameters.AddWithValue("@Driver_Name", DriverNameBox.Text);
                cmd.Parameters.AddWithValue("@Driver_Surname", DriverSurnameBox.Text);
                cmd.Parameters.AddWithValue("@Current_Location", CurrentLocationBox.Text);
                cmd.Parameters.AddWithValue("@Current_Shipment", CurrentShipmentBox.Text);
                cmd.Parameters.AddWithValue("@Shipment_List", ShipmentListBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                PickupLicenseBox.Clear();
                DriverIDBox.Clear();
                DriverNameBox.Clear();
                DriverSurnameBox.Clear();
                CurrentLocationBox.Clear();
                CurrentShipmentBox.Clear();
                ShipmentListBox.Clear();
                

                MessageBox.Show("Pickup is added to the system succesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pickup license number can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh();
        }

        private void UpdatePickup_Click(object sender, EventArgs e)
        {
            if (PickupLicenseBox.Text != "")
            {
                cmd = new SqlCommand("update tblPickup set Driver_ID=@Driver_ID,Driver_Name=@Driver_Name, Driver_Surname=@Driver_Surname,Current_Location=@Current_Location,Current_Shipment=@Current_Shipment,Shipment_List=@Shipment_List where Pickup_License=@Pickup_License", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Pickup_License", PickupLicenseBox.Text);
                cmd.Parameters.AddWithValue("@Driver_ID", DriverIDBox.Text);
                cmd.Parameters.AddWithValue("@Driver_Name", DriverNameBox.Text);
                cmd.Parameters.AddWithValue("@Driver_Surname", DriverSurnameBox.Text);
                cmd.Parameters.AddWithValue("@Current_Location", CurrentLocationBox.Text);
                cmd.Parameters.AddWithValue("@Current_Shipment", CurrentShipmentBox.Text);
                cmd.Parameters.AddWithValue("@Shipment_List", ShipmentListBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pickup Information is Updated Successfully");
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select a Pickup Truck to Update");
            }

            Refresh();
        }

        private void RemovePickup_Click(object sender, EventArgs e)
        {
            if (PickupLicenseBox.Text != "")
            {
                cmd = new SqlCommand("delete tblPickup where Pickup_License=@Pickup_License", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Pickup_License", PickupLicenseBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Pickup Truck is removed from the system Successfully!");
            }
            else
            {
                MessageBox.Show("Please Select an Pickup Truck to Delete");
            }
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string SearchType = comboBox1.Text;
            string Search = textBox1.Text;
            cmd = new SqlCommand("SELECT * FROM tblPickup where " + SearchType + " = '" + Search + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewPickups.DataSource = dataSet.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
