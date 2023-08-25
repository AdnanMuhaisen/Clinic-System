namespace Clinic_System.Appointments
{
    partial class DeleteAnAppointmentForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGoBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAppointments
            // 
            this.comboBoxAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppointments.FormattingEnabled = true;
            this.comboBoxAppointments.Location = new System.Drawing.Point(596, 150);
            this.comboBoxAppointments.Name = "comboBoxAppointments";
            this.comboBoxAppointments.Size = new System.Drawing.Size(441, 24);
            this.comboBoxAppointments.Sorted = true;
            this.comboBoxAppointments.TabIndex = 5;
            this.comboBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppointments_SelectedIndexChanged);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAppointment.Location = new System.Drawing.Point(288, 146);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(255, 28);
            this.lblAppointment.TabIndex = 6;
            this.lblAppointment.Text = "Choose An Appointment :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 512);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(238, 37);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(783, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(238, 37);
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
            // DeleteAnAppointmentForm
            // 
            this.AcceptButton = this.btnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1360, 659);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboBoxAppointments);
            this.Controls.Add(this.lblAppointment);
            this.Name = "DeleteAnAppointmentForm";
            this.Text = "Delete An Appointment";
            this.Load += new System.EventHandler(this.DeleteAnAppointmentForm_Load);
            this.Controls.SetChildIndex(this.lblAppointment, 0);
            this.Controls.SetChildIndex(this.comboBoxAppointments, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.lblGoBack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAppointments;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblGoBack;
    }
}