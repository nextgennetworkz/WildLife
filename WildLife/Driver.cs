﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WildLife
{
    public partial class Driver : Form
    {
        string successMessageTitle = "Success";
        string errorMessageTitle = "Error";

        MySqlConnection connection;

        public Driver()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Let's validate the name of the driver
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter the name of the driver.", errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's validate the NIC number of the driver
            if (string.IsNullOrEmpty(txtNICNumber.Text))
            {
                MessageBox.Show("Please enter the NIC number of the driver.", errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's save the driver's information in the database
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["wildlifeConnectionString"].ConnectionString;
                string query = "INSERT INTO WILDLIFE.DRIVER (name, nic_number, mobile_number, address)" +
                "VALUES ('" + txtName.Text + "', '" + txtNICNumber.Text + "', '" + txtMobileNumber.Text + "', '" + txtAddress.Text + "')";

                connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                command.ExecuteReader();

                // Let's show success message and close the form
                MessageBox.Show("The driver was successfully registered.", successMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
