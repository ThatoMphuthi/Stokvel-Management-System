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
    public partial class frmDelete : Form
    {
        OleDbConnection myDb;
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdmin myAdmin = new frmAdmin();
            this.Hide();
            myAdmin.FormClosed += (s, args) => this.Close();
            myAdmin.Show();
            myAdmin.Focus();
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            try
            {
                myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");
                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Members", myDb);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                DeletedataGridView1.DataSource = ds;
                DeletedataGridView1.DataMember = "List";
                cmbBxID.ValueMember = "MembershipID";
                cmbBxID.DataSource = ds.Tables["List"];


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                myDb.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Members", myDb);
                OleDbCommand sql = new OleDbCommand(@"DELETE FROM Members WHERE MembershipID='" + cmbBxID.SelectedValue + "'", myDb);
                adapter.DeleteCommand = sql;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                DeletedataGridView1.DataSource = ds;
                DeletedataGridView1.DataMember = "List";
                

                int number = adapter.DeleteCommand.ExecuteNonQuery();
                if (number > 0)
                    MessageBox.Show("Deleted" + number + " Record(s).");
                else
                    MessageBox.Show("No matching records");
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
