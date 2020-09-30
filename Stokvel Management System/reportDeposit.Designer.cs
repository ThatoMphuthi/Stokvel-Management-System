namespace Stokvel_Management_System
{
    partial class reportDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportDeposit));
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSummart = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDeposits1 = new Stokvel_Management_System.reportDeposits();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(12, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(200, 57);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Report for :";
            // 
            // txtSummart
            // 
            this.txtSummart.Location = new System.Drawing.Point(506, 7);
            this.txtSummart.Name = "txtSummart";
            this.txtSummart.ReadOnly = true;
            this.txtSummart.Size = new System.Drawing.Size(164, 20);
            this.txtSummart.TabIndex = 8;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 91);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.reportDeposits1;
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowExportButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(691, 377);
            this.crystalReportViewer1.TabIndex = 22;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ToolPanelWidth = 1055;
            // 
            // reportDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(707, 492);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtSummart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportDeposit";
            this.Text = "Deposits Report";
            this.Load += new System.EventHandler(this.reportDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSummart;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private reportDeposits reportDeposits1;
    }
}