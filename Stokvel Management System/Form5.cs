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
    public partial class frmRequest : Form
    {
        public frmRequest()
        {
            InitializeComponent();
        }
        OleDbConnection myDb;

        private void back_Click(object sender, EventArgs e)
        {
            frmUsers myUser = new frmUsers();
            this.Hide();
            myUser.FormClosed += (s, args) => this.Close();
            myUser.Show();
            myUser.Focus();
        }
        private void frmRequest_Load(object sender, EventArgs e)
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

        private void btnRRequest_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text==""||txtLast.Text==""||txtNumber.Text==""||cmbBxGender.Text=="")
            {
                MessageBox.Show("Please enter your details","STOKVEL MANAGEMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {
                try
                {
                    myDb.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM MembershipRequest", myDb);

                    OleDbCommand sql = new OleDbCommand(@"insert into MembershipRequest([First Name],[Last Name],[Phone],[Gender]) values('" + txtFirst.Text + "','" + txtLast.Text + "','" + txtNumber.Text + "','" + cmbBxGender.SelectedItem + "')", myDb);
                    adapter.InsertCommand = sql;

                    sql.ExecuteNonQuery();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myDb.Close();
                }
                MessageBox.Show("Thank you for your intereset ! \nThe admin will contact your soon");
                frmUsers myUser = new frmUsers();
                this.Hide();
                myUser.FormClosed += (s, args) => this.Close();
                myUser.Show();
                myUser.Focus();
            }


        }
    }
}
