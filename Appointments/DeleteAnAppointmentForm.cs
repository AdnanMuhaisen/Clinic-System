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
    public partial class DeleteAnAppointmentForm : BaseForm
    {
        public DeleteAnAppointmentForm()
        {
            InitializeComponent();
        }

        private void DeleteAnAppointmentForm_Load(object sender, EventArgs e)
        {
            _FillAppointmentsComboBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            _ControlsVisibility(true);
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

        private void _ControlsVisibility(bool Visible)
        {
            btnDelete.Visible = btnClose.Visible = Visible;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsAppointment.DeleteAnAppointment(_GetIDFromString(comboBoxAppointments.SelectedItem.ToString())))
            {
                MessageBox.Show("Deleted Succssfully", "MediSync", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                comboBoxAppointments.SelectedIndex = -1;
                _FillAppointmentsComboBox();
            }
            else
                MessageBox.Show("An Error Occuer When Try To Delete This Appointment !", "MediSync", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private int _GetIDFromString(string str)
            => int.Parse(str.Substring(0, str.IndexOf(" ")));

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
