using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using a2ssdqub.DAL; // >> ADD THIS IN TO 028Educate

namespace a2ssdqub
{
    public partial class AddNewCustomer : Form
    {
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (txtForename.Text != "" && datDob.Text != "" && checkedButton.Text != "")
            {
                int rowsAffected = CustomerDAL.AddNewCustomer(txtForename.Text, datDob.Text, checkedButton.Text);

                if(rowsAffected == 1)
                {
                    // ! // IDEALLY HERE WE WOULD REVEAL THE NEW CUSTOMER ID
                    MessageBox.Show(txtForename.Text + " has been successfully added");
                }
                else
                {
                    MessageBox.Show("ERROR: NO NEW CUSTOMER ADDED.  Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Program.mainM.Show();
        }
    }
}
