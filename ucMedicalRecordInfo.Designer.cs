namespace Clinic_System
{
    partial class ucMedicalRecordInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRecordID = new System.Windows.Forms.Label();
            this.lblVisitDescription = new System.Windows.Forms.Label();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecordID
            // 
            this.lblRecordID.AutoSize = true;
            this.lblRecordID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordID.Location = new System.Drawing.Point(33, 18);
            this.lblRecordID.Name = "lblRecordID";
            this.lblRecordID.Size = new System.Drawing.Size(92, 18);
            this.lblRecordID.TabIndex = 0;
            this.lblRecordID.Text = "Record ID :";
            // 
            // lblVisitDescription
            // 
            this.lblVisitDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitDescription.Location = new System.Drawing.Point(33, 57);
            this.lblVisitDescription.Name = "lblVisitDescription";
            this.lblVisitDescription.Size = new System.Drawing.Size(606, 62);
            this.lblVisitDescription.TabIndex = 1;
            this.lblVisitDescription.Text = "Visit Description :";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.Location = new System.Drawing.Point(33, 140);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(606, 62);
            this.lblDiagnosis.TabIndex = 2;
            this.lblDiagnosis.Text = "Diagnosis :";
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalNotes.Location = new System.Drawing.Point(33, 223);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(606, 62);
            this.lblAdditionalNotes.TabIndex = 3;
            this.lblAdditionalNotes.Text = "Additional Notes : ";
            // 
            // ucMedicalRecordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAdditionalNotes);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.lblVisitDescription);
            this.Controls.Add(this.lblRecordID);
            this.Name = "ucMedicalRecordInfo";
            this.Size = new System.Drawing.Size(726, 328);
            this.Load += new System.EventHandler(this.MedicalRecordInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecordID;
        private System.Windows.Forms.Label lblVisitDescription;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label lblAdditionalNotes;
    }
}
