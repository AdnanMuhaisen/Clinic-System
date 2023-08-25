using Clinic_System___Middle_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_System
{
    public partial class AddNewAppointmentForm : Form
    {
        DataTable PatientsDT, DoctorsDT;
        int PatientID = default, DoctorID = default;
        string Date = default, Time = default;


        public AddNewAppointmentForm()
        {
            InitializeComponent();
            PatientsDT = clsPatient.GetPatientsTable();
            DoctorsDT = clsDoctor.GetDoctorsTable();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsAllFormDataAvailable())
            {
                clsAppointment NewAppointment = 
                    new clsAppointment(this.PatientID, this.DoctorID, 1, null, null, this.Date, this.Time);
                if (NewAppointment.Save())
                {
                    MessageBox.Show("The Appointment Added Successfully ", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    _ClearFormControls();
                }
                else
                    MessageBox.Show("An Error Occuer When Try To Save The Appointment !", "Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void AddNewAppointmentForm_Load(object sender, EventArgs e)
        {
            comboBoxPatients.Focus();
            _FillPatientsComboBox();
            _FillDoctorssComboBox();
        }

        private void _FillPatientsComboBox()
        {
            if (PatientsDT == null)
                return;

            foreach (DataRow dr in PatientsDT.Rows)
            {
                comboBoxPatients.Items.Add(dr["PatientID"].ToString() + " " + dr["FirstName"].ToString() + " " +
                    dr["LastName"].ToString());
            }
        }

        private void _FillDoctorssComboBox()
        {
            if (DoctorsDT == null)
                return;

            foreach (DataRow dr in DoctorsDT.Rows)
            {
                comboBoxDoctors.Items.Add(dr["DoctorID"].ToString() + " " + dr["FirstName"].ToString() + " " +
                    dr["LastName"].ToString());
            }
        }



        private int _GetIDFromComboBox(ComboBox Cb)
            => int.Parse(Cb.SelectedItem.ToString().Substring(0, Cb.SelectedItem.ToString().IndexOf(" ")));

        private bool _IsAllFormDataAvailable()
        {
            if (comboBoxPatients.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxPatients, "Select A Patient !");
                comboBoxPatients.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBoxPatients, string.Empty);
                this.PatientID = _GetIDFromComboBox(comboBoxPatients);
            }

            if (comboBoxDoctors.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxDoctors, "Select A Doctor !");
                comboBoxDoctors.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBoxDoctors, string.Empty);
                this.DoctorID = _GetIDFromComboBox(comboBoxDoctors);
            }

            if (_IsAppointmentTimeDoesNotConflect())
            {
                errorProvider1.SetError(maskedTextBoxAppointmentTime, string.Empty);
                this.Date = dateTimePickerAppointmentDate.Value.ToString("yyyy-MM-dd");
                this.Time = maskedTextBoxAppointmentTime.Text;
                return true;
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxAppointmentTime, "Time Or Date Conflect With Another Appointment !");
                MessageBox.Show("Choose Another Date Or Time Please !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private bool _IsAppointmentTimeDoesNotConflect()
            => _IsAppointmentTimeDoesNotConflectDoctorAppointments() &&
                _IsAppointmentTimeDoesNotConflectPatientAppointments();

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsAppointmentTimeDoesNotConflectDoctorAppointments()
        {
            if (comboBoxDoctors.SelectedIndex == -1)
                return false;

            if (TimeSpan.TryParse(maskedTextBoxAppointmentTime.Text, out TimeSpan Ts)) {
                if (clsDoctor.IsDoctorAppointmentAvailable(_GetIDFromComboBox(comboBoxDoctors), dateTimePickerAppointmentDate.Value.ToString("yyy-MM-dd"),
                    maskedTextBoxAppointmentTime.Text))
                    return true;
                else
                    return false;
            }
            return false;
        }

        private bool _IsAppointmentTimeDoesNotConflectPatientAppointments()
        {
            if (comboBoxPatients.SelectedIndex == -1)
                return false;

            if (TimeSpan.TryParse(maskedTextBoxAppointmentTime.Text, out TimeSpan Ts))
            {
                if (clsPatient.IsPatientAppointmentAvailable(_GetIDFromComboBox(comboBoxPatients),
                    dateTimePickerAppointmentDate.Value.ToString("yyyy-MM-dd"), maskedTextBoxAppointmentTime.Text))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private void _ClearFormControls()
        {
            comboBoxDoctors.SelectedIndex = comboBoxPatients.SelectedIndex = -1;
            maskedTextBoxAppointmentTime.Clear();
        }
    }
}
