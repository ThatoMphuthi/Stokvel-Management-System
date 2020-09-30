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
    public partial class MemberDash : Form
    {
       
        public MemberDash()
        {
          
         
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ;
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void MemberDash_Load(object sender, EventArgs e)
        {
          
            txtReport.Text = Class1.MemberID;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
           
        }

        private void reportsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void feedbackAndSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Technical support  \nProgrammer:Litu Goniwe\nPhone :076 231 2762\nEmail: 27188183@student.g.nwu.ac.za", "HELP US IMPROVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers myUser = new frmUsers();
            this.Hide();

            myUser.Show();
            myUser.Focus();
        }

        private void announcemementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Announcements announce = new Announcements();
            announce.ShowDialog(this);
        }

        private void enquiriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enquries enquire = new Enquries();
            enquire.ShowDialog(this);
        }

        private void depositsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportDeposit report = new reportDeposit();
            report.ShowDialog(this);
        }

        private void loansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportLoans report = new ReportLoans();
            report.ShowDialog(this);
        }

        private void loanPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportPayments report = new ReportPayments();
            report.ShowDialog(this);
        }
    }
}
