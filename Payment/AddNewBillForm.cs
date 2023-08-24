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
    public partial class AddNewBillForm : BaseForm
    {
        float PaiedAmount = default;
        DateTime PaymentDate = DateTime.Now;
        int AppointmentID = default, PaymentMethod = default;
        string AdditionalNotes = default;


        public AddNewBillForm()
        {
            InitializeComponent();
        }

        private void AddNewBillForm_Load(object sender, EventArgs e)
        {
            _FillAppointmentsComboBox();
            _FillPaymentMethodsComboBox();
        }

        private void _FillAppointmentsComboBox()
        {
            DataTable AppointmentsTable = clsAppointment.GetConfirmedAppointments();

            if (AppointmentsTable == null)
                return;

            foreach (DataRow Appointment in AppointmentsTable.Rows)
                comboBoxAppointments.Items.Add(Appointment["AppointmentID"].ToString() + " " + Appointment["Date"].ToString() + " " +
                    Appointment["Time"].ToString());
        }

        private void _FillPaymentMethodsComboBox()
        {
            DataTable MethodsTable = clsBill.GetAllPaymentMethods();

            if (MethodsTable == null)
                return;

            foreach (DataRow Method in MethodsTable.Rows)
                comboBoxPaymentMethods.Items.Add(Method["MethodID"].ToString() + " " + Method["MethodName"].ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }

        private void _Clear()
        {
            comboBoxAppointments.SelectedIndex = comboBoxPaymentMethods.SelectedIndex = -1;
            textBoxAdditionalNotes.Text = textBoxAmountPaied.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsInputValidated())
                return;

            if(MessageBox.Show(
                $"Appointment ID : {this.AppointmentID}\n" +
                $"Payment Date : {this.PaymentDate}\n" +
                $"Paied Amount : {this.PaiedAmount} $\n" +
                $"Payment Method : {this.PaymentMethod}\n" +
                $"Are You Sure You Want To Save This Bill ?",

                "MediSync Payment Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsBill NewBill = new clsBill(this.PaymentDate, this.PaiedAmount, this.PaymentMethod, this.AdditionalNotes);
                if (NewBill.Save(this.AppointmentID))
                {
                    _Clear();
                    MessageBox.Show("The Bill Added Successfully", "MediSync", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // To Update The Appointments
                    _FillAppointmentsComboBox();
                    return;
                }
                else
                    MessageBox.Show("An Error Occuer When Saving This Bill ", "MediSync", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private bool _IsInputValidated()
        {
            if (comboBoxAppointments.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxAppointments, "Required !");
                comboBoxAppointments.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBoxAmountPaied, string.Empty);
                this.AppointmentID = _GetNumberFromFromComboBoxItem(comboBoxAppointments);
            }

            if (!clsInputValidation.IsFloatNumber(textBoxAmountPaied.Text))
            {
                errorProvider1.SetError(textBoxAmountPaied, "Invalied Amount !");
                textBoxAmountPaied.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBoxAmountPaied, string.Empty);
                float.TryParse(textBoxAmountPaied.Text, out this.PaiedAmount);
            }
            if (comboBoxPaymentMethods.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxPaymentMethods, "Required !");
                comboBoxPaymentMethods.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBoxPaymentMethods, string.Empty);
                this.PaymentMethod = _GetNumberFromFromComboBoxItem(comboBoxPaymentMethods);
            }
            this.AdditionalNotes = textBoxAdditionalNotes.Text;
            return true;
        }

        private int _GetNumberFromFromComboBoxItem(ComboBox Cb)
         => int.Parse(Cb.SelectedItem.ToString().Substring(0, Cb.SelectedItem.ToString().IndexOf(" ")));





    }
}
