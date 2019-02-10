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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            // Let's open the driver registration form
            Driver driverForm = new Driver();
            driverForm.Show();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            // Let's open the company registration form
            Company companyForm = new Company();
            companyForm.Show();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            // Let's open the vehicle registration form
            Vehicle vehicleForm = new Vehicle();
            vehicleForm.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            // Let's open the ticket issue form
            Ticket ticketForm = new Ticket();
            ticketForm.Show();
        }
    }
}
