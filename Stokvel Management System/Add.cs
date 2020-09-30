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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        OleDbConnection myDb;
        String MemberCode { get; set;}
        public void TextClear()
        {
            txtAccount.Clear();
            txtAddress.Clear();
            txtBankName.Clear();
            txtCode.Clear();
          
            txtFirst.Clear();
            txtID.Clear();
            txtLast.Clear();
            txtNumber.Clear();
            txtPassword.Clear();
            txtTown.Clear();
            
            




        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin myAdmin = new frmAdmin();
            this.Hide();
            myAdmin.FormClosed += (s, args) => this.Close();
            myAdmin.Show();
            myAdmin.Focus();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            try
            {
                myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemberCode = "Stokvel@" + (txtLast.Text).ToUpper() + (txtID.Text).Substring(0, 2);
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    myDb.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Members", myDb);
                    OleDbCommand sql = new OleDbCommand(@"INSERT INTO Members([MembershipID],[FirstName],[Last Name],[Date of Birth],[ID Number],[Gender],[Phone]
,[Account Number],[Bank Name],[Address],[Town],[Postal Code],[Password]) VALUES('" + MemberCode + "','" + txtFirst.Text + "','" + txtLast.Text + "','" + dateTimePicker2.Text + "','" + txtID.Text + "','" + cmbBxGender.SelectedItem + "','" + txtNumber.Text + "','" + txtAccount.Text + "','" + txtBankName.Text + "','" + txtAddress.Text + "','" + txtTown.Text + "','" + txtCode.Text + "','" + txtPassword.Text + "')", myDb);
                    adapter.InsertCommand = sql;
                    adapter.InsertCommand.ExecuteNonQuery();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myDb.Close();
                }
                MessageBox.Show(MemberCode + " " + "Has been addded to the stokvel","STOKVEL MANAGEMNT SYSTEM");
                TextClear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {      if (txtFirst.Text == "" || txtLast.Text == "" || txtID.Text==""||cmbBxGender.Text==""||txtNumber.Text==""||txtAccount.Text==""||txtBankName.Text==""||txtAddress.Text==""||txtTown.Text==""||txtCode.Text=="")
            {
                MessageBox.Show("Please enter all your details", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            label4.Text = "Stokvel@" + (txtLast.Text).ToUpper() + (txtID.Text).Substring(0, 2);
            btnAdd.Visible = true;
            }
            
        }
    }
}
