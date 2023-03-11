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
    public partial class ClientsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UI7Q9JV;Initial Catalog=ShipmentHandler; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public ClientsForm()
        {
            InitializeComponent();
            LoadClients();
        }
        public void LoadClients()
        {
            DataGridViewClient.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tblClient", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewClient.DataSource = dataSet.Tables[0];
        }

        public void RefreshC()
        {
            cmd = new SqlCommand("SELECT * FROM tblClient", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewClient.DataSource = dataSet.Tables[0];
        }
        private void DataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIDBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            CustomerNameBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            CustomerSurnameBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            CustomerTelephoneBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            CustomerEmailBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[4].Value.ToString();
            AdressInformationBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[5].Value.ToString();
            CustomerCountryBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[6].Value.ToString();
            CustomerCityBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[7].Value.ToString();
            CustomerStateBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[8].Value.ToString();
            PostalCodeBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[9].Value.ToString();
            AdditionalInformationBox.Text = DataGridViewClient.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            if (CustomerIDBox.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO tblClient (ClientID,Client_Name,Client_Surname,Telephone,Email,Adress_Information,Country,City_Town,State_Province_Country,Postal_Code,Additional_Information) values (@ClientID,@Client_Name,@Client_Surname,@Telephone,@Email,@Adress_Information,@Country,@City_Town,@State_Province_Country,@Postal_Code,@Additional_Information)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@ClientID", CustomerIDBox.Text);
                cmd.Parameters.AddWithValue("@Client_Name", CustomerNameBox.Text);
                cmd.Parameters.AddWithValue("@Client_Surname", CustomerSurnameBox.Text);
                cmd.Parameters.AddWithValue("@Telephone", CustomerTelephoneBox.Text);
                cmd.Parameters.AddWithValue("@Email", CustomerEmailBox.Text);
                cmd.Parameters.AddWithValue("@Adress_Information", AdressInformationBox.Text);
                cmd.Parameters.AddWithValue("@Country", CustomerCountryBox.Text);
                cmd.Parameters.AddWithValue("@City_Town", CustomerCityBox.Text);
                cmd.Parameters.AddWithValue("@State_Province_Country", CustomerStateBox.Text);
                cmd.Parameters.AddWithValue("@Postal_Code", PostalCodeBox.Text);
                cmd.Parameters.AddWithValue("@Additional_Information", AdditionalInformationBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                CustomerIDBox.Clear();
                CustomerNameBox.Clear();
                CustomerSurnameBox.Clear();
                CustomerTelephoneBox.Clear();
                CustomerEmailBox.Clear();
                AdressInformationBox.Clear();
                CustomerCountryBox.Clear();
                CustomerCityBox.Clear();
                CustomerStateBox.Clear();
                PostalCodeBox.Clear();
                AdditionalInformationBox.Clear();

                MessageBox.Show("Client has been Registered to the System Succesfully!.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshC();
        }

        private void UpdateClient_Click(object sender, EventArgs e)
        {
            if (CustomerIDBox.Text != "")
            {
                cmd = new SqlCommand("update tblClient set Client_Name=@Client_Name,Client_Surname=@Client_Surname,Telephone=@Telephone,Email=@Email,Adress_Information=@Adress_Information,Country=@Country,City_Town=@City_Town,State_Province_Country=@State_Province_Country,Postal_Code=@Postal_Code,Additional_Information=@Additional_Information where ClientID=@ClientID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ClientID", CustomerIDBox.Text);
                cmd.Parameters.AddWithValue("@Client_Name", CustomerNameBox.Text);
                cmd.Parameters.AddWithValue("@Client_Surname", CustomerSurnameBox.Text);
                cmd.Parameters.AddWithValue("@Telephone", CustomerTelephoneBox.Text);
                cmd.Parameters.AddWithValue("@Email", CustomerEmailBox.Text);
                cmd.Parameters.AddWithValue("@Adress_Information", AdressInformationBox.Text);
                cmd.Parameters.AddWithValue("@Country", CustomerCountryBox.Text);
                cmd.Parameters.AddWithValue("@City_Town", CustomerCityBox.Text);
                cmd.Parameters.AddWithValue("@State_Province_Country", CustomerStateBox.Text);
                cmd.Parameters.AddWithValue("@Postal_Code", PostalCodeBox.Text);
                cmd.Parameters.AddWithValue("@Additional_Information", AdditionalInformationBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select an Item to Update");
            }
            RefreshC();
        }

        private void RemoveClient_Click(object sender, EventArgs e)
        {
            if (CustomerIDBox.Text != "")
            {
                cmd = new SqlCommand("delete tblClient where ClientID=@ClientID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ClientID", CustomerIDBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Client is removed from the system Successfully!");
            }
            else
            {
                MessageBox.Show("Please Select an Customer Record to Delete");
            }
            RefreshC();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshC();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string SearchType = comboBox1.Text;
            string Search = textBox1.Text;
            cmd = new SqlCommand("SELECT * FROM tblClient where " + SearchType + " = '" + Search + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            DataGridViewClient.DataSource = dataSet.Tables[0];
        }
    }
}
