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
    public partial class Vehicle : Form
    {
        string successMessageTitle = "Success";
        string errorMessageTitle = "Error";

        string connectionString;

        MySqlConnection connection;

        public Vehicle()
        {
            InitializeComponent();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            // Let's populate the connection string
            string connectionString = ConfigurationManager.ConnectionStrings["wildlifeConnectionString"].ConnectionString;

            // Let's load companies from the database
            loadCompanies();

            // Let's load drivers from the database
            loadDrivers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Let's validate the plate number of the vehicle
            if (string.IsNullOrEmpty(txtPlateNumber.Text))
            {
                MessageBox.Show("Please enter the plate number of the vehicle.", errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's verify that the company is selected
            if (comboBoxCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the company of the vehicle.", errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's verify that the driver is selected
            if (comboBoxDriver.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the driver of the vehicle.", errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let's save the vehicle's information in the database
            try
            {
                string connectionString = "server=localhost;user id=root;password=gvt123;persistsecurityinfo=True;database=wildlife;characterset=utf8";
                connection = new MySqlConnection(connectionString);
                MySqlCommand command = connection.CreateCommand();
                MySqlTransaction transaction = connection.BeginTransaction();
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "INSERT INTO WILDLIFE.VEHICLE (plate_number)" +
                        " OUTPUT INSERTED.ID " +
                        "VALUES ('" + txtPlateNumber.Text + "')";
                    int vehicleID = (int)command.ExecuteScalar();

                    command.CommandText = "INSERT INTO WILDLIFE.COMPANY_VEHICLE (company_id, vehicle_id)" +
                "VALUES ('" + comboBoxCompany.SelectedValue + "', '" + vehicleID + "')";
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO WILDLIFE.DRIVER_VEHICLE (driver_id, vehicle_id)" +
                "VALUES ('" + comboBoxDriver.SelectedValue + "', '" + vehicleID  + "')";
                    command.ExecuteNonQuery();

                    transaction.Commit();

                    // Let's show success message and close the form
                    MessageBox.Show("The driver was successfully registered.", successMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (System.Data.SqlClient.SqlException se)
                    {
                        MessageBox.Show(se.Message, errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        // The method to load company data from the database
        private void loadCompanies()
        {
            string query = "SELECT name, address, owner_name, owner_nic_number, owner_mobile_number FROM WILDLIFE.COMPANY";

            connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    comboBoxCompany.Items.Add(dataReader.GetString("name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // The method to load company data from the database
        private void loadDrivers()
        {
            string query = "SELECT name, nic_number, mobile_number, address FROM WILDLIFE.DRIVER";

            connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    comboBoxCompany.Items.Add(dataReader.GetString("name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, errorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
