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
    public partial class Owner : Form
    {
        string error = "Error";

        public Owner()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Let's validate the name of the owner
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter the name of the owner.", error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            // Let's validate the NIC number of the owner
            if (string.IsNullOrEmpty(txtNICNumber.Text))
            {
                MessageBox.Show("Please enter the NIC number of the owner.", error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's save the owner's information in the database
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Let's close the form
            this.Close();
        }
    }
}
