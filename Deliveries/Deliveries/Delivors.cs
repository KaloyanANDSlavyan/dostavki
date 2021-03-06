﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveries
{
    public partial class Delivors : Form
    {
        private DatabaseAccess dbAccess;

        public Delivors()
        {
            InitializeComponent();
            dbAccess = new DatabaseAccess();
        }

        private void delivorAddButton_Click(object sender, EventArgs e)
        {
            Delivor delivor = new Delivor();

            delivor.CompanyName = companyNameField.Text;
            delivor.Address = addressField.Text;
            delivor.PhoneNumber = phoneField.Text;
            delivor.EmployeeContact = employeeField.Text;

            dbAccess.insertDelivor(delivor);
        }

        private void outStocksForDelivorButton_Click(object sender, EventArgs e)
        {
            ShowDeliveredStocks showDeliveredStocks = new ShowDeliveredStocks();
            showDeliveredStocks.Show();
        }
    }
}
