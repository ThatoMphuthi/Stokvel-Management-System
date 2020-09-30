using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Stokvel_Management_System
{
    public partial class reportDeposit : Form
    {
        public reportDeposit()
        {
            InitializeComponent();
        }

        private void reportDeposit_Load(object sender, EventArgs e)
        {
          reportDeposits   report = new reportDeposits();
            OleDbConnection myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");
            DataSet ds = new DataSet();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Deposits ", myDb);
            myAdapter.Fill(ds, "Deposits");
            report.SetDataSource(ds.Tables["Deposits"]);
            txtSummart.Text = Class1.MemberID;
            crystalReportViewer1.SelectionFormula = "{Deposits.MembershipID}='" + txtSummart.Text + "'";
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Refresh();
        }
    }
}
