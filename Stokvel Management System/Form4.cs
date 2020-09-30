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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        public string AdminCode { get; set; }
        OleDbConnection myDb;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text=="")
            {
                MessageBox.Show("Please enter your password", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {


                AdminCode = "Admin@" + (txtLast.Text).ToUpper() + (txtID.Text).Substring(0, 2);

                try
                {
                    myDb.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Administrator", myDb);
                    OleDbCommand sql = new OleDbCommand(@"insert into Administrator([AdminID],[First Name],[Last Name],[ID Number],[Gender],[Password]) values('" + AdminCode + "','" + txtFirst.Text + "','" + txtLast.Text + "','" + txtID.Text + "','" + cmbBxGender.SelectedItem + "','" + txtPassword.Text + "')", myDb);

                    adapter.InsertCommand = sql;

                    sql.ExecuteNonQuery();

                    MessageBox.Show(" Inserted Record.", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.None);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myDb.Close();
                }

                MessageBox.Show("Use  " + AdminCode + " as your username");

                frmAdmin myAdmin = new frmAdmin();
                this.Hide();
                myAdmin.FormClosed += (s, args) => this.Close();
                myAdmin.Show();
                myAdmin.Focus();
            }
        }
        private void back_Click(object sender, EventArgs e)
        {


            frmAdmin myAdmin = new frmAdmin();
            this.Hide();
            myAdmin.FormClosed += (s, args) => this.Close();
            myAdmin.Show();
            myAdmin.Focus();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            try
            {
                myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        { if(txtFirst.Text==""||txtLast.Text==""||txtID.Text==""||cmbBxGender.Text=="")
            {
                MessageBox.Show("Please enter all the details","STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            lblText.Text=  "Admin@" + (txtLast.Text).ToUpper() + (txtID.Text).Substring(0, 2);
            pictureBox1.Visible = true;
            }
         
        }
    }
}
