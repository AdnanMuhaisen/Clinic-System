namespace Clinic_System
{
    partial class AddNewMedicalRecordForm
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
            this.lblAppointment = new System.Windows.Forms.Label();
            this.comboBoxAppointments = new System.Windows.Forms.ComboBox();
            this.textBoxVisitDescription = new System.Windows.Forms.TextBox();
            this.lblVisitDescription = new System.Windows.Forms.Label();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.lblAddetionalNotes = new System.Windows.Forms.Label();
            this.textBoxAdditionalNotes = new System.Windows.Forms.TextBox();
            this.lblCharacterCounterForVisitDescription = new System.Windows.Forms.Label();
            this.lblCharacterCounterForDiagnosis = new System.Windows.Forms.Label();
            this.lblOptional = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAppointment.Location = new System.Drawing.Point(68, 144);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(123, 24);
            this.lblAppointment.TabIndex = 3;
            this.lblAppointment.Text = "Appointment :";
            // 
            // comboBoxAppointments
            // 
            this.comboBoxAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppointments.FormattingEnabled = true;
            this.comboBoxAppointments.Location = new System.Drawing.Point(215, 142);
            this.comboBoxAppointments.Name = "comboBoxAppointments";
            this.comboBoxAppointments.Size = new System.Drawing.Size(319, 24);
            this.comboBoxAppointments.TabIndex = 4;
            this.comboBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppointments_SelectedIndexChanged);
            // 
            // textBoxVisitDescription
            // 
            this.textBoxVisitDescription.Location = new System.Drawing.Point(241, 209);
            this.textBoxVisitDescription.Multiline = true;
            this.textBoxVisitDescription.Name = "textBoxVisitDescription";
            this.textBoxVisitDescription.Size = new System.Drawing.Size(538, 143);
            this.textBoxVisitDescription.TabIndex = 5;
            this.textBoxVisitDescription.Tag = "100";
            this.textBoxVisitDescription.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblVisitDescription
            // 
            this.lblVisitDescription.AutoSize = true;
            this.lblVisitDescription.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVisitDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVisitDescription.Location = new System.Drawing.Point(68, 209);
            this.lblVisitDescription.Name = "lblVisitDescription";
            this.lblVisitDescription.Size = new System.Drawing.Size(158, 24);
            this.lblVisitDescription.TabIndex = 6;
            this.lblVisitDescription.Text = "Visit Description :";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDiagnosis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiagnosis.Location = new System.Drawing.Point(68, 377);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(103, 24);
            this.lblDiagnosis.TabIndex = 8;
            this.lblDiagnosis.Text = "Diagnosis :";
            // 
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.Location = new System.Drawing.Point(241, 377);
            this.textBoxDiagnosis.Multiline = true;
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(538, 96);
            this.textBoxDiagnosis.TabIndex = 7;
            this.textBoxDiagnosis.Tag = "200";
            this.textBoxDiagnosis.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblAddetionalNotes
            // 
            this.lblAddetionalNotes.AutoSize = true;
            this.lblAddetionalNotes.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddetionalNotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddetionalNotes.Location = new System.Drawing.Point(794, 210);
            this.lblAddetionalNotes.Name = "lblAddetionalNotes";
            this.lblAddetionalNotes.Size = new System.Drawing.Size(160, 24);
            this.lblAddetionalNotes.TabIndex = 10;
            this.lblAddetionalNotes.Text = "Addetional Notes :";
            // 
            // textBoxAdditionalNotes
            // 
            this.textBoxAdditionalNotes.Location = new System.Drawing.Point(967, 210);
            this.textBoxAdditionalNotes.Multiline = true;
            this.textBoxAdditionalNotes.Name = "textBoxAdditionalNotes";
            this.textBoxAdditionalNotes.Size = new System.Drawing.Size(381, 96);
            this.textBoxAdditionalNotes.TabIndex = 9;
            // 
            // lblCharacterCounterForVisitDescription
            // 
            this.lblCharacterCounterForVisitDescription.AutoSize = true;
            this.lblCharacterCounterForVisitDescription.Font = new System.Drawing.Font("Simple Indust Outline", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCharacterCounterForVisitDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCharacterCounterForVisitDescription.Location = new System.Drawing.Point(785, 321);
            this.lblCharacterCounterForVisitDescription.Name = "lblCharacterCounterForVisitDescription";
            this.lblCharacterCounterForVisitDescription.Size = new System.Drawing.Size(52, 31);
            this.lblCharacterCounterForVisitDescription.TabIndex = 11;
            this.lblCharacterCounterForVisitDescription.Text = "0/100\r\n";
            // 
            // lblCharacterCounterForDiagnosis
            // 
            this.lblCharacterCounterForDiagnosis.AutoSize = true;
            this.lblCharacterCounterForDiagnosis.Font = new System.Drawing.Font("Simple Indust Outline", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCharacterCounterForDiagnosis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCharacterCounterForDiagnosis.Location = new System.Drawing.Point(785, 442);
            this.lblCharacterCounterForDiagnosis.Name = "lblCharacterCounterForDiagnosis";
            this.lblCharacterCounterForDiagnosis.Size = new System.Drawing.Size(52, 31);
            this.lblCharacterCounterForDiagnosis.TabIndex = 12;
            this.lblCharacterCounterForDiagnosis.Text = "0/200\r\n";
            // 
            // lblOptional
            // 
            this.lblOptional.AutoSize = true;
            this.lblOptional.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblOptional.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOptional.Location = new System.Drawing.Point(1276, 309);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(72, 24);
            this.lblOptional.TabIndex = 13;
            this.lblOptional.Text = "Optional";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 537);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(629, 537);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(222, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(975, 537);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(222, 36);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNewMedicalRecordForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1387, 648);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOptional);
            this.Controls.Add(this.lblCharacterCounterForDiagnosis);
            this.Controls.Add(this.lblCharacterCounterForVisitDescription);
            this.Controls.Add(this.lblAddetionalNotes);
            this.Controls.Add(this.textBoxAdditionalNotes);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.textBoxDiagnosis);
            this.Controls.Add(this.lblVisitDescription);
            this.Controls.Add(this.textBoxVisitDescription);
            this.Controls.Add(this.comboBoxAppointments);
            this.Controls.Add(this.lblAppointment);
            this.Name = "AddNewMedicalRecordForm";
            this.Text = "New Medical Record";
            this.Load += new System.EventHandler(this.NewMedicalRecord_Load);
            this.Controls.SetChildIndex(this.lblAppointment, 0);
            this.Controls.SetChildIndex(this.comboBoxAppointments, 0);
            this.Controls.SetChildIndex(this.textBoxVisitDescription, 0);
            this.Controls.SetChildIndex(this.lblVisitDescription, 0);
            this.Controls.SetChildIndex(this.textBoxDiagnosis, 0);
            this.Controls.SetChildIndex(this.lblDiagnosis, 0);
            this.Controls.SetChildIndex(this.textBoxAdditionalNotes, 0);
            this.Controls.SetChildIndex(this.lblAddetionalNotes, 0);
            this.Controls.SetChildIndex(this.lblCharacterCounterForVisitDescription, 0);
            this.Controls.SetChildIndex(this.lblCharacterCounterForDiagnosis, 0);
            this.Controls.SetChildIndex(this.lblOptional, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.ComboBox comboBoxAppointments;
        private System.Windows.Forms.TextBox textBoxVisitDescription;
        private System.Windows.Forms.Label lblVisitDescription;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private System.Windows.Forms.Label lblAddetionalNotes;
        private System.Windows.Forms.TextBox textBoxAdditionalNotes;
        private System.Windows.Forms.Label lblCharacterCounterForVisitDescription;
        private System.Windows.Forms.Label lblCharacterCounterForDiagnosis;
        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}