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

namespace Clinic_System.Appointments
{
    public partial class UpdateAnAppointmentForm : BaseForm
    {
        private clsAppointment _TargetAppointment;


        public UpdateAnAppointmentForm()
        {
            InitializeComponent();
        }

        private void UpdateAnAppointment_Load(object sender, EventArgs e)
        {
            _FillAppointmentsComboBox();
            _FillPatientsComboBox();
            _FillDoctorsComboBox();

        }

        private void _FillAppointmentsComboBox()
        {
            DataTable dataTable = clsAppointment.GetPinedAppointments();

            if (dataTable == null)
                return;

            foreach (DataRow row in dataTable.Rows)
                comboBoxAppointments.Items.Add(row["AppointmentID"].ToString() + " " + row["Date"].ToString() + " " +
                    row["Time"].ToString());
            
        }

        private void comboBoxAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxAppointments.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxAppointments, "Select An Appointment !");
                comboBoxAppointments.Focus();
                _ControlsVisibility(false);
                return;
            }
            errorProvider1.SetError(comboBoxAppointments, string.Empty);

            this._TargetAppointment = clsAppointment.Find(_GetIDFromString(comboBoxAppointments.SelectedItem.ToString()));

            if (_TargetAppointment == null)
                return;

            _ControlsVisibility(true);
            _FillAppointmentData(_TargetAppointment);
        }

        private int _GetIDFromString(string str)
        => int.Parse(str.Substring(0, str.IndexOf(" ")));

        private void _FillAppointmentData(clsAppointment Appointment)
        {
            int index = 0;
            foreach (string str  in comboBoxPatients.Items)
            {
                if (Appointment.PatientID == _GetIDFromString(str))
                    comboBoxPatients.SelectedIndex = index;
                index++;
            }

            index = 0;
            foreach (string str in comboBoxDoctors.Items)
            {
                if (Appointment.DoctorID == _GetIDFromString(str))
                    comboBoxDoctors.SelectedIndex = index;
                index++;
            }
            dateTimePicker1.Value = Convert.ToDateTime(Appointment.Date);
            maskedTextBox1.Text = Appointment.Time;
        }

        private void _FillPatientsComboBox()
        {
            DataTable dataTable = clsPatient.GetPatientsTable();

            if (dataTable == null)
                return;

            foreach (DataRow row in dataTable.Rows)
                comboBoxPatients.Items.Add(row["PatientID"].ToString()+" ");
        }

        private void _FillDoctorsComboBox()
        {
            DataTable dataTable = clsDoctor.GetDoctorsTable();

            if (dataTable == null)
                return;

            foreach (DataRow row in dataTable.Rows)
                comboBoxDoctors.Items.Add(row["DoctorID"].ToString()+" ");
        }

        private void _ControlsVisibility(bool Visible)
        {
            panelUpdate.Visible = Visible;
            btnSave.Visible = btnClose.Visible = Visible;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidFormData())
                return;

            _TargetAppointment.AppointmentID = _GetIDFromString(comboBoxAppointments.SelectedItem.ToString());
            _TargetAppointment.DoctorID = _GetIDFromString(comboBoxDoctors.SelectedItem.ToString());
            _TargetAppointment.PatientID = _GetIDFromString(comboBoxPatients.SelectedItem.ToString());
            _TargetAppointment.Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            _TargetAppointment.Time = maskedTextBox1.Text;

            MessageBox.Show(_TargetAppointment.Date + "   " + _TargetAppointment.Time);


            if (clsDoctor.IsDoctorAppointmentAvailable(_TargetAppointment.DoctorID, _TargetAppointment.Date, _TargetAppointment.Time)
                && clsPatient.IsPatientAppointmentAvailable(_TargetAppointment.PatientID, _TargetAppointment.Date, _TargetAppointment.Time))
            {

                if (_TargetAppointment.Save())
                {
                    MessageBox.Show("Updated Successfully ", "MediSync", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    comboBoxAppointments.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("An Error Occuer When Try To Update This Appoinment !", "MediSync", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Choose Another Date Or Time Please !", "MediSync", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private bool _IsValidFormData()
        {
            if (comboBoxPatients.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxPatients, "Select A Doctor !");
                comboBoxPatients.Focus();
                return false;
            }
            else
                errorProvider1.SetError(comboBoxPatients, string.Empty);

            if (comboBoxDoctors.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxDoctors, "Select A Doctor !");
                comboBoxDoctors.Focus();
                return false;
            }
            else
                errorProvider1.SetError(comboBoxDoctors, string.Empty);

            if (maskedTextBox1.Text != string.Empty)
            {
                if (TimeSpan.TryParse(maskedTextBox1.Text, out TimeSpan s))
                {
                    errorProvider1.SetError(maskedTextBox1, string.Empty);
                }
                else
                {
                    errorProvider1.SetError(maskedTextBox1, "Invalid Time !");
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(maskedTextBox1, "Required !");
                return false;
            }
            return true;
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
