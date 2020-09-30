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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }
        int selectedRow;
        OleDbConnection myDb;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdmin myAdmin = new frmAdmin();
            this.Hide();
            myAdmin.FormClosed += (s, args) => this.Close();
            myAdmin.Show();
            myAdmin.Focus();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                myDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Stokvel Database.accdb");
                DataSet ds = new DataSet();
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(@"SELECT * FROM Members", myDb);
                myAdapter.Fill(ds, "List");
                UpdatedataGridView1.DataSource = ds;
                UpdatedataGridView1.DataMember = "List";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {  selectedRow=e.RowIndex;
            DataGridViewRow row = UpdatedataGridView1.Rows[selectedRow];
            txtAccountNr.Text =row.Cells[7].Value.ToString();
            txtAddress.Text = row.Cells[9].Value.ToString();
            txtBankName.Text = row.Cells[8].Value.ToString();
            txtCode.Text = row.Cells[11].Value.ToString();
            txtDOB.Text = row.Cells[3].Value.ToString();
            txtFirst.Text = row.Cells[1].Value.ToString();
            txtID.Text = row.Cells[4].Value.ToString();
            txtLast.Text = row.Cells[2].Value.ToString();
            txtPhone.Text = row.Cells[6].Value.ToString();
            txtPassword.Text = row.Cells[12].Value.ToString();
            txtTown.Text = row.Cells[10].Value.ToString();
            txtUsername.Text = row.Cells[0].Value.ToString();
            cmbBxGender.SelectedItem= row.Cells[5].Value.ToString();
        }
        public void TextClear()
        {
            txtAccountNr.Clear();
            txtAddress.Clear();
            txtBankName.Clear();
            txtCode.Clear();
            txtDOB.Clear();
            txtFirst.Clear();
            txtID.Clear();
            txtLast.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            txtTown.Clear();
            txtUsername.Clear();





        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = UpdatedataGridView1.Rows[selectedRow];
            row.Cells[7].Value = txtAccountNr.Text;
            row.Cells[9].Value = txtAddress.Text;
            row.Cells[8].Value = txtBankName.Text;
            row.Cells[11].Value = txtCode.Text;
            row.Cells[3].Value = txtDOB.Text;
            row.Cells[1].Value = txtFirst.Text;
            row.Cells[4].Value = txtID.Text;
            row.Cells[2].Value = txtLast.Text;
            row.Cells[6].Value = txtPhone.Text;
            row.Cells[12].Value = txtPassword.Text;
            row.Cells[10].Value = txtTown.Text;
            row.Cells[0].Value = txtUsername.Text;
            row.Cells[5].Value = cmbBxGender.SelectedText;
            MessageBox.Show("Information Updated");
            TextClear();
        }
    }
}
