using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // used for radio button, a fluent API
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
            // Quickest, most efficient way to do it; uses Linq
            // FirstOrDef takes IEnumerable and returns an instance of IEnumerable???
            // Tries to keep the IEnumerable alive as long as possible to chain it to other functions
            // Iterates through and checks which are of type RadioButton
            // Checks where the Checked property is true
            // FirstOrDefault - pins it to one value, a reducing function
            // Microsoft are v proud of Linq and have written it for almost any data set out there
            // They started a project Linq To SQL, so you could just know Linq not SQL
            var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (txtForename.Text != "" && datDob.Text != "" && checkedButton.Text != "")
            {
                int newlyMadeID = CustomerDAL.AddNewCustomer(txtForename.Text, datDob.Text, checkedButton.Text);

                if(newlyMadeID > -1)
                {
                    // ! // IDEALLY HERE WE WOULD REVEAL THE NEW CUSTOMER ID
                    MessageBox.Show(txtForename.Text + " has been successfully added, with Customer ID " + newlyMadeID);
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
