namespace Clinic_System
{
    partial class DeleteAMediacalRecordForm
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
            this.lblSelectRecordToDelete = new System.Windows.Forms.Label();
            this.comboBoxRecordsID = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucMedicalRecordInfo1 = new Clinic_System.ucMedicalRecordInfo();
            this.SuspendLayout();
            // 
            // lblSelectRecordToDelete
            // 
            this.lblSelectRecordToDelete.AutoSize = true;
            this.lblSelectRecordToDelete.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSelectRecordToDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectRecordToDelete.Location = new System.Drawing.Point(204, 169);
            this.lblSelectRecordToDelete.Name = "lblSelectRecordToDelete";
            this.lblSelectRecordToDelete.Size = new System.Drawing.Size(274, 28);
            this.lblSelectRecordToDelete.TabIndex = 3;
            this.lblSelectRecordToDelete.Text = "Select A Record To Delete :";
            // 
            // comboBoxRecordsID
            // 
            this.comboBoxRecordsID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRecordsID.FormattingEnabled = true;
            this.comboBoxRecordsID.Location = new System.Drawing.Point(513, 171);
            this.comboBoxRecordsID.Name = "comboBoxRecordsID";
            this.comboBoxRecordsID.Size = new System.Drawing.Size(377, 24);
            this.comboBoxRecordsID.TabIndex = 4;
            this.comboBoxRecordsID.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecordsID_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(239, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(239, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(788, 562);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(239, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucMedicalRecordInfo1
            // 
            this.ucMedicalRecordInfo1.Location = new System.Drawing.Point(169, 201);
            this.ucMedicalRecordInfo1.Name = "ucMedicalRecordInfo1";
            this.ucMedicalRecordInfo1.Size = new System.Drawing.Size(955, 296);
            this.ucMedicalRecordInfo1.TabIndex = 7;
            this.ucMedicalRecordInfo1.Visible = false;
            // 
            // DeleteAMediacalRecordForm
            // 
            this.AcceptButton = this.btnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1318, 658);
            this.Controls.Add(this.ucMedicalRecordInfo1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboBoxRecordsID);
            this.Controls.Add(this.lblSelectRecordToDelete);
            this.Name = "DeleteAMediacalRecordForm";
            this.Text = "Delete A Mediacal Record";
            this.Load += new System.EventHandler(this.DeleteAMediacalRecordForm_Load);
            this.Controls.SetChildIndex(this.lblSelectRecordToDelete, 0);
            this.Controls.SetChildIndex(this.comboBoxRecordsID, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.ucMedicalRecordInfo1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectRecordToDelete;
        private System.Windows.Forms.ComboBox comboBoxRecordsID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private ucMedicalRecordInfo ucMedicalRecordInfo1;
    }
}