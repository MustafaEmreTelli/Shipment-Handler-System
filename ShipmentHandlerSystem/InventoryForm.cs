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
using System.Data.SqlClient;

namespace ShipmentHandlerSystem
{
    public partial class Inventory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UI7Q9JV;Initial Catalog=ShipmentHandler; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public Inventory()
        {
            InitializeComponent();
            LoadInventory();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemIDBox.Text = DataGridViewInv.Rows[e.RowIndex].Cells[0].Value.ToString();
            ItemNameBox.Text = DataGridViewInv.Rows[e.RowIndex].Cells[1].Value.ToString();
            ItemTypeBox.Text = DataGridViewInv.Rows[e.RowIndex].Cells[2].Value.ToString();
            ItemPriceBox.Text = DataGridViewInv.Rows[e.RowIndex].Cells[3].Value.ToString();
            ItemBrandBox.Text = DataGridViewInv.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        public void LoadInventory()
        {
            DataGridViewInv.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tblItem", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewInv.DataSource = dataSet.Tables[0];
        }
        public void Refresh()
        {
            cmd = new SqlCommand("SELECT * FROM tblItem", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewInv.DataSource = dataSet.Tables[0];
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void AddItem_Click(object sender, EventArgs e)
        {
            if(ItemIDBox.Text != "")
            {
                cmd = new SqlCommand("delete tblItem where ItemID=@ItemID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ItemID", ItemIDBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Item Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Please Select an Item to Delete");
            }
            Refresh();
        }

       

        private void SearchItem_Click(object sender, EventArgs e)
        {
            string SearchType = comboBox1.Text;
            string Search = textBox1.Text;
            cmd = new SqlCommand("SELECT * FROM tblItem where " + SearchType + " = '" + Search + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewInv.DataSource = dataSet.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControl11_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewInv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ItemNameBox.Text = DataGridViewInv.Rows[e.RowIndex].Cells[1].Value.ToString();
            ItemTypeBox.Text = DataGridViewInv.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemIDBox.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO tblItem (ItemID,Item_Name,Item_Type,Item_Price,Item_Brand) values (@ItemID,@Item_Name,@Item_Type,@Item_Price,@Item_Brand)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@ItemID", ItemIDBox.Text);
                cmd.Parameters.AddWithValue("@Item_Name", ItemNameBox.Text);
                cmd.Parameters.AddWithValue("@Item_Type", ItemTypeBox.Text);
                cmd.Parameters.AddWithValue("@Item_Price", ItemPriceBox.Text);
                cmd.Parameters.AddWithValue("@Item_Brand", ItemBrandBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                ItemIDBox.Clear();
                ItemNameBox.Clear();
                ItemTypeBox.Clear();
                ItemPriceBox.Clear();
                ItemBrandBox.Clear();

                MessageBox.Show("Item is saved to the inventory.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh();
        }

        private void ItemIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemIDBox.Text != "")
            {
                cmd = new SqlCommand("update tblItem set Item_Name=@Item_Name,Item_Type=@Item_Type,Item_Price=@Item_Price,Item_Brand=@Item_Brand where ItemID=@ItemID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ItemID", ItemIDBox.Text);
                cmd.Parameters.AddWithValue("@Item_Name", ItemNameBox.Text);
                cmd.Parameters.AddWithValue("@Item_Type", ItemTypeBox.Text);
                cmd.Parameters.AddWithValue("@Item_Price", ItemPriceBox.Text);
                cmd.Parameters.AddWithValue("@Item_Brand", ItemBrandBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select an Item to Update");
            }
            Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
