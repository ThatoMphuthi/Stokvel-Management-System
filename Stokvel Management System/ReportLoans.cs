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
    public partial class ReportLoans : Form
    {
        public ReportLoans()
        {
            InitializeComponent();
        }

        private void ReportLoans_Load(object sender, EventArgs e)
        {
           reportLoans report = new reportLoans();
            OleDbConnection myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");
            DataSet ds = new DataSet();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Loans ", myDb);
            myAdapter.Fill(ds, "Loans");
            report.SetDataSource(ds.Tables["Loans"]);
            txtSummart.Text = Class1.MemberID;
            crystalReportViewer1.SelectionFormula = "{Loans.MembershipID}='" + txtSummart.Text + "'";
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Refresh();
        }
    }
}
