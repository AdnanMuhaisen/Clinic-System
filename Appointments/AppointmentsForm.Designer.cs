namespace Clinic_System
{
    partial class AppointmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentsForm));
            this.panelFormHeader = new System.Windows.Forms.Panel();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAnAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormHeader
            // 
            this.panelFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panelFormHeader.Controls.Add(this.lblHeader1);
            this.panelFormHeader.Controls.Add(this.labelHeader);
            this.panelFormHeader.Controls.Add(this.pictureBoxHeader);
            this.panelFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormHeader.Location = new System.Drawing.Point(0, 0);
            this.panelFormHeader.Name = "panelFormHeader";
            this.panelFormHeader.Size = new System.Drawing.Size(1380, 103);
            this.panelFormHeader.TabIndex = 1;
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHeader1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeader1.Location = new System.Drawing.Point(594, 53);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(329, 33);
            this.lblHeader1.TabIndex = 2;
            this.lblHeader1.Text = "Appointments Management";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeader.Location = new System.Drawing.Point(682, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(129, 33);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "MediSync";
            // 
            // pictureBoxHeader
            // 
            this.pictureBoxHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHeader.Image = global::Clinic_System.Properties.Resources.Photo;
            this.pictureBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHeader.Name = "pictureBoxHeader";
            this.pictureBoxHeader.Size = new System.Drawing.Size(191, 103);
            this.pictureBoxHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeader.TabIndex = 0;
            this.pictureBoxHeader.TabStop = false;
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToAddRows = false;
            this.dataGridViewAppointments.AllowUserToDeleteRows = false;
            this.dataGridViewAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewAppointments.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(0, 212);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.ReadOnly = true;
            this.dataGridViewAppointments.RowHeadersWidth = 51;
            this.dataGridViewAppointments.RowTemplate.Height = 26;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1380, 461);
            this.dataGridViewAppointments.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAppointmentToolStripMenuItem,
            this.deleteAnAppointmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 103);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1380, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewAppointmentToolStripMenuItem
            // 
            this.addNewAppointmentToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addNewAppointmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewAppointmentToolStripMenuItem.Name = "addNewAppointmentToolStripMenuItem";
            this.addNewAppointmentToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.addNewAppointmentToolStripMenuItem.Text = "Add New Appointment";
            this.addNewAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addNewAppointmentToolStripMenuItem_Click);
            // 
            // deleteAnAppointmentToolStripMenuItem
            // 
            this.deleteAnAppointmentToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteAnAppointmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteAnAppointmentToolStripMenuItem.Name = "deleteAnAppointmentToolStripMenuItem";
            this.deleteAnAppointmentToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.deleteAnAppointmentToolStripMenuItem.Text = "Delete An Appointment";
            this.deleteAnAppointmentToolStripMenuItem.Click += new System.EventHandler(this.deleteAnAppointmentToolStripMenuItem_Click);
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1380, 673);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelFormHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentsForm";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            this.panelFormHeader.ResumeLayout(false);
            this.panelFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFormHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxHeader;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAnAppointmentToolStripMenuItem;
    }
}