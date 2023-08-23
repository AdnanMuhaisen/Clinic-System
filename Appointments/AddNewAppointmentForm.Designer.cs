namespace Clinic_System
{
    partial class AddNewAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewAppointmentForm));
            this.panelFormHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
            this.lblChoosePatient = new System.Windows.Forms.Label();
            this.comboBoxPatients = new System.Windows.Forms.ComboBox();
            this.comboBoxDoctors = new System.Windows.Forms.ComboBox();
            this.lblChooseDoctor = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.maskedTextBoxAppointmentTime = new System.Windows.Forms.MaskedTextBox();
            this.lblCautien = new System.Windows.Forms.Label();
            this.panelFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormHeader
            // 
            this.panelFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panelFormHeader.Controls.Add(this.labelHeader);
            this.panelFormHeader.Controls.Add(this.pictureBoxHeader);
            this.panelFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormHeader.Location = new System.Drawing.Point(0, 0);
            this.panelFormHeader.Name = "panelFormHeader";
            this.panelFormHeader.Size = new System.Drawing.Size(1389, 103);
            this.panelFormHeader.TabIndex = 1;
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
            // lblChoosePatient
            // 
            this.lblChoosePatient.AutoSize = true;
            this.lblChoosePatient.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChoosePatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChoosePatient.Location = new System.Drawing.Point(144, 177);
            this.lblChoosePatient.Name = "lblChoosePatient";
            this.lblChoosePatient.Size = new System.Drawing.Size(169, 28);
            this.lblChoosePatient.TabIndex = 2;
            this.lblChoosePatient.Text = "Choose Patient :";
            // 
            // comboBoxPatients
            // 
            this.comboBoxPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatients.FormattingEnabled = true;
            this.comboBoxPatients.Location = new System.Drawing.Point(370, 177);
            this.comboBoxPatients.Name = "comboBoxPatients";
            this.comboBoxPatients.Size = new System.Drawing.Size(238, 24);
            this.comboBoxPatients.Sorted = true;
            this.comboBoxPatients.TabIndex = 0;
            // 
            // comboBoxDoctors
            // 
            this.comboBoxDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctors.FormattingEnabled = true;
            this.comboBoxDoctors.Location = new System.Drawing.Point(976, 177);
            this.comboBoxDoctors.Name = "comboBoxDoctors";
            this.comboBoxDoctors.Size = new System.Drawing.Size(238, 24);
            this.comboBoxDoctors.Sorted = true;
            this.comboBoxDoctors.TabIndex = 1;
            // 
            // lblChooseDoctor
            // 
            this.lblChooseDoctor.AutoSize = true;
            this.lblChooseDoctor.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChooseDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChooseDoctor.Location = new System.Drawing.Point(750, 177);
            this.lblChooseDoctor.Name = "lblChooseDoctor";
            this.lblChooseDoctor.Size = new System.Drawing.Size(165, 28);
            this.lblChooseDoctor.TabIndex = 4;
            this.lblChooseDoctor.Text = "Choose Doctor :";
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(374, 258);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(234, 24);
            this.dateTimePickerAppointmentDate.TabIndex = 2;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAppointmentDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAppointmentDate.Location = new System.Drawing.Point(144, 257);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(193, 28);
            this.lblAppointmentDate.TabIndex = 7;
            this.lblAppointmentDate.Text = "Appointment Date :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(285, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(871, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(242, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(750, 258);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 28);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time :";
            // 
            // maskedTextBoxAppointmentTime
            // 
            this.maskedTextBoxAppointmentTime.Location = new System.Drawing.Point(855, 260);
            this.maskedTextBoxAppointmentTime.Mask = "90:00";
            this.maskedTextBoxAppointmentTime.Name = "maskedTextBoxAppointmentTime";
            this.maskedTextBoxAppointmentTime.Size = new System.Drawing.Size(258, 24);
            this.maskedTextBoxAppointmentTime.TabIndex = 3;
            this.maskedTextBoxAppointmentTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblCautien
            // 
            this.lblCautien.AutoSize = true;
            this.lblCautien.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCautien.ForeColor = System.Drawing.Color.Red;
            this.lblCautien.Location = new System.Drawing.Point(1131, 263);
            this.lblCautien.Name = "lblCautien";
            this.lblCautien.Size = new System.Drawing.Size(172, 16);
            this.lblCautien.TabIndex = 11;
            this.lblCautien.Text = "Use The 24 Format Please";
            // 
            // AddNewAppointmentForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1389, 579);
            this.Controls.Add(this.lblCautien);
            this.Controls.Add(this.maskedTextBoxAppointmentTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.dateTimePickerAppointmentDate);
            this.Controls.Add(this.comboBoxDoctors);
            this.Controls.Add(this.lblChooseDoctor);
            this.Controls.Add(this.comboBoxPatients);
            this.Controls.Add(this.lblChoosePatient);
            this.Controls.Add(this.panelFormHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewAppointmentForm";
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.AddNewAppointmentForm_Load);
            this.panelFormHeader.ResumeLayout(false);
            this.panelFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFormHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxHeader;
        private System.Windows.Forms.Label lblChoosePatient;
        private System.Windows.Forms.ComboBox comboBoxPatients;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.Label lblChooseDoctor;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAppointmentTime;
        private System.Windows.Forms.Label lblCautien;
    }
}