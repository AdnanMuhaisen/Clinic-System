using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Clinic_System___Middle_Layer;



namespace Clinic_System
{
    public partial class MainMenuForm : Form
    {
        private PatientsListForm _PatientsListForm;
        private AddNewPatientForm _AddNewPatientForm;
        private DeletePatientForm _DeletePatientForm;
        private DoctorsListForm _DoctorsListForm;
        private AddNewDoctorForm _AddNewDoctorForm;
        private DeleteDoctorForm _DeleteDoctorForm;
        private AppointmentsForm _AppointmentsForm;
        public MainMenuForm()
        {
            InitializeComponent();
            _PatientsListForm = new PatientsListForm();
            _AddNewPatientForm = new AddNewPatientForm();
            _DeletePatientForm = new DeletePatientForm();
            _DoctorsListForm = new DoctorsListForm();
            _AddNewDoctorForm = new AddNewDoctorForm();
            _DeleteDoctorForm = new DeleteDoctorForm();
            _AppointmentsForm = new AppointmentsForm();



            _AppointmentsChecking();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text += DateTime.Now.ToShortDateString();
            lblTime.Text = string.Concat("Time :  ", DateTime.Now.ToShortTimeString());
            lblLastTransactionContent.Text = clsTransactions.ReadLastLineFromFile(clsTransactions.eFiles.TransactionsFile);
            lblNotificationContent.Text = clsTransactions.ReadLastLineFromFile(clsTransactions.eFiles.AppointmentsFile);
        }

        private void timerUpdateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Concat("Time :  ", DateTime.Now.ToShortTimeString());
        }

        private void toolStripMenuItemPatientsList_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (_PatientsListForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
        }

        private void toolStripMenuItemAddNewPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this._AddNewPatientForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
            _UpdateTransactionLabel();
        }

        private void _UpdateTransactionLabel()
           => lblLastTransactionContent.Text = 
            clsTransactions.ReadLastLineFromFile(clsTransactions.eFiles.TransactionsFile);

        private void toolStripMenuItemDeletePatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_DeletePatientForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
            _UpdateTransactionLabel();
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(_AddNewDoctorForm.ShowDialog()==DialogResult.Cancel)
                this.Show();
            _UpdateTransactionLabel();
        }

        private void doctorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_DoctorsListForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
        }

        private void deleteDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(_DeleteDoctorForm.ShowDialog()==DialogResult.Cancel)
                this.Show();
            _UpdateTransactionLabel();
        }

        private void _UpdateNotificationsLabel()
            => lblNotificationContent.Text = clsTransactions.ReadLastLineFromFile(clsTransactions.eFiles.AppointmentsFile);

        private void toolStripMenuItemAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(_AppointmentsForm.ShowDialog()==DialogResult.Cancel)
                this.Show();
            _UpdateNotificationsLabel();
        }

        private void timerForAppointmentsChecking_Tick(object sender, EventArgs e)
        {

            _AppointmentsChecking();
        }

        private void _AppointmentsChecking()
        {
            DataTable AppointmentDt = clsAppointment.IsThereAnAppointmentNow();
            if (AppointmentDt != null)
            {
                DialogResult AppointmentMessageResult = MessageBox.Show
                    ($"An Appointment For The Patient With ID {AppointmentDt.Rows[0]["PatientID"]} At The Doctor With ID {AppointmentDt.Rows[0]["DoctorID"]} Is Now !\n" +
                    "Do You Neeed To Confirm This Appointment ?",
                    "Appointment Message",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);

                if (AppointmentMessageResult == DialogResult.Yes)
                {
                    if (clsAppointment.UpdateAnAppointmentSataus(Convert.ToInt32(AppointmentDt.Rows[0]["AppointmentID"]),
                        (int)clsAppointment.eAppointmentStatuses.Confirmed))
                        MessageBox.Show("The Appointment Confirmed !", "Confirmation Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error Occuer When Update The Appointment Status !", "Error Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    return;
                }
                else if (AppointmentMessageResult == DialogResult.No)
                {
                    if (clsAppointment.UpdateAnAppointmentSataus(Convert.ToInt32(AppointmentDt.Rows[0]["AppointmentID"]),
                         (int)clsAppointment.eAppointmentStatuses.No_Show))
                        MessageBox.Show("The Appointment Has No Show !", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error Occuer When Update The Appointment Status !", "Error Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    return;
                }
                else if (AppointmentMessageResult == DialogResult.Cancel)
                {
                    if (clsAppointment.UpdateAnAppointmentSataus(Convert.ToInt32(AppointmentDt.Rows[0]["AppointmentID"]),
                            (int)clsAppointment.eAppointmentStatuses.Canceled))
                        MessageBox.Show("The Appointment Canceled !", "Cancele Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error Occuer When Update The Appointment Status !", "Error Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    return;
                }
                else
                    clsAppointment.UpdateAnAppointmentSataus(Convert.ToInt32(AppointmentDt.Rows[0]["AppointmentID"]),
                       (int)clsAppointment.eAppointmentStatuses.No_Show);
            }
        }

        private void toolStripMenuItemDoctors_Click(object sender, EventArgs e)
        {

        }
    }
}
