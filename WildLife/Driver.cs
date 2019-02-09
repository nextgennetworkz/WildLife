using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WildLife
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Let's save the driver in the database
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost:3306;Initial Catalog=wildlife;User ID=root;Password=gvt123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");
            cnn.Close();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
