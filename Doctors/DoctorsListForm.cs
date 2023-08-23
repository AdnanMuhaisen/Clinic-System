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
    public partial class DoctorsListForm : Form
    {
        public DoctorsListForm()
        {
            InitializeComponent();
        }

        private void DoctorsListForm_Load(object sender, EventArgs e)
        {
            dataGridViewDoctorsList.DataSource = clsDoctor.GetDoctorsTable(); ;
        }

        private void lblClosePatientsList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Equals(string.Empty))
            {
                dataGridViewDoctorsList.DataSource = clsDoctor.DoctorsTable;
                errorProvider1.SetError(((TextBox)sender), string.Empty);
                return;
            }

            if (clsInputValidation.IsNumber(((TextBox)sender).Text))
            {
                DataTable Temp = clsDoctor.FindDoctorByPersonID(int.Parse(((TextBox)sender).Text));
                if (Temp != null && Temp.Rows.Count > 0)
                {
                    dataGridViewDoctorsList.DataSource = Temp;
                    errorProvider1.SetError(((TextBox)sender), string.Empty);
                }
                else
                {
                    dataGridViewDoctorsList.DataSource = clsPatient.PatientsTable;
                    errorProvider1.SetError(((TextBox)sender), "The Doctor With This Person ID Does Not Exist !");
                }
            }
        }
    }
}
