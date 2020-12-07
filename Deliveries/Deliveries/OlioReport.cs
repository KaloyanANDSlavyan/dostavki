using System;
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
    public partial class OlioReport : Form
    {
        private DatabaseAccess dbAccess;
        public OlioReport()
        {
            InitializeComponent();
            dbAccess = new DatabaseAccess();
        }

        public void showOlioDeliveriesButtonAction(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            olioGridView.DataSource = dbAccess.queryOlio(date);
        }
    }
}
