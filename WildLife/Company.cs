using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WildLife
{
    public partial class Company : Form
    {
        string successMessageTitle = "Success";
        string errorMessageTitle = "Error";

        MySqlConnection connection;

        public Company()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Let's validate the name of the company
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter the name of the company.", errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's validate the name of the owner
            if (string.IsNullOrEmpty(txtOwnerName.Text))
            {
                MessageBox.Show("Please enter the name of the owner.", errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's validate the NIC of the owner
            if (string.IsNullOrEmpty(txtOwnerName.Text))
            {
                MessageBox.Show("Please enter the NIC of the owner.", errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's validate the mobile number of the owner
            if (string.IsNullOrEmpty(txtMobileNumber.Text))
            {
                MessageBox.Show("Please enter the mobile number of the owner.", errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's save the driver's information in the database
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["wildlifeConnectionString"].ConnectionString;
                string query = "INSERT INTO WILDLIFE.COMPANY (name, address, owner_name, owner_nic_number, owner_mobile_number)" +
                "VALUES ('" + txtName.Text+ "', '" + txtAddress.Text + "', '" + txtOwnerName.Text + "', '" + txtNICNumber.Text + "', '" + txtMobileNumber.Text + "')";

                connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                command.ExecuteReader();

                // Let's show success message and close the form
                MessageBox.Show("The company was successfully registered.", successMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Let's close the form
            this.Close();
        }
    }
}
