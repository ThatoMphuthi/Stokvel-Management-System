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
    public partial class ReportPayments : Form
    {
        public ReportPayments()
        {
            InitializeComponent();
        }

        private void ReportPayments_Load(object sender, EventArgs e)
        {
            ReportsPay report = new ReportsPay();
            OleDbConnection myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");
            DataSet ds = new DataSet();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM LoanRepayments ", myDb);
            myAdapter.Fill(ds, "LoanRepayments");
            report.SetDataSource(ds.Tables["LoanRepayments"]);
            txtSummart.Text = Class1.MemberID;
            crystalReportViewer1.SelectionFormula = "{LoanRepayments.MembershipID}='" + txtSummart.Text + "'";
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Refresh();
        }
    }
}
