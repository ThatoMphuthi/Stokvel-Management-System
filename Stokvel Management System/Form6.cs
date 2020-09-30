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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        OleDbConnection myDb;

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
         
           
        }

        private void btnEdit_MouseClick(object sender, MouseEventArgs e)
        {
            frmUpdate myUpdate = new frmUpdate();
            myUpdate.ShowDialog(this);
        }

        private void btnDelete_MouseClick(object sender, MouseEventArgs e)
        {
            frmDelete myDelete = new frmDelete();
            myDelete.ShowDialog(this);
        }

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            frmAdmin myAdmin = new frmAdmin();
            this.Hide();
            myAdmin.FormClosed += (s, args) => this.Close();
            myAdmin.Show();
            myAdmin.Focus();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            btnReportCreate.Enabled = false;
            try
            {
                myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");
                DataSet ds = new DataSet();
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Members", myDb);
                myAdapter.Fill(ds, "List");
                cmbMemberId.ValueMember = "MembershipID";
                cmbBxRepayM.ValueMember = "MembershipID";
                cmbBxRepayM.DataSource = ds.Tables["List"];
                cmbMemberId.DataSource = ds.Tables["List"];
                cmbId.ValueMember = "MembershipID";    
                cmbId.DataSource = ds.Tables["List"];
               
                MembersdataGridVaiew1.DataSource = ds;
                MembersdataGridVaiew1.DataMember = "List";

                comboBox2.ValueMember = "MembershipID";
                comboBox2.DataSource = ds.Tables["List"];
                comboBox3.ValueMember = "MembershipID";
                comboBox3.DataSource = ds.Tables["List"];
                comboBox4.ValueMember = "MembershipID";
                comboBox4.DataSource = ds.Tables["List"];


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           


            try
            {
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Members", myDb);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, "List");
                MembersdataGridVaiew1.DataSource = ds;
                MembersdataGridVaiew1.DataMember = "List";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM MembershipRequest", myDb);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, "List");
                RequestdataGridView5.DataSource = ds;
                RequestdataGridView5.DataMember = "List";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            try
            {
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Loans", myDb);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, "List");
                LoandataGridView3.DataSource = ds;
                LoandataGridView3.DataMember = "List";
                cmbRepayID.ValueMember = "LoanID";
                cmbRepayID.DataSource = ds.Tables["List"];
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM LoanRepayments", myDb);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, "List");
                RepaydataGridView4.DataSource = ds;
                RepaydataGridView4.DataMember = "List";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


          

            
            try
            {
                
                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Deposits", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                DepositdataGridView2.DataSource = ds;
                DepositdataGridView2.DataMember = "List";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DateTime datetime = DateTime.Today;
            monthCalendar1.ShowToday.ToString();
            lblDate.Text = datetime.ToShortDateString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd myAdd = new frmAdd();
            myAdd.ShowDialog(this);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Members", myDb);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, "List");
                MembersdataGridVaiew1.DataSource = ds;
                MembersdataGridVaiew1.DataMember = "List";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
           
        }
        public void TextClear()
        {
            
            txtLoanAmount.Clear();
            
            txtLoanerLast.Clear();
            txtLoanerName.Clear();

            
            txtRepayerLastName.Clear();
            txtRepayerName.Clear();
            txtSettleAmount.Clear();

            txtFirst.Clear();
            txtLast.Clear();
            txtAmount.Clear();

        }
         
        private void tabPage5_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM LoanRepayments", myDb);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, "List");
                RepaydataGridView4.DataSource = ds;
                RepaydataGridView4.DataMember = "List";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            double interest = 0.1;
            double amount = double.Parse(txtLoanAmount.Text);
            double due = amount + (amount * interest);
            if (txtLoanAmount.Text == "")
            {
                MessageBox.Show(" Please enter Loan amount", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoanAmount.Focus();
            }
            else
            {
                try
                {
                    myDb.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Loans", myDb);
                    OleDbCommand sql = new OleDbCommand(@"INSERT INTO Loans([MembershipID],[First Name],[Last Name],[Loan Amount],[Date]) VALUES('" + cmbId.SelectedValue + "','" + txtLoanerName.Text + "','" + txtLoanerLast.Text + "'," + due + ",'" + dateTimePicker1.Text + "')", myDb);
                    adapter.InsertCommand = sql;
                    adapter.InsertCommand.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "List");
                    LoandataGridView3.DataSource = ds;
                    LoandataGridView3.DataMember = "List";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myDb.Close();
                }
                MessageBox.Show("Loan successful", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextClear();
            }
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text=="")
            {
                MessageBox.Show("Please enter amount to be deposited ","STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAmount.Focus();
            }
            else
            {
                try
                {
                    myDb.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Deposits", myDb);
                    OleDbCommand sql = new OleDbCommand(@"INSERT INTO Deposits([MembershipID],[First Name],[Last Name],[Deposit Amount],[Date]) VALUES('" + cmbMemberId.SelectedValue + "','" + txtFirst.Text + "','" + txtLast.Text + "'," + txtAmount.Text + ",'" + dateTimePicker3.Text + "')", myDb);
                    adapter.InsertCommand = sql;
                    adapter.InsertCommand.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "List");
                    DepositdataGridView2.DataSource = ds;
                    DepositdataGridView2.DataMember = "List";




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myDb.Close();
                }
                MessageBox.Show("Money has been deposited", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextClear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSettleAmount.Text =="")
            {
                MessageBox.Show("Please enter Amount Paid", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSettleAmount.Focus();
            }
            else
            {
                try
                {
                    myDb.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM LoanRepayments", myDb);
                    OleDbCommand sql = new OleDbCommand(@"INSERT INTO LoanRepayments([MembershipID],[Loan ID],[First Name],[Last Name],[Payment Amount],[Date]) VALUES('" + cmbBxRepayM.SelectedValue + "'," + cmbRepayID.SelectedValue + ",'" + txtRepayerName.Text + "','" + txtRepayerLastName.Text + "'," + txtSettleAmount.Text + ",'" + dateTimePicker2.Text + "')", myDb);
                    adapter.InsertCommand = sql;
                    adapter.InsertCommand.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "List");
                    RepaydataGridView4.DataSource = ds;
                    RepaydataGridView4.DataMember = "List";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myDb.Close();
                }
                MessageBox.Show("Loan has been settled", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextClear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtLoanAmount.Text=="")
            {
                MessageBox.Show("Please enter Loan Amount ", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoanAmount.Focus();
            }
            else
            {
                double interest = 0.1;
            double amount = double.Parse(txtLoanAmount.Text);
            double due = amount + (amount * interest);
            label5.Text = "R " + due.ToString();
            btnLoan.Visible = true;
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Members  WHERE FirstName like '" + txtSearch.Text + "%'", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                MembersdataGridVaiew1.DataSource = ds;
                MembersdataGridVaiew1.DataMember = "List";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Deposits  WHERE MembershipID like '" + comboBox2.SelectedValue + "%'", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
               DepositdataGridView2.DataSource = ds;
          DepositdataGridView2.DataMember = "List";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Deposits  ", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                DepositdataGridView2.DataSource = ds;
                DepositdataGridView2.DataMember = "List";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Loans  WHERE MembershipID like '" + comboBox3.SelectedValue + "%'", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                LoandataGridView3.DataSource = ds;
               LoandataGridView3.DataMember = "List";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Loans ", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                LoandataGridView3.DataSource = ds;
                LoandataGridView3.DataMember = "List";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        { try
           {

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM LoanRepayments  WHERE MembershipID like '" + comboBox4.SelectedValue + "%'", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                RepaydataGridView4.DataSource = ds;
              RepaydataGridView4.DataMember = "List";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM  LoanRepayments  ", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                RepaydataGridView4.DataSource = ds;
                RepaydataGridView4.DataMember = "List";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");
                DataSet ds = new DataSet();
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Members", myDb);
                myAdapter.Fill(ds, "List");
                cmbMemberId.ValueMember = "MembershipID";
                cmbBxRepayM.ValueMember = "MembershipID";
                cmbBxRepayM.DataSource = ds.Tables["List"];
                cmbMemberId.DataSource = ds.Tables["List"];
                cmbId.ValueMember = "MembershipID";
                cmbId.DataSource = ds.Tables["List"];

                MembersdataGridVaiew1.DataSource = ds;
                MembersdataGridVaiew1.DataMember = "List";

                comboBox2.ValueMember = "MembershipID";
                comboBox2.DataSource = ds.Tables["List"];
                comboBox3.ValueMember = "MembershipID";
                comboBox3.DataSource = ds.Tables["List"];
                comboBox4.ValueMember = "MembershipID";
                comboBox4.DataSource = ds.Tables["List"];


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            try
            {
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Members", myDb);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, "List");
                MembersdataGridVaiew1.DataSource = ds;
                MembersdataGridVaiew1.DataMember = "List";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            try
            {
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Loans", myDb);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, "List");
                LoandataGridView3.DataSource = ds;
                LoandataGridView3.DataMember = "List";
                cmbRepayID.ValueMember = "LoanID";
                cmbRepayID.DataSource = ds.Tables["List"];
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM LoanRepayments", myDb);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, "List");
                RepaydataGridView4.DataSource = ds;
                RepaydataGridView4.DataMember = "List";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            try
            {

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Deposits", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                DepositdataGridView2.DataSource = ds;
                DepositdataGridView2.DataMember = "List";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Database Refreshed","STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmUsers myUser = new frmUsers();
            this.Hide();
          
            myUser.Show();
            myUser.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            chkLoans.Checked = false;
            chkMembers.Checked = false;
            btnReportCreate.Visible = true;
            chkPayments.Checked = false;
            btnReportCreate.Enabled = true;
            
        }

        private void chkLoans_CheckedChanged(object sender, EventArgs e)
        {
            chkdeposits.Checked = false;
            btnReportCreate.Enabled = true;
            chkMembers.Checked = false;
            btnReportCreate.Visible = true;
            chkPayments.Checked = false;
        }

        private void chkOutstanding_CheckedChanged(object sender, EventArgs e)
        {
            chkdeposits.Checked = false;
            chkLoans.Checked = false;
            chkMembers.Checked = false;
            btnReportCreate.Enabled = true;
            chkPayments.Checked = false;
            btnReportCreate.Visible = true;
        }

        private void chkPayments_CheckedChanged(object sender, EventArgs e)
        {
            chkdeposits.Checked = false;
            chkLoans.Checked = false;
            chkMembers.Checked = false;
            btnReportCreate.Visible = true;
            btnReportCreate.Enabled = true;
        }

        private void chkMembers_CheckedChanged(object sender, EventArgs e)
        { 
            chkdeposits.Checked = false;
            chkLoans.Checked = false;
            btnReportCreate.Enabled = true;
            btnReportCreate.Visible = true;
            chkPayments.Checked = false;
        }

        private void btnReportCreate_Click(object sender, EventArgs e)
        {
            if(chkMembers.Checked)
            {
                MembersReport myMember = new MembersReport();
                myMember.ShowDialog(this);
              


            }
            else
            if (chkdeposits.Checked)
            {
               DepositsReports myDeposits = new DepositsReports();
                myDeposits.ShowDialog(this);
            }
           
         
            else
            if (chkPayments.Checked)
            {
               PaymentsReports myPayments = new PaymentsReports();
                myPayments.ShowDialog(this);
            }
            else
            if (chkLoans.Checked)
            {
                LoansReport myReports = new LoansReport();
                myReports.ShowDialog(this);
            }
           

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        { if (textBox1.Text == "")
            {
                MessageBox.Show(" Please enter your Enquiry", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Focus();
            }
            else
            {
                try
                {
                    myDb.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Announcements", myDb);
                    OleDbCommand sql = new OleDbCommand(@"insert into Announcements([Announcements]) values('" + textBox1.Text + "')", myDb);

                    adapter.InsertCommand = sql;

                    sql.ExecuteNonQuery();

                    MessageBox.Show(" Message was Sent to the Users");
                    textBox1.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myDb.Close();
                }
            }
        }

        private void cmbMemberId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                myDb.Open();
                string select = @"SELECT * FROM Members where MembershipID='" + cmbMemberId.SelectedValue.ToString() + "'";
                OleDbCommand cmd = new OleDbCommand(select, myDb);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtFirst.Text = (dr["FirstName"].ToString());
                    txtLast.Text = (dr["Last Name"].ToString());

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                myDb.Close();
            }
        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                myDb.Open();
                string select = @"SELECT * FROM Members where MembershipID='" + cmbId.SelectedValue.ToString() + "'";
                OleDbCommand cmd = new OleDbCommand(select, myDb);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtLoanerName.Text = (dr["FirstName"].ToString());
                    txtLoanerLast.Text = (dr["Last Name"].ToString());

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                myDb.Close();
            }
        }

        private void cmbBxRepayM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                myDb.Open();
                string select = @"SELECT * FROM Members where MembershipID='" + cmbBxRepayM.SelectedValue.ToString() + "'";
                OleDbCommand cmd = new OleDbCommand(select, myDb);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtRepayerName.Text = (dr["FirstName"].ToString());
                    txtRepayerLastName.Text = (dr["Last Name"].ToString());

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                myDb.Close();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Technical support : \nProgrammer:Litu Goniwe\nPhone :076 231 2762\nEmail: 27188183@student.g.nwu.ac.za", "HELP US IMPROVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog(this);
        }
    }

    
    }

        

