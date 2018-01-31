using a2ssdqub.DAL; // insert to be able to use DAL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using a2ssdqub.Models; // ! //

namespace a2ssdqub
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            // These controls work on any other form field that only shows 1 value at a time
            // lisCus.DisplayMember = "Value";
            lisCus.ValueMember = "CusID"; // we'll be using this from the Model
            lisCus.DisplayMember = ""; // thank you Stack OVerflow

            // Kick start the form
            RefreshListBox();

            // Populate the list first (as above)
            // ...then attach/assign the event handler
            lisCus.SelectedValueChanged += lisCus_SelectedValueChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Program.mainM.Show();
        }

        private void lisCus_SelectedValueChanged(object sender, EventArgs e)
        {
            lisCus.Enabled = false;
            btnUpdate.Enabled = true;
            lblCusID.Text = lisCus.SelectedValue.ToString();

            string[] lisCusData = CustomerDAL.GetCustomer((int) lisCus.SelectedValue);

            txtForename.Text = lisCusData[0];
            dtpDob.Text = lisCusData[1];

            /*
            // EPIC LINE OF CODE WITH EPIC NORMAL FORMATTING

            // this.Controls is all the controls
            // ofType isolates the RadioButtons
            // Where filters out that the text has to be equal to the contents of lisCusData[2]
            // and the last line just says check it (tick it/select it)
            var checkedButton = this.Controls.OfType<RadioButton>().
                First(r => r.Text == lisCusData[2].ToString()).Checked = true;

            */


            var checkedButton = panForm.Controls.OfType<RadioButton>().
                FirstOrDefault(r => r.Text == lisCusData[2]).Checked = true;

            /*
            switch(lisCusData[2])
            {
                case "Male": radMale.Select(); break;
                case "Female": radFemale.Select(); break;
                case "Undisclosed": radUndisclosed.Select(); break;
                case "Unknown": radUnknown.Select(); break;
                default: Console.WriteLine("go away"); break;
            }
             * */

            // Unhide the right-hand panel?
            panForm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // figure out which radio is selected NOW
            var genderChosen = panForm.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            Customer cusToUpdate = (Customer) lisCus.SelectedItem;
            cusToUpdate.Fname = txtForename.Text;
            cusToUpdate.Dob = dtpDob.Value;
            cusToUpdate.Sex = genderChosen.Text;
                
            // Customer cusToUpdate = new Customer(int.Parse(lisCus.SelectedValue.ToString()),"",new DateTime(),"NEEDS TO BE GIVEN A VALUE$$$");

            int rowsUpdated = CustomerDAL.UpdateCustomer(cusToUpdate);

            /*
            // Ternary operator version

            var label = rowsUpdated == 1 ? "Yeah that updated :-)" : "Baaaad news";
            MessageBox.Show(label);
            */

            if(rowsUpdated == 1)
            {
                MessageBox.Show("Yeah that updated :-)"); 
            }
            else
            {
                MessageBox.Show("Baaaad news");
            }

            // RESTORED TO INITIAL STATE
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            lisCus.DataSource = CustomerDAL.GetListOfCustomers();
            btnUpdate.Enabled = false;
            lisCus.Enabled = true;

            // Wipe the form
            lblCusID.Text = "";
            txtForename.Text = "";
            dtpDob.Text = "";

            foreach(var r in panForm.Controls.OfType<RadioButton>())
            {
                // iterates through all the RadioB on the panel
                r.Checked = false;
            }

            // Hide the right-hand panel?
            panForm.Visible = false;
                
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RefreshListBox();
        }
    }
}


/*
    // INITIAL STATE
    // disable the Update button until a selection is made in the ListBox
    btnUpdate.Enabled = false;
    lisCus.Enabled = true;

    Dictionary<int, string> liboxVals = CustomerDAL.GetListOfCustomers();
    // null - binds 1 property of the comboVals to the comboBox, but we won't
    // to ensure both the key and value are available
    // instead of replacing it with "Key" or "Value"
    // as a Dictionary always has 1 of each

    lisCus.DataSource = new BindingSource(liboxVals, null);
*/