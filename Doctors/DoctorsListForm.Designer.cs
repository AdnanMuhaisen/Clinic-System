namespace Clinic_System
{
    partial class DoctorsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsListForm));
            this.panelFormHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
            this.dataGridViewDoctorsList = new System.Windows.Forms.DataGridView();
            this.lblCloseDoctorsList = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorsList)).BeginInit();
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
            this.panelFormHeader.Size = new System.Drawing.Size(1393, 103);
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
            // dataGridViewDoctorsList
            // 
            this.dataGridViewDoctorsList.AllowUserToAddRows = false;
            this.dataGridViewDoctorsList.AllowUserToDeleteRows = false;
            this.dataGridViewDoctorsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoctorsList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDoctorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDoctorsList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewDoctorsList.Location = new System.Drawing.Point(0, 228);
            this.dataGridViewDoctorsList.Name = "dataGridViewDoctorsList";
            this.dataGridViewDoctorsList.ReadOnly = true;
            this.dataGridViewDoctorsList.RowHeadersWidth = 51;
            this.dataGridViewDoctorsList.RowTemplate.Height = 26;
            this.dataGridViewDoctorsList.Size = new System.Drawing.Size(1393, 399);
            this.dataGridViewDoctorsList.TabIndex = 2;
            // 
            // lblCloseDoctorsList
            // 
            this.lblCloseDoctorsList.AutoSize = true;
            this.lblCloseDoctorsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCloseDoctorsList.Font = new System.Drawing.Font("Simple Indust Outline", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCloseDoctorsList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCloseDoctorsList.Location = new System.Drawing.Point(0, 103);
            this.lblCloseDoctorsList.Name = "lblCloseDoctorsList";
            this.lblCloseDoctorsList.Size = new System.Drawing.Size(110, 31);
            this.lblCloseDoctorsList.TabIndex = 6;
            this.lblCloseDoctorsList.Text = "Go Back";
            this.lblCloseDoctorsList.Click += new System.EventHandler(this.lblClosePatientsList_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(670, 144);
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(4, 35);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(367, 24);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(392, 144);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(260, 33);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search By Person ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DoctorsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1393, 627);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblCloseDoctorsList);
            this.Controls.Add(this.dataGridViewDoctorsList);
            this.Controls.Add(this.panelFormHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorsListForm";
            this.Text = "Doctors List / Serach";
            this.Load += new System.EventHandler(this.DoctorsListForm_Load);
            this.panelFormHeader.ResumeLayout(false);
            this.panelFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFormHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxHeader;
        private System.Windows.Forms.DataGridView dataGridViewDoctorsList;
        private System.Windows.Forms.Label lblCloseDoctorsList;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}