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
using System.Threading;

namespace Stokvel_Management_System
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            
        }
        OleDbConnection myDb;
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmUsers myUser = new frmUsers();
            this.Hide();
            myUser.FormClosed += (s, args) => this.Close();
            myUser.Show();
            myUser.Focus();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
           frmSignUp mySign = new frmSignUp();
            mySign.ShowDialog(this);
            txtUsername.Text = mySign.AdminCode;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {if (txtPassword.Text == "" || txtUsername.Text == "")
            {

                MessageBox.Show("Please enter username and password", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    myDb.Open();
                    OleDbCommand command = new OleDbCommand("select * from Administrator  where AdminID ='" + txtUsername.Text + "'and password='" + txtPassword.Text + "'", myDb);
                    OleDbDataReader myReader = command.ExecuteReader();
                    int count = 0;
                    while (myReader.Read() == true)
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        Thread t = new Thread(new ThreadStart(startForm));
                        t.Start();
                        Thread.Sleep(5000);
                        t.Abort();
                        this.Hide();
                        Form6 mySign = new Form6();

                        mySign.FormClosed += (s, args) => this.Close();
                        mySign.Show();
                        mySign.Focus();

                    }
                    else if (count > 1)
                    {
                        MessageBox.Show("Duplicate Username and Password correct");

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username and Password");
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


           
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        public void startForm()
        {
            Application.Run(new LoginSplashcs());
        }
    }
}
