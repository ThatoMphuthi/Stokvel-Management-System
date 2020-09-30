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
    public partial class frmMember : Form
    {

      public string username { get; set; }
    OleDbConnection    myDb;
        public frmMember()
        {
            InitializeComponent();
            
        }
    
        private void btnBack_Click(object sender, EventArgs e)
        { 


            username = txtUsername.Text;
           
            frmUsers myUser = new frmUsers();
            this.Hide();
           
            myUser.Show();
            myUser.Focus();
        }
        private void frmMember_Load(object sender, EventArgs e)
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Class1.MemberID = txtUsername.Text;
            


               if (txtPassword.Text==""||txtUsername.Text=="")
               {
                   MessageBox.Show("Please enter your Username or Password", "STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
               else
               {

                   try
                   {
                       myDb.Open();
                       OleDbCommand command = new OleDbCommand(@"select * from Members where  MembershipID= '" + txtUsername.Text + "'and Password='" + txtPassword.Text + "'", myDb);

                       OleDbDataReader myReader = command.ExecuteReader();
                       int count = 0;
                       while (myReader.Read())
                       {
                           count++;
                       }
                       if (count == 1)
                       {


                           MemberDash myMemberDash = new MemberDash();
                           this.Hide();
                           myMemberDash.FormClosed += (s, args) => this.Close();
                           myMemberDash.Show();
                           myMemberDash.Focus();

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
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
           
        }
    }
}
