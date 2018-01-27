using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using a2ssdqub.DAL;

namespace a2ssdqub
{
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();

        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            refreshCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Program.mainM.Show();
        }

        private void btnDelCus_Click(object sender, EventArgs e)
        {
            // Select the customer ID from the combo box first
            string customerID = comAllCus.Text;
            string[] substr = customerID.Split(',');

            // ...then delete them
            CustomerDAL.DeleteCustomer(int.Parse(substr[0]));

            MessageBox.Show("YOU HAVE JUST DELETED " + substr[1]);

            // Refresh the combo box
            refreshCombo();
        }

        private void refreshCombo()
        {
            comAllCus.DataSource = CustomerDAL.GetListOfCustomers();
        }
    }
}
