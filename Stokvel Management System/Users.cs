using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Stokvel_Management_System
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
           
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin myAdmin = new frmAdmin();
            this.Hide();
            myAdmin.FormClosed += (s, args) => this.Close();
            myAdmin.Show();
            myAdmin.Focus();
        }

        private void btnStokvel_Click(object sender, EventArgs e)
        {
            frmMember myMember = new frmMember();
            this.Hide();
            myMember.FormClosed += (s, args) => this.Close();
            myMember.Show();
            myMember.Focus();
        }

        private void btnProspective_Click(object sender, EventArgs e)
        {
            frmRequest myRequest = new frmRequest();
            this.Hide();
            myRequest.FormClosed += (s, args) => this.Close();
            myRequest.Show();
            myRequest.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        private void frmUsers_Load(object sender, EventArgs e)
        {
            
        }
    }
}
