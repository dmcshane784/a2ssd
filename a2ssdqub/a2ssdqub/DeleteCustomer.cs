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
using a2ssdqub.Models; // ! //

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
            CustomerDAL.DeleteCustomer(int.Parse(comAllCus.SelectedValue.ToString()));

            // comAllCus.SelectedValue would give just the cusID
            MessageBox.Show("YOU HAVE JUST DELETED " + comAllCus.Text);

            // Refresh the combo box
            refreshCombo();
        }

        private void refreshCombo()
        {
            List<Customer> comboVals  = CustomerDAL.GetListOfCustomers();
            // null - binds 1 property of the comboVals to the comboBox, but we won't
            // to ensure both the key and value are available
            // instead of replacing it with "Key" or "Value"
            // as a Dictionary always has 1 of each
            comAllCus.DataSource = new BindingSource(comboVals,null);
            // These controls work on any other form field that only shows 1 value at a time
            //comAllCus.DisplayMember = "ToString"; // MAY BE IMPLICIT NOWADAYS
            comAllCus.ValueMember = "CusID";
        }
    }
}
