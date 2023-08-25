using Clinic_System___Middle_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_System.Payment
{
    public partial class DeleteABillForm : BaseForm
    {
        private clsBill _TargetBill;
        public DeleteABillForm()
        {
            InitializeComponent();
        }

        private void DeleteABillForm_Load(object sender, EventArgs e)
        {
            _FillBillsComboBox();
        }

        private void _FillBillsComboBox()
        {
            DataTable dataTable = clsBill.GetAllBillsID();

            if (dataTable == null)
                return;

            foreach (DataRow row in dataTable.Rows)
                comboBoxBills.Items.Add(row["BillID"].ToString() + " ,Date" + row["PaymentDate"].ToString());
        }

        private void comboBoxBills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBills.SelectedIndex == -1)
            {
                _ControlsVisibility(false);
                return;
            }

            _TargetBill = clsBill.Find(_GetIDFromString(comboBoxBills.SelectedItem.ToString()));
            if (_TargetBill != null)
            {
                _ControlsVisibility(true);
                _FillBillInfo(_TargetBill);
            }
        }

        private void _FillBillInfo(clsBill Bill)
        {
            lblBillID.Text = "Bill ID : " + Bill.BillID.ToString();
            lblBillDate.Text = "Payment Date : " + Bill.PaymentDate.ToString();
            lblAmountPaied.Text = "Amount Paied : " + Bill.AmountPaied.ToString();
            lblPaymentMethod.Text = "Payment Method : " + Bill.PaymentMethod.ToString();
            lblAdditionalNotes.Text = "Additional Notes : " + Bill.AdditionalNotes.ToString();
        }

        private int _GetIDFromString(string str)
        => int.Parse(str.Substring(0, str.IndexOf(" ")));

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxBills.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxBills, "Select A Bill To Delete !");
                comboBoxBills.Focus();
                return;
            }
            errorProvider1.SetError(comboBoxBills, string.Empty);

            if (_TargetBill.Equals(null))
            {
                MessageBox.Show("The Bill Does Not Exist !", "MediSync", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsBill.DeleteABill((int)(_TargetBill.BillID)))
            {
                this._TargetBill = null;
                clsTransactions.SaveToFile($"The Bill With ID {_TargetBill.BillID} Is Deleted {DateTime.Now}",
                    clsTransactions.eFiles.BillsFile);
                MessageBox.Show("Deleted Successfully", "MediSync", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Clear();

                // To Update The Combo Box
                _FillBillsComboBox();

                return;
            }
            else
                MessageBox.Show("An Error Occuer When Delete This Bill !", "MediSync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _Clear()
        {
            comboBoxBills.SelectedIndex = -1;
        }

        private void _ControlsVisibility(bool Visible)
        {
            panel1.Visible = Visible;
            btnDelete.Visible = btnClose.Visible = Visible;
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
