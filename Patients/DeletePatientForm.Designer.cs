namespace Clinic_System
{
    partial class DeletePatientForm
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
            this.panelFormHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.groupBoxPatientInfo = new System.Windows.Forms.GroupBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPatientsList = new System.Windows.Forms.Button();
            this.panelFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxPatientInfo.SuspendLayout();
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
            this.panelFormHeader.Size = new System.Drawing.Size(1396, 103);
            this.panelFormHeader.TabIndex = 2;
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
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(663, 158);
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(4, 35);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(367, 35);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(385, 158);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(260, 33);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search By Person ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPersonID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPersonID.Location = new System.Drawing.Point(33, 42);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(120, 28);
            this.lblPersonID.TabIndex = 6;
            this.lblPersonID.Text = "Person ID :";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPatientID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPatientID.Location = new System.Drawing.Point(554, 42);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(125, 28);
            this.lblPatientID.TabIndex = 7;
            this.lblPatientID.Text = "Patient ID : ";
            // 
            // groupBoxPatientInfo
            // 
            this.groupBoxPatientInfo.Controls.Add(this.lblFullName);
            this.groupBoxPatientInfo.Controls.Add(this.lblPatientID);
            this.groupBoxPatientInfo.Controls.Add(this.lblPersonID);
            this.groupBoxPatientInfo.Font = new System.Drawing.Font("Simple Indust Outline", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBoxPatientInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxPatientInfo.Location = new System.Drawing.Point(238, 229);
            this.groupBoxPatientInfo.Name = "groupBoxPatientInfo";
            this.groupBoxPatientInfo.Size = new System.Drawing.Size(964, 225);
            this.groupBoxPatientInfo.TabIndex = 7;
            this.groupBoxPatientInfo.TabStop = false;
            this.groupBoxPatientInfo.Text = "Patient Information";
            this.groupBoxPatientInfo.Visible = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFullName.Location = new System.Drawing.Point(33, 133);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(191, 28);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Person Full Name :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 542);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(226, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(976, 542);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(226, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPatientsList
            // 
            this.btnPatientsList.Location = new System.Drawing.Point(612, 542);
            this.btnPatientsList.Name = "btnPatientsList";
            this.btnPatientsList.Size = new System.Drawing.Size(226, 40);
            this.btnPatientsList.TabIndex = 10;
            this.btnPatientsList.Text = "Show Patients List";
            this.btnPatientsList.UseVisualStyleBackColor = true;
            this.btnPatientsList.Click += new System.EventHandler(this.btnPatientsList_Click);
            // 
            // DeletePatientForm
            // 
            this.AcceptButton = this.btnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1396, 676);
            this.Controls.Add(this.btnPatientsList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBoxPatientInfo);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.panelFormHeader);
            this.Name = "DeletePatientForm";
            this.Text = "DeletePatientForm";
            this.panelFormHeader.ResumeLayout(false);
            this.panelFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxPatientInfo.ResumeLayout(false);
            this.groupBoxPatientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFormHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxHeader;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBoxPatientInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPatientsList;
    }
}