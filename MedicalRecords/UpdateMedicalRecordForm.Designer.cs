namespace Clinic_System
{
    partial class UpdateMedicalRecordForm
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
            this.lblSelectRecordToUpdate = new System.Windows.Forms.Label();
            this.comboBoxRecordsID = new System.Windows.Forms.ComboBox();
            this.panelUpdateRecord = new System.Windows.Forms.Panel();
            this.textBoxAdditionalNotes = new System.Windows.Forms.TextBox();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.textBoxVisitDescription = new System.Windows.Forms.TextBox();
            this.lblVisitDescription = new System.Windows.Forms.Label();
            this.textBoxRecordID = new System.Windows.Forms.TextBox();
            this.lblRecordID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGoBack = new System.Windows.Forms.Label();
            this.panelUpdateRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectRecordToUpdate
            // 
            this.lblSelectRecordToUpdate.AutoSize = true;
            this.lblSelectRecordToUpdate.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSelectRecordToUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectRecordToUpdate.Location = new System.Drawing.Point(291, 135);
            this.lblSelectRecordToUpdate.Name = "lblSelectRecordToUpdate";
            this.lblSelectRecordToUpdate.Size = new System.Drawing.Size(281, 28);
            this.lblSelectRecordToUpdate.TabIndex = 4;
            this.lblSelectRecordToUpdate.Text = "Select A Record To Update :";
            // 
            // comboBoxRecordsID
            // 
            this.comboBoxRecordsID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRecordsID.FormattingEnabled = true;
            this.comboBoxRecordsID.Location = new System.Drawing.Point(611, 135);
            this.comboBoxRecordsID.Name = "comboBoxRecordsID";
            this.comboBoxRecordsID.Size = new System.Drawing.Size(303, 24);
            this.comboBoxRecordsID.TabIndex = 5;
            this.comboBoxRecordsID.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecordsID_SelectedIndexChanged);
            // 
            // panelUpdateRecord
            // 
            this.panelUpdateRecord.Controls.Add(this.textBoxAdditionalNotes);
            this.panelUpdateRecord.Controls.Add(this.lblAdditionalNotes);
            this.panelUpdateRecord.Controls.Add(this.textBoxDiagnosis);
            this.panelUpdateRecord.Controls.Add(this.lblDiagnosis);
            this.panelUpdateRecord.Controls.Add(this.textBoxVisitDescription);
            this.panelUpdateRecord.Controls.Add(this.lblVisitDescription);
            this.panelUpdateRecord.Controls.Add(this.textBoxRecordID);
            this.panelUpdateRecord.Controls.Add(this.lblRecordID);
            this.panelUpdateRecord.Location = new System.Drawing.Point(185, 166);
            this.panelUpdateRecord.Name = "panelUpdateRecord";
            this.panelUpdateRecord.Size = new System.Drawing.Size(989, 357);
            this.panelUpdateRecord.TabIndex = 6;
            this.panelUpdateRecord.Visible = false;
            // 
            // textBoxAdditionalNotes
            // 
            this.textBoxAdditionalNotes.Location = new System.Drawing.Point(307, 287);
            this.textBoxAdditionalNotes.Multiline = true;
            this.textBoxAdditionalNotes.Name = "textBoxAdditionalNotes";
            this.textBoxAdditionalNotes.Size = new System.Drawing.Size(422, 53);
            this.textBoxAdditionalNotes.TabIndex = 12;
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAdditionalNotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdditionalNotes.Location = new System.Drawing.Point(97, 287);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(155, 24);
            this.lblAdditionalNotes.TabIndex = 11;
            this.lblAdditionalNotes.Text = "Additional Notes :";
            // 
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.Location = new System.Drawing.Point(307, 212);
            this.textBoxDiagnosis.Multiline = true;
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(422, 69);
            this.textBoxDiagnosis.TabIndex = 10;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDiagnosis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiagnosis.Location = new System.Drawing.Point(97, 212);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(103, 24);
            this.lblDiagnosis.TabIndex = 9;
            this.lblDiagnosis.Text = "Diagnosis :";
            // 
            // textBoxVisitDescription
            // 
            this.textBoxVisitDescription.Location = new System.Drawing.Point(307, 91);
            this.textBoxVisitDescription.Multiline = true;
            this.textBoxVisitDescription.Name = "textBoxVisitDescription";
            this.textBoxVisitDescription.Size = new System.Drawing.Size(422, 102);
            this.textBoxVisitDescription.TabIndex = 8;
            // 
            // lblVisitDescription
            // 
            this.lblVisitDescription.AutoSize = true;
            this.lblVisitDescription.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVisitDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVisitDescription.Location = new System.Drawing.Point(97, 91);
            this.lblVisitDescription.Name = "lblVisitDescription";
            this.lblVisitDescription.Size = new System.Drawing.Size(158, 24);
            this.lblVisitDescription.TabIndex = 7;
            this.lblVisitDescription.Text = "Visit Description :";
            // 
            // textBoxRecordID
            // 
            this.textBoxRecordID.Location = new System.Drawing.Point(223, 27);
            this.textBoxRecordID.Name = "textBoxRecordID";
            this.textBoxRecordID.ReadOnly = true;
            this.textBoxRecordID.Size = new System.Drawing.Size(191, 24);
            this.textBoxRecordID.TabIndex = 6;
            // 
            // lblRecordID
            // 
            this.lblRecordID.AutoSize = true;
            this.lblRecordID.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecordID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRecordID.Location = new System.Drawing.Point(97, 27);
            this.lblRecordID.Name = "lblRecordID";
            this.lblRecordID.Size = new System.Drawing.Size(102, 24);
            this.lblRecordID.TabIndex = 5;
            this.lblRecordID.Text = "Record ID :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(286, 562);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(824, 562);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 37);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // UpdateMedicalRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 658);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelUpdateRecord);
            this.Controls.Add(this.comboBoxRecordsID);
            this.Controls.Add(this.lblSelectRecordToUpdate);
            this.Name = "UpdateMedicalRecordForm";
            this.Text = "Update Medical Record";
            this.Load += new System.EventHandler(this.UpdateMedicalRecordForm_Load);
            this.Controls.SetChildIndex(this.lblSelectRecordToUpdate, 0);
            this.Controls.SetChildIndex(this.comboBoxRecordsID, 0);
            this.Controls.SetChildIndex(this.panelUpdateRecord, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.lblGoBack, 0);
            this.panelUpdateRecord.ResumeLayout(false);
            this.panelUpdateRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectRecordToUpdate;
        private System.Windows.Forms.ComboBox comboBoxRecordsID;
        private System.Windows.Forms.Panel panelUpdateRecord;
        private System.Windows.Forms.Label lblVisitDescription;
        private System.Windows.Forms.TextBox textBoxRecordID;
        private System.Windows.Forms.Label lblRecordID;
        private System.Windows.Forms.TextBox textBoxAdditionalNotes;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox textBoxVisitDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblGoBack;
    }
}