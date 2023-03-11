using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentHandlerSystem
{
    public partial class ShipmentHandler : Form
    {
        public ShipmentHandler()
        {
            InitializeComponent();
        }

        private void userControl11_Click(object sender, EventArgs e)
        {
            var newForm = new Inventory();
            newForm.Show();
        }


        private void userControl12_Click(object sender, EventArgs e)
        {
            var newForm = new ShipmentsForm();
            newForm.Show();
        }

        private void userControl14_Click(object sender, EventArgs e)
        {
            var newForm = new ClientsForm();
            newForm.Show();
        }

        
        private void userControl13_Click(object sender, EventArgs e)
        {
            var newForm = new PickupForm();
            newForm.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
