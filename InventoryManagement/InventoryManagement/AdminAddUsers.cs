using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        Microsoft.Data.SqlClient.SqlConnection connect =
    new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename=C:\Users\franc\source\repos\InventoryManagement\InventoryManagement\inventory.mdf;
    Integrated Security=True;Connect Timeout=30;");


        public Form1()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}