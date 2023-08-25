using Clinic_System.Appointments;
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
    public partial class AppointmentsForm : Form
    {
        private AddNewAppointmentForm _AddNewAppointmentForm;
        private DeleteAnAppointmentForm _DeleteAnAppointmentForm;
        private UpdateAnAppointmentForm _UpdateAnAppointmentForm;


        public AppointmentsForm()
        {
            InitializeComponent();
            _AddNewAppointmentForm = new AddNewAppointmentForm();
            _DeleteAnAppointmentForm = new DeleteAnAppointmentForm();
            _UpdateAnAppointmentForm = new UpdateAnAppointmentForm();
        }

        private void addNewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_AddNewAppointmentForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
            dataGridViewAppointments.DataSource = clsAppointment.GetAllAppointments();
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            dataGridViewAppointments.DataSource = clsAppointment.GetAllAppointments();
        }

        private void deleteAnAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(_DeleteAnAppointmentForm.ShowDialog()==DialogResult.Cancel)
                this.Show();
            dataGridViewAppointments.DataSource = clsAppointment.GetAllAppointments();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_UpdateAnAppointmentForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
            dataGridViewAppointments.DataSource = clsAppointment.GetAllAppointments();
        }

    }
}
