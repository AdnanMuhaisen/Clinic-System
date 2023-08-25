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

namespace Clinic_System
{
    public partial class AddNewMedicalRecordForm : BaseForm
    {
        string Diagnosis = default, VisitDescription = default, AdditionalNotes = default;
        int AppointmentID;



        public AddNewMedicalRecordForm()
        {
            InitializeComponent();
        }

        private void NewMedicalRecord_Load(object sender, EventArgs e)
        {
            _FillAppointmentsComboBox();
        }

        private void _FillAppointmentsComboBox()
        {
            DataTable TempDt = clsAppointment.GetAppointmentsForMedicalRecordForm();
            if (TempDt == null)
                return;

            foreach (DataRow dr in TempDt.Rows)
                comboBoxAppointments.Items.Add("ID : " + dr["AppointmentID"].ToString() + " Date : " + dr["Date"].ToString() +
                    " Time : " + dr["Time"].ToString());
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            short MaxCharacters = Convert.ToInt16(((TextBox)sender).Tag);

            if (((TextBox)sender).Text.Length > MaxCharacters)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, MaxCharacters);
                return;
            }

            if (((TextBox)sender).Name.Equals("textBoxVisitDescription"))
                lblCharacterCounterForVisitDescription.Text = $"{textBoxVisitDescription.Text.Length}/{MaxCharacters}";
            else if (((TextBox)sender).Name.Equals("textBoxDiagnosis"))
                lblCharacterCounterForDiagnosis.Text = $"{textBoxDiagnosis.Text.Length}/{MaxCharacters}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }

        private void _Clear()
        {
            comboBoxAppointments.SelectedIndex = -1;
            textBoxVisitDescription.Text = textBoxDiagnosis.Text = textBoxAdditionalNotes.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsFormDataAreFilled())
            {
                clsMedicalRecord NewMedicalRecord = 
                    new clsMedicalRecord(this.Diagnosis, this.VisitDescription, this.AdditionalNotes);

                if (NewMedicalRecord.Save(this.AppointmentID))
                {
                    MessageBox.Show("Saved Successfully", "Message", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("An Error Occuer When Saving This Record !", "Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsFormDataAreFilled()
        {
            if (comboBoxAppointments.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxAppointments, "Select An Appointment Please !");
                comboBoxAppointments.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBoxAppointments, string.Empty);
                this.AppointmentID = _GetIDFromString(comboBoxAppointments.SelectedItem.ToString());
            }

            if (textBoxVisitDescription.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxVisitDescription, "Required !");
                textBoxVisitDescription.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBoxVisitDescription, string.Empty);
                this.VisitDescription = textBoxVisitDescription.Text;
            }

            if (textBoxDiagnosis.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxDiagnosis, "Required !");
                textBoxDiagnosis.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBoxDiagnosis, string.Empty);
                this.Diagnosis = textBoxDiagnosis.Text;
            }
            this.AdditionalNotes = textBoxAdditionalNotes.Text;

            return true;
        }

        private int _GetIDFromString(string str)
            => int.Parse(str.Substring(5, str.IndexOf(" ", 5) - 5));
    }
}
