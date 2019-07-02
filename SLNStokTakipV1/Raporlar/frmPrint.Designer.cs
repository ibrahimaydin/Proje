namespace SLNStokTakipV1.Raporlar
{
    partial class frmPrint
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.crFirma = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.crFirma);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.txtbox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 645;
            this.splitContainer1.TabIndex = 0;
            // 
            // crFirma
            // 
            this.crFirma.ActiveViewIndex = -1;
            this.crFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crFirma.Cursor = System.Windows.Forms.Cursors.Default;
            this.crFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crFirma.Location = new System.Drawing.Point(0, 0);
            this.crFirma.Name = "crFirma";
            this.crFirma.Size = new System.Drawing.Size(641, 446);
            this.crFirma.TabIndex = 0;
            // 
            // txtbox
            // 
            this.txtbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbox.Enabled = false;
            this.txtbox.Location = new System.Drawing.Point(0, 0);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(147, 20);
            this.txtbox.TabIndex = 0;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crFirma;
        public System.Windows.Forms.TextBox txtbox;
    }
}