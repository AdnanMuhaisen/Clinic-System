namespace Clinic_System
{
    partial class MedicalRecordsForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createNewMedicalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMedicalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMedicalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewMedicalRecordToolStripMenuItem,
            this.deleteMedicalRecordToolStripMenuItem,
            this.updateMedicalRecordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 103);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1372, 53);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createNewMedicalRecordToolStripMenuItem
            // 
            this.createNewMedicalRecordToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.createNewMedicalRecordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createNewMedicalRecordToolStripMenuItem.Name = "createNewMedicalRecordToolStripMenuItem";
            this.createNewMedicalRecordToolStripMenuItem.Size = new System.Drawing.Size(228, 49);
            this.createNewMedicalRecordToolStripMenuItem.Text = "Create New Medical Record";
            this.createNewMedicalRecordToolStripMenuItem.Click += new System.EventHandler(this.createNewMedicalRecordToolStripMenuItem_Click);
            // 
            // deleteMedicalRecordToolStripMenuItem
            // 
            this.deleteMedicalRecordToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteMedicalRecordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteMedicalRecordToolStripMenuItem.Name = "deleteMedicalRecordToolStripMenuItem";
            this.deleteMedicalRecordToolStripMenuItem.Size = new System.Drawing.Size(205, 49);
            this.deleteMedicalRecordToolStripMenuItem.Text = "Delete A Medical Record";
            this.deleteMedicalRecordToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // updateMedicalRecordToolStripMenuItem
            // 
            this.updateMedicalRecordToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.updateMedicalRecordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateMedicalRecordToolStripMenuItem.Name = "updateMedicalRecordToolStripMenuItem";
            this.updateMedicalRecordToolStripMenuItem.Size = new System.Drawing.Size(209, 49);
            this.updateMedicalRecordToolStripMenuItem.Text = "Update A Mediacl Record";
            this.updateMedicalRecordToolStripMenuItem.Click += new System.EventHandler(this.updateMedicalRecordToolStripMenuItem_Click);
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecords.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRecords.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewRecords.Location = new System.Drawing.Point(0, 250);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowHeadersWidth = 51;
            this.dataGridViewRecords.RowTemplate.Height = 26;
            this.dataGridViewRecords.Size = new System.Drawing.Size(1372, 474);
            this.dataGridViewRecords.TabIndex = 4;
            // 
            // MedicalRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 724);
            this.Controls.Add(this.dataGridViewRecords);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MedicalRecordsForm";
            this.Text = "Medical Records";
            this.Load += new System.EventHandler(this.MedicalRecordsForm_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.dataGridViewRecords, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createNewMedicalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMedicalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMedicalRecordToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
    }
}