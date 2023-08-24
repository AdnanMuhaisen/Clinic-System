namespace Clinic_System
{
    partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timerUpdateTime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMedicalRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPaymentOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.lblLastTransactionContent = new System.Windows.Forms.Label();
            this.lblLastTransaction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotificationContent = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.timerForAppointmentsChecking = new System.Windows.Forms.Timer(this.components);
            this.panelFormHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
            this.panelDateTime.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDateTime
            // 
            this.panelDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDateTime.Controls.Add(this.lblTime);
            this.panelDateTime.Controls.Add(this.lblDate);
            this.panelDateTime.Location = new System.Drawing.Point(1026, 109);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(322, 147);
            this.panelDateTime.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(26, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 33);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(26, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 33);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // timerUpdateTime
            // 
            this.timerUpdateTime.Enabled = true;
            this.timerUpdateTime.Interval = 1000;
            this.timerUpdateTime.Tick += new System.EventHandler(this.timerUpdateTime_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.toolStripMenuItemDoctors,
            this.toolStripMenuItemAppointments,
            this.toolStripMenuItemMedicalRecords,
            this.toolStripMenuItemPaymentOperations});
            this.menuStrip.Location = new System.Drawing.Point(0, 103);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(211, 589);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.patientsToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.patientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.patientsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(194, 32);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(216, 28);
            this.toolStripMenuItem3.Text = "List All Patients";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItemPatientsList_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 28);
            this.toolStripMenuItem2.Text = "Add New Patient";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItemAddNewPatient_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 28);
            this.toolStripMenuItem1.Text = "Delete Patient";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItemDeletePatient_Click);
            // 
            // toolStripMenuItemDoctors
            // 
            this.toolStripMenuItemDoctors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorToolStripMenuItem,
            this.doctorsListToolStripMenuItem,
            this.deleteDoctorToolStripMenuItem});
            this.toolStripMenuItemDoctors.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItemDoctors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemDoctors.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.toolStripMenuItemDoctors.Name = "toolStripMenuItemDoctors";
            this.toolStripMenuItemDoctors.Size = new System.Drawing.Size(194, 32);
            this.toolStripMenuItemDoctors.Text = "Doctors";
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.addDoctorToolStripMenuItem.Text = "Add Doctor";
            this.addDoctorToolStripMenuItem.Click += new System.EventHandler(this.addDoctorToolStripMenuItem_Click);
            // 
            // doctorsListToolStripMenuItem
            // 
            this.doctorsListToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.doctorsListToolStripMenuItem.Name = "doctorsListToolStripMenuItem";
            this.doctorsListToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.doctorsListToolStripMenuItem.Text = "Doctors List";
            this.doctorsListToolStripMenuItem.Click += new System.EventHandler(this.doctorsListToolStripMenuItem_Click);
            // 
            // deleteDoctorToolStripMenuItem
            // 
            this.deleteDoctorToolStripMenuItem.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteDoctorToolStripMenuItem.Name = "deleteDoctorToolStripMenuItem";
            this.deleteDoctorToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.deleteDoctorToolStripMenuItem.Text = "Delete Doctor";
            this.deleteDoctorToolStripMenuItem.Click += new System.EventHandler(this.deleteDoctorToolStripMenuItem_Click);
            // 
            // toolStripMenuItemAppointments
            // 
            this.toolStripMenuItemAppointments.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItemAppointments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemAppointments.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.toolStripMenuItemAppointments.Name = "toolStripMenuItemAppointments";
            this.toolStripMenuItemAppointments.Size = new System.Drawing.Size(194, 32);
            this.toolStripMenuItemAppointments.Text = "Appointments";
            this.toolStripMenuItemAppointments.Click += new System.EventHandler(this.toolStripMenuItemAppointments_Click);
            // 
            // toolStripMenuItemMedicalRecords
            // 
            this.toolStripMenuItemMedicalRecords.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItemMedicalRecords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemMedicalRecords.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.toolStripMenuItemMedicalRecords.Name = "toolStripMenuItemMedicalRecords";
            this.toolStripMenuItemMedicalRecords.Size = new System.Drawing.Size(194, 32);
            this.toolStripMenuItemMedicalRecords.Text = "Medical Records";
            this.toolStripMenuItemMedicalRecords.Click += new System.EventHandler(this.toolStripMenuItemMedicalRecords_Click);
            // 
            // toolStripMenuItemPaymentOperations
            // 
            this.toolStripMenuItemPaymentOperations.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItemPaymentOperations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemPaymentOperations.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.toolStripMenuItemPaymentOperations.Name = "toolStripMenuItemPaymentOperations";
            this.toolStripMenuItemPaymentOperations.Size = new System.Drawing.Size(194, 32);
            this.toolStripMenuItemPaymentOperations.Text = "Payment Operations";
            this.toolStripMenuItemPaymentOperations.Click += new System.EventHandler(this.toolStripMenuItemPaymentOperations_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panelFooter.Controls.Add(this.lblFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(211, 589);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1149, 103);
            this.panelFooter.TabIndex = 3;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFooter.Location = new System.Drawing.Point(501, 35);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(184, 33);
            this.lblFooter.TabIndex = 1;
            this.lblFooter.Text = "MediSync.com";
            // 
            // panelTransactions
            // 
            this.panelTransactions.Controls.Add(this.lblLastTransactionContent);
            this.panelTransactions.Controls.Add(this.lblLastTransaction);
            this.panelTransactions.Location = new System.Drawing.Point(220, 354);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(800, 205);
            this.panelTransactions.TabIndex = 4;
            // 
            // lblLastTransactionContent
            // 
            this.lblLastTransactionContent.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastTransactionContent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLastTransactionContent.Location = new System.Drawing.Point(23, 87);
            this.lblLastTransactionContent.Name = "lblLastTransactionContent";
            this.lblLastTransactionContent.Size = new System.Drawing.Size(759, 92);
            this.lblLastTransactionContent.TabIndex = 3;
            this.lblLastTransactionContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastTransaction
            // 
            this.lblLastTransaction.AutoSize = true;
            this.lblLastTransaction.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastTransaction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLastTransaction.Location = new System.Drawing.Point(23, 22);
            this.lblLastTransaction.Name = "lblLastTransaction";
            this.lblLastTransaction.Size = new System.Drawing.Size(216, 33);
            this.lblLastTransaction.TabIndex = 2;
            this.lblLastTransaction.Text = "Last Transaction :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNotificationContent);
            this.panel1.Controls.Add(this.lblNotification);
            this.panel1.Location = new System.Drawing.Point(220, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 205);
            this.panel1.TabIndex = 5;
            // 
            // lblNotificationContent
            // 
            this.lblNotificationContent.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNotificationContent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNotificationContent.Location = new System.Drawing.Point(23, 87);
            this.lblNotificationContent.Name = "lblNotificationContent";
            this.lblNotificationContent.Size = new System.Drawing.Size(759, 92);
            this.lblNotificationContent.TabIndex = 3;
            this.lblNotificationContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNotification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNotification.Location = new System.Drawing.Point(23, 22);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(171, 33);
            this.lblNotification.TabIndex = 2;
            this.lblNotification.Text = "Notifications :";
            // 
            // timerForAppointmentsChecking
            // 
            this.timerForAppointmentsChecking.Enabled = true;
            this.timerForAppointmentsChecking.Interval = 10000;
            this.timerForAppointmentsChecking.Tick += new System.EventHandler(this.timerForAppointmentsChecking_Tick);
            // 
            // panelFormHeader
            // 
            this.panelFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panelFormHeader.Controls.Add(this.labelHeader);
            this.panelFormHeader.Controls.Add(this.pictureBoxHeader);
            this.panelFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormHeader.Location = new System.Drawing.Point(0, 0);
            this.panelFormHeader.Name = "panelFormHeader";
            this.panelFormHeader.Size = new System.Drawing.Size(1360, 103);
            this.panelFormHeader.TabIndex = 6;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeader.Location = new System.Drawing.Point(637, 33);
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
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1360, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelFormHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Main Menu Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDateTime.ResumeLayout(false);
            this.panelDateTime.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panelTransactions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFormHeader.ResumeLayout(false);
            this.panelFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timerUpdateTime;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDoctors;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAppointments;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMedicalRecords;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Label lblLastTransaction;
        private System.Windows.Forms.Label lblLastTransactionContent;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDoctorToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotificationContent;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Timer timerForAppointmentsChecking;
        private System.Windows.Forms.Panel panelFormHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxHeader;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaymentOperations;
    }
}

