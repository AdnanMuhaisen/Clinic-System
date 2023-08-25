namespace Clinic_System.Payment
{
    partial class AddNewBillForm
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
            this.lblChooseAnAppointment = new System.Windows.Forms.Label();
            this.comboBoxAppointments = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblAmpountPaied = new System.Windows.Forms.Label();
            this.textBoxAmountPaied = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentMethods = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.textBoxAdditionalNotes = new System.Windows.Forms.TextBox();
            this.lblAdditionalNoes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGoBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChooseAnAppointment
            // 
            this.lblChooseAnAppointment.AutoSize = true;
            this.lblChooseAnAppointment.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChooseAnAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChooseAnAppointment.Location = new System.Drawing.Point(342, 135);
            this.lblChooseAnAppointment.Name = "lblChooseAnAppointment";
            this.lblChooseAnAppointment.Size = new System.Drawing.Size(255, 28);
            this.lblChooseAnAppointment.TabIndex = 3;
            this.lblChooseAnAppointment.Text = "Choose An Appointment :";
            // 
            // comboBoxAppointments
            // 
            this.comboBoxAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppointments.FormattingEnabled = true;
            this.comboBoxAppointments.Location = new System.Drawing.Point(643, 135);
            this.comboBoxAppointments.Name = "comboBoxAppointments";
            this.comboBoxAppointments.Size = new System.Drawing.Size(298, 24);
            this.comboBoxAppointments.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPaymentDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaymentDate.Location = new System.Drawing.Point(172, 224);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(156, 28);
            this.lblPaymentDate.TabIndex = 6;
            this.lblPaymentDate.Text = "Payment Date :";
            // 
            // lblAmpountPaied
            // 
            this.lblAmpountPaied.AutoSize = true;
            this.lblAmpountPaied.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAmpountPaied.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmpountPaied.Location = new System.Drawing.Point(721, 228);
            this.lblAmpountPaied.Name = "lblAmpountPaied";
            this.lblAmpountPaied.Size = new System.Drawing.Size(156, 28);
            this.lblAmpountPaied.TabIndex = 7;
            this.lblAmpountPaied.Text = "Amount Paied :";
            // 
            // textBoxAmountPaied
            // 
            this.textBoxAmountPaied.Location = new System.Drawing.Point(884, 228);
            this.textBoxAmountPaied.Name = "textBoxAmountPaied";
            this.textBoxAmountPaied.Size = new System.Drawing.Size(265, 24);
            this.textBoxAmountPaied.TabIndex = 8;
            // 
            // comboBoxPaymentMethods
            // 
            this.comboBoxPaymentMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethods.FormattingEnabled = true;
            this.comboBoxPaymentMethods.Location = new System.Drawing.Point(473, 308);
            this.comboBoxPaymentMethods.Name = "comboBoxPaymentMethods";
            this.comboBoxPaymentMethods.Size = new System.Drawing.Size(298, 24);
            this.comboBoxPaymentMethods.TabIndex = 10;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPaymentMethod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaymentMethod.Location = new System.Drawing.Point(172, 308);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(263, 28);
            this.lblPaymentMethod.TabIndex = 9;
            this.lblPaymentMethod.Text = "Choose Payment Method :";
            // 
            // textBoxAdditionalNotes
            // 
            this.textBoxAdditionalNotes.Location = new System.Drawing.Point(374, 368);
            this.textBoxAdditionalNotes.Multiline = true;
            this.textBoxAdditionalNotes.Name = "textBoxAdditionalNotes";
            this.textBoxAdditionalNotes.Size = new System.Drawing.Size(440, 77);
            this.textBoxAdditionalNotes.TabIndex = 12;
            // 
            // lblAdditionalNoes
            // 
            this.lblAdditionalNoes.AutoSize = true;
            this.lblAdditionalNoes.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAdditionalNoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdditionalNoes.Location = new System.Drawing.Point(172, 368);
            this.lblAdditionalNoes.Name = "lblAdditionalNoes";
            this.lblAdditionalNoes.Size = new System.Drawing.Size(179, 28);
            this.lblAdditionalNoes.TabIndex = 11;
            this.lblAdditionalNoes.Text = "Additional Notes :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(223, 549);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(262, 38);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(584, 549);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(262, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(945, 549);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(262, 38);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
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
            this.lblGoBack.TabIndex = 16;
            this.lblGoBack.Text = "Go Back";
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // AddNewBillForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1382, 681);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxAdditionalNotes);
            this.Controls.Add(this.lblAdditionalNoes);
            this.Controls.Add(this.comboBoxPaymentMethods);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.textBoxAmountPaied);
            this.Controls.Add(this.lblAmpountPaied);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxAppointments);
            this.Controls.Add(this.lblChooseAnAppointment);
            this.Name = "AddNewBillForm";
            this.Text = "AddNewBillForm";
            this.Load += new System.EventHandler(this.AddNewBillForm_Load);
            this.Controls.SetChildIndex(this.lblChooseAnAppointment, 0);
            this.Controls.SetChildIndex(this.comboBoxAppointments, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.lblPaymentDate, 0);
            this.Controls.SetChildIndex(this.lblAmpountPaied, 0);
            this.Controls.SetChildIndex(this.textBoxAmountPaied, 0);
            this.Controls.SetChildIndex(this.lblPaymentMethod, 0);
            this.Controls.SetChildIndex(this.comboBoxPaymentMethods, 0);
            this.Controls.SetChildIndex(this.lblAdditionalNoes, 0);
            this.Controls.SetChildIndex(this.textBoxAdditionalNotes, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.lblGoBack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseAnAppointment;
        private System.Windows.Forms.ComboBox comboBoxAppointments;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblAmpountPaied;
        private System.Windows.Forms.TextBox textBoxAmountPaied;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethods;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox textBoxAdditionalNotes;
        private System.Windows.Forms.Label lblAdditionalNoes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblGoBack;
    }
}