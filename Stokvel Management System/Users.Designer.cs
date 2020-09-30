namespace Stokvel_Management_System
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnStokvel = new System.Windows.Forms.Button();
            this.btnProspective = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(86, 118);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(156, 58);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnStokvel
            // 
            this.btnStokvel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStokvel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStokvel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStokvel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokvel.Location = new System.Drawing.Point(86, 182);
            this.btnStokvel.Name = "btnStokvel";
            this.btnStokvel.Size = new System.Drawing.Size(156, 61);
            this.btnStokvel.TabIndex = 1;
            this.btnStokvel.Text = "Stokvel Member";
            this.btnStokvel.UseVisualStyleBackColor = false;
            this.btnStokvel.Click += new System.EventHandler(this.btnStokvel_Click);
            // 
            // btnProspective
            // 
            this.btnProspective.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProspective.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProspective.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProspective.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProspective.Location = new System.Drawing.Point(86, 249);
            this.btnProspective.Name = "btnProspective";
            this.btnProspective.Size = new System.Drawing.Size(156, 67);
            this.btnProspective.TabIndex = 2;
            this.btnProspective.Text = "Prospective Member";
            this.btnProspective.UseVisualStyleBackColor = false;
            this.btnProspective.Click += new System.EventHandler(this.btnProspective_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(138, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(135, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "LOGOUT";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(322, 430);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProspective);
            this.Controls.Add(this.btnStokvel);
            this.Controls.Add(this.btnAdmin);
            this.ForeColor = System.Drawing.Color.OldLace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnStokvel;
        private System.Windows.Forms.Button btnProspective;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
    }
}

