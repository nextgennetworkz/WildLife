using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildLife
{
    public partial class Vehicle : Form
    {
        string error = "Error";

        public Vehicle()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Let's validate the plate number of the vehicle
            if (string.IsNullOrEmpty(txtPlateNumber.Text))
            {
                MessageBox.Show("Please enter the plate number of the vehicle.", error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            // Let's verify that the owner is selected

            // Let's verify that the driver is selected
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Let's close the form
            this.Close();
        }
    }
}
