namespace Clinic_System
{
    partial class PatientsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsListForm));
            this.panelFormHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
            this.dataGridViewPatientsList = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblClosePatientsList = new System.Windows.Forms.Label();
            this.panelFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientsList)).BeginInit();
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
            this.panelFormHeader.Size = new System.Drawing.Size(1365, 103);
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
            // dataGridViewPatientsList
            // 
            this.dataGridViewPatientsList.AllowUserToAddRows = false;
            this.dataGridViewPatientsList.AllowUserToDeleteRows = false;
            this.dataGridViewPatientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatientsList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPatientsList.Location = new System.Drawing.Point(0, 234);
            this.dataGridViewPatientsList.Name = "dataGridViewPatientsList";
            this.dataGridViewPatientsList.ReadOnly = true;
            this.dataGridViewPatientsList.RowHeadersWidth = 51;
            this.dataGridViewPatientsList.RowTemplate.Height = 26;
            this.dataGridViewPatientsList.Size = new System.Drawing.Size(1365, 423);
            this.dataGridViewPatientsList.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Simple Indust Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(368, 141);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(260, 33);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search By Person ID :";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(646, 141);
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(4, 35);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(367, 24);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblClosePatientsList
            // 
            this.lblClosePatientsList.AutoSize = true;
            this.lblClosePatientsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClosePatientsList.Font = new System.Drawing.Font("Simple Indust Outline", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblClosePatientsList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClosePatientsList.Location = new System.Drawing.Point(0, 103);
            this.lblClosePatientsList.Name = "lblClosePatientsList";
            this.lblClosePatientsList.Size = new System.Drawing.Size(110, 31);
            this.lblClosePatientsList.TabIndex = 5;
            this.lblClosePatientsList.Text = "Go Back";
            this.lblClosePatientsList.Click += new System.EventHandler(this.lblClosePatientsList_Click);
            // 
            // PatientsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1365, 657);
            this.Controls.Add(this.lblClosePatientsList);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridViewPatientsList);
            this.Controls.Add(this.panelFormHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientsListForm";
            this.Text = "Patients List / Search";
            this.Load += new System.EventHandler(this.PatientsListAndSearch_Load);
            this.panelFormHeader.ResumeLayout(false);
            this.panelFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFormHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxHeader;
        private System.Windows.Forms.DataGridView dataGridViewPatientsList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblClosePatientsList;
    }
}