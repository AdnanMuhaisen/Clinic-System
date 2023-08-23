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
    public partial class PatientsListForm : Form
    {

        public PatientsListForm()
        {
            InitializeComponent();
            dataGridViewPatientsList.DataSource = clsPatient.PatientsTable;
        }

        private void PatientsListAndSearch_Load(object sender, EventArgs e)
        {
            // In Case A Transaction Is Made On The Patients Table Then The Table Must 
            // Be Updated :
            clsPatient.UpdatePatientsTable();
            dataGridViewPatientsList.DataSource = clsPatient.PatientsTable;   
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Equals(string.Empty)) {
                dataGridViewPatientsList.DataSource = clsPatient.PatientsTable;
                errorProvider1.SetError(((TextBox)sender), string.Empty);
                return;
            }

            if (clsInputValidation.IsNumber(((TextBox)sender).Text))
            {
                DataTable Temp = clsPatient.FindPatientByPersonID(int.Parse(((TextBox)sender).Text));
                if (Temp != null && Temp.Rows.Count > 0)
                {
                    dataGridViewPatientsList.DataSource = Temp;
                    errorProvider1.SetError(((TextBox)sender), string.Empty);
                }
                else
                {
                    dataGridViewPatientsList.DataSource = clsPatient.PatientsTable;
                    errorProvider1.SetError(((TextBox)sender), "The Patient With This Person ID Does Not Exist !");
                }
            }
        }

        private void lblClosePatientsList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
