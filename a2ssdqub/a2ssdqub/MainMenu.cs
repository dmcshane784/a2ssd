using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a2ssdqub
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            Hide();
            AddNewCustomer addNewC = new AddNewCustomer();
            addNewC.Show();
        }

        private void btnDelCus_Click(object sender, EventArgs e)
        {
            Hide();
            DeleteCustomer delC = new DeleteCustomer();
            delC.Show();
        }
    }
}
