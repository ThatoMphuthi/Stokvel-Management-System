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
    public partial class Enquries : Form
    {
        public Enquries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");
            if (txtEnquire.Text == "")
            {
                MessageBox.Show("Please enter your enquiry!!");
                txtEnquire.Focus();
            }
            else
            {
                try
                {
                    myDb.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Announcements", myDb);
                    OleDbCommand sql = new OleDbCommand(@"insert into Announcements([Enquiries]) values('" + txtEnquire.Text + "')", myDb);

                    adapter.InsertCommand = sql;

                    sql.ExecuteNonQuery();

                    MessageBox.Show(" Enquiry sent to the Admin");
                    txtEnquire.Clear();


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
    }
}
