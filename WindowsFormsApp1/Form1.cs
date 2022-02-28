using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerManager _customerManager = new CustomerManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            ListCustomers();

        }

        private void ListCustomers()
        {
            dtgCustomers.DataSource = null;
            dtgCustomers.DataSource = _customerManager.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            _customerManager.Add(new Customer
            {
                Id = Convert.ToInt32(txtId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Email = txtEmail.Text,
            });
            ListCustomers();
        }
    }
}
