namespace Clinic_System.Appointments
{
    partial class UpdateAnAppointmentForm
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
            this.comboBoxAppointments = new System.Windows.Forms.ComboBox();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.comboBoxDoctors = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.comboBoxPatients = new System.Windows.Forms.ComboBox();
            this.lblChooseAPatient = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGoBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAppointments
            // 
            this.comboBoxAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppointments.FormattingEnabled = true;
            this.comboBoxAppointments.Location = new System.Drawing.Point(608, 142);
            this.comboBoxAppointments.Name = "comboBoxAppointments";
            this.comboBoxAppointments.Size = new System.Drawing.Size(441, 24);
            this.comboBoxAppointments.Sorted = true;
            this.comboBoxAppointments.TabIndex = 3;
            this.comboBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppointments_SelectedIndexChanged);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAppointment.Location = new System.Drawing.Point(347, 142);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(255, 28);
            this.lblAppointment.TabIndex = 4;
            this.lblAppointment.Text = "Choose An Appointment :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.maskedTextBox1);
            this.panelUpdate.Controls.Add(this.lblTime);
            this.panelUpdate.Controls.Add(this.dateTimePicker1);
            this.panelUpdate.Controls.Add(this.lblDate);
            this.panelUpdate.Controls.Add(this.comboBoxDoctors);
            this.panelUpdate.Controls.Add(this.lblDoctor);
            this.panelUpdate.Controls.Add(this.comboBoxPatients);
            this.panelUpdate.Controls.Add(this.lblChooseAPatient);
            this.panelUpdate.Location = new System.Drawing.Point(191, 198);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(1031, 302);
            this.panelUpdate.TabIndex = 5;
            this.panelUpdate.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(442, 232);
            this.maskedTextBox1.Mask = "90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(301, 24);
            this.maskedTextBox1.TabIndex = 12;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(288, 232);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 28);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(442, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 24);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(288, 164);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 28);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date : ";
            // 
            // comboBoxDoctors
            // 
            this.comboBoxDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctors.FormattingEnabled = true;
            this.comboBoxDoctors.Location = new System.Drawing.Point(442, 96);
            this.comboBoxDoctors.Name = "comboBoxDoctors";
            this.comboBoxDoctors.Size = new System.Drawing.Size(301, 24);
            this.comboBoxDoctors.Sorted = true;
            this.comboBoxDoctors.TabIndex = 7;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDoctor.Location = new System.Drawing.Point(288, 96);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(111, 28);
            this.lblDoctor.TabIndex = 8;
            this.lblDoctor.Text = "Doctor ID :";
            // 
            // comboBoxPatients
            // 
            this.comboBoxPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatients.FormattingEnabled = true;
            this.comboBoxPatients.Location = new System.Drawing.Point(442, 28);
            this.comboBoxPatients.Name = "comboBoxPatients";
            this.comboBoxPatients.Size = new System.Drawing.Size(301, 24);
            this.comboBoxPatients.Sorted = true;
            this.comboBoxPatients.TabIndex = 5;
            // 
            // lblChooseAPatient
            // 
            this.lblChooseAPatient.AutoSize = true;
            this.lblChooseAPatient.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChooseAPatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChooseAPatient.Location = new System.Drawing.Point(288, 28);
            this.lblChooseAPatient.Name = "lblChooseAPatient";
            this.lblChooseAPatient.Size = new System.Drawing.Size(120, 28);
            this.lblChooseAPatient.TabIndex = 6;
            this.lblChooseAPatient.Text = "Patient ID  :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(410, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(826, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGoBack.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGoBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGoBack.Location = new System.Drawing.Point(0, 103);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(93, 28);
            this.lblGoBack.TabIndex = 13;
            this.lblGoBack.Text = "Go Back";
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // UpdateAnAppointmentForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1378, 688);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.comboBoxAppointments);
            this.Controls.Add(this.lblAppointment);
            this.Name = "UpdateAnAppointmentForm";
            this.Text = "Update An Appointment";
            this.Load += new System.EventHandler(this.UpdateAnAppointment_Load);
            this.Controls.SetChildIndex(this.lblAppointment, 0);
            this.Controls.SetChildIndex(this.comboBoxAppointments, 0);
            this.Controls.SetChildIndex(this.panelUpdate, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.lblGoBack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAppointments;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox comboBoxPatients;
        private System.Windows.Forms.Label lblChooseAPatient;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGoBack;
    }
}