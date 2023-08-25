namespace Clinic_System.Payment
{
    partial class DeleteABillForm
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
            this.comboBoxBills = new System.Windows.Forms.ComboBox();
            this.lblChooseABillToDelete = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblAmountPaied = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGoBack = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBills
            // 
            this.comboBoxBills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBills.FormattingEnabled = true;
            this.comboBoxBills.Location = new System.Drawing.Point(581, 145);
            this.comboBoxBills.Name = "comboBoxBills";
            this.comboBoxBills.Size = new System.Drawing.Size(298, 24);
            this.comboBoxBills.TabIndex = 6;
            this.comboBoxBills.SelectedIndexChanged += new System.EventHandler(this.comboBoxBills_SelectedIndexChanged);
            // 
            // lblChooseABillToDelete
            // 
            this.lblChooseABillToDelete.AutoSize = true;
            this.lblChooseABillToDelete.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChooseABillToDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChooseABillToDelete.Location = new System.Drawing.Point(379, 145);
            this.lblChooseABillToDelete.Name = "lblChooseABillToDelete";
            this.lblChooseABillToDelete.Size = new System.Drawing.Size(151, 28);
            this.lblChooseABillToDelete.TabIndex = 5;
            this.lblChooseABillToDelete.Text = "Choose A Bill :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAdditionalNotes);
            this.panel1.Controls.Add(this.lblPaymentMethod);
            this.panel1.Controls.Add(this.lblAmountPaied);
            this.panel1.Controls.Add(this.lblBillDate);
            this.panel1.Controls.Add(this.lblBillID);
            this.panel1.Location = new System.Drawing.Point(313, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 371);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAdditionalNotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdditionalNotes.Location = new System.Drawing.Point(75, 287);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(179, 28);
            this.lblAdditionalNotes.TabIndex = 10;
            this.lblAdditionalNotes.Text = "Additional Notes :";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPaymentMethod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaymentMethod.Location = new System.Drawing.Point(75, 223);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(183, 28);
            this.lblPaymentMethod.TabIndex = 9;
            this.lblPaymentMethod.Text = "Payment Method :";
            // 
            // lblAmountPaied
            // 
            this.lblAmountPaied.AutoSize = true;
            this.lblAmountPaied.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAmountPaied.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmountPaied.Location = new System.Drawing.Point(75, 160);
            this.lblAmountPaied.Name = "lblAmountPaied";
            this.lblAmountPaied.Size = new System.Drawing.Size(173, 28);
            this.lblAmountPaied.TabIndex = 8;
            this.lblAmountPaied.Text = "Ammount Paied :";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBillDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBillDate.Location = new System.Drawing.Point(75, 97);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(101, 28);
            this.lblBillDate.TabIndex = 7;
            this.lblBillDate.Text = "Bill Date :";
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Font = new System.Drawing.Font("Simple Indust Outline", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBillID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBillID.Location = new System.Drawing.Point(75, 34);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(77, 28);
            this.lblBillID.TabIndex = 6;
            this.lblBillID.Text = "Bill ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 581);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(263, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(753, 581);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(263, 35);
            this.btnClose.TabIndex = 9;
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
            // DeleteABillForm
            // 
            this.AcceptButton = this.btnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1368, 658);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxBills);
            this.Controls.Add(this.lblChooseABillToDelete);
            this.Name = "DeleteABillForm";
            this.Text = "DeleteABill";
            this.Load += new System.EventHandler(this.DeleteABillForm_Load);
            this.Controls.SetChildIndex(this.lblChooseABillToDelete, 0);
            this.Controls.SetChildIndex(this.comboBoxBills, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.lblGoBack, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBills;
        private System.Windows.Forms.Label lblChooseABillToDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblAmountPaied;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblGoBack;
    }
}