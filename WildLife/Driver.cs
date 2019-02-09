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
        string error = "Error";

        public Driver()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Let's validate the name of the driver
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter the name of the driver.", error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }

            // Let's validate the NIC number of the driver
            if (string.IsNullOrEmpty(txtNICNumber.Text))
            {
                MessageBox.Show("Please enter the NIC number of the driver.", error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's save the driver's information in the database
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Let's close the form
            this.Close();
        }
    }
}
