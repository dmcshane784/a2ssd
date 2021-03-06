﻿using System;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateCustomer updateC = new UpdateCustomer();
            updateC.Show();
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            Hide();
            frmAddNewReceipt addRec = new frmAddNewReceipt();
            addRec.Show();
        }
    }
}
