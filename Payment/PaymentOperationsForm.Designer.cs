namespace Clinic_System.Payment
{
    partial class PaymentOperationsForm
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
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdateBillDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteABill = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBills
            // 
            this.dataGridViewBills.AllowUserToAddRows = false;
            this.dataGridViewBills.AllowUserToDeleteRows = false;
            this.dataGridViewBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBills.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBills.Location = new System.Drawing.Point(0, 259);
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.ReadOnly = true;
            this.dataGridViewBills.RowHeadersWidth = 51;
            this.dataGridViewBills.RowTemplate.Height = 26;
            this.dataGridViewBills.Size = new System.Drawing.Size(1396, 480);
            this.dataGridViewBills.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBillToolStripMenuItem,
            this.toolStripMenuItemUpdateBillDetails,
            this.toolStripMenuItemDeleteABill});
            this.menuStrip1.Location = new System.Drawing.Point(0, 103);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1396, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newBillToolStripMenuItem
            // 
            this.newBillToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.newBillToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newBillToolStripMenuItem.Name = "newBillToolStripMenuItem";
            this.newBillToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.newBillToolStripMenuItem.Text = "New Bill";
            this.newBillToolStripMenuItem.Click += new System.EventHandler(this.newBillToolStripMenuItem_Click);
            // 
            // toolStripMenuItemUpdateBillDetails
            // 
            this.toolStripMenuItemUpdateBillDetails.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItemUpdateBillDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemUpdateBillDetails.Name = "toolStripMenuItemUpdateBillDetails";
            this.toolStripMenuItemUpdateBillDetails.Size = new System.Drawing.Size(160, 28);
            this.toolStripMenuItemUpdateBillDetails.Text = "Update Bill Details";
            this.toolStripMenuItemUpdateBillDetails.Click += new System.EventHandler(this.toolStripMenuItemUpdateBillDetails_Click);
            // 
            // toolStripMenuItemDeleteABill
            // 
            this.toolStripMenuItemDeleteABill.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItemDeleteABill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemDeleteABill.Name = "toolStripMenuItemDeleteABill";
            this.toolStripMenuItemDeleteABill.Size = new System.Drawing.Size(114, 28);
            this.toolStripMenuItemDeleteABill.Text = "Delete A Bill";
            this.toolStripMenuItemDeleteABill.Click += new System.EventHandler(this.toolStripMenuItemDeleteABill_Click);
            // 
            // PaymentOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 739);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewBills);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaymentOperationsForm";
            this.Text = "PaymentOperationsForm";
            this.Load += new System.EventHandler(this.PaymentOperationsForm_Load);
            this.Controls.SetChildIndex(this.dataGridViewBills, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdateBillDetails;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteABill;
    }
}