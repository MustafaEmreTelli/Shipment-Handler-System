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
    public partial class ShipmentListsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UI7Q9JV;Initial Catalog=ShipmentHandler; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public ShipmentListsForm()
        {
            InitializeComponent();
            LoadLists();
        }

        public void LoadLists()
        {

            DataGridViewList.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tblShipmentList", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewList.DataSource = dataSet.Tables[0];
        }

        public void Refresh()
        {
            cmd = new SqlCommand("SELECT * FROM tblShipmentList", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewList.DataSource = dataSet.Tables[0];
        }

        private void DataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListIDBox.Text = DataGridViewList.Rows[e.RowIndex].Cells[0].Value.ToString();
            Shipment1.Text = DataGridViewList.Rows[e.RowIndex].Cells[1].Value.ToString();
            Shipment2.Text = DataGridViewList.Rows[e.RowIndex].Cells[2].Value.ToString();
            Shipment3.Text = DataGridViewList.Rows[e.RowIndex].Cells[3].Value.ToString();
            Shipment4.Text = DataGridViewList.Rows[e.RowIndex].Cells[4].Value.ToString();
            Shipment5.Text = DataGridViewList.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void Item1IDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddShipmentList_Click(object sender, EventArgs e)
        {
            if (ListIDBox.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO tblShipmentList (Shipment_ListID,Shipment1,Shipment2,Shipment3,Shipment4,Shipment5) values (@Shipment_ListID,@Shipment1,@Shipment2,@Shipment3,@Shipment4,@Shipment5)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@Shipment_ListID", ListIDBox.Text);
                cmd.Parameters.AddWithValue("@Shipment1", Shipment1.Text);
                cmd.Parameters.AddWithValue("@Shipment2", Shipment2.Text);
                cmd.Parameters.AddWithValue("@Shipment3", Shipment3.Text);
                cmd.Parameters.AddWithValue("@Shipment4", Shipment4.Text);
                cmd.Parameters.AddWithValue("@Shipment5", Shipment5.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                ListIDBox.Clear();
                Shipment1.Clear();
                Shipment2.Clear();
                Shipment3.Clear();
                Shipment4.Clear();
                Shipment5.Clear();
                

                MessageBox.Show("Shipment list is saved to the system succesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Shipment List ID can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh();
        }

        private void UpdateList_Click(object sender, EventArgs e)
        {
            if (ListIDBox.Text != "")
            {
                cmd = new SqlCommand("update tblShipmentList set Shipment1=@Shipment1,Shipment2=@Shipment2, Shipment3=@Shipment3,Shipment4=@Shipment4,Shipment5=@Shipment5 where Shipment_ListID=@Shipment_ListID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Shipment_ListID", ListIDBox.Text);
                cmd.Parameters.AddWithValue("@Shipment1", Shipment1.Text);
                cmd.Parameters.AddWithValue("@Shipment2", Shipment2.Text);
                cmd.Parameters.AddWithValue("@Shipment3", Shipment3.Text);
                cmd.Parameters.AddWithValue("@Shipment4", Shipment4.Text);
                cmd.Parameters.AddWithValue("@Shipment5", Shipment5.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Shipment List is Updated Successfully");
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select a Shipment List to Update");
            }
            Refresh();
        }

        private void RemoveShipmentList_Click(object sender, EventArgs e)
        {
            if (ListIDBox.Text != "")
            {
                cmd = new SqlCommand("delete tblShipmentList where Shipment_ListID=@Shipment_ListID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Shipment_ListID", ListIDBox.Text);
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
    }
}
