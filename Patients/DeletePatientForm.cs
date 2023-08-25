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
    public partial class DeletePatientForm : Form
    {
        private PatientsListForm _PatientsListForm;

        public DeletePatientForm()
        {
            InitializeComponent();
            _PatientsListForm = new PatientsListForm();
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty || ((TextBox)sender).Text == default)
                return;

            if (clsInputValidation.IsNumber(((TextBox)sender).Text))
            {
                errorProvider1.SetError((TextBox)sender, string.Empty);
                DataTable SearchDt = clsPatient.FindPatientByPersonID(Convert.ToInt32(((TextBox)sender).Text));
                if (SearchDt.Rows.Count > 0)
                {
                    _IsDeleteControlsVisible(true);
                    lblPersonID.Text = string.Concat("Person ID :  " + SearchDt.Rows[0]["PersonID"].ToString());
                    lblPatientID.Text = string.Concat("Patient ID :  " + SearchDt.Rows[0]["PatientID"].ToString());
                    lblFullName.Text = string.Concat("Full Name :  " + SearchDt.Rows[0]["FirstName"].ToString(), "  ",
                        SearchDt.Rows[0]["LastName"].ToString());
                }
                else
                    _IsDeleteControlsVisible(false);
            }
            else
            {
                _IsDeleteControlsVisible(false);
                errorProvider1.SetError((TextBox)sender, "Invalid ID !");
                ((TextBox)sender).Focus();
            }
        }

        private void _IsDeleteControlsVisible(bool Visible)
        {
            groupBoxPatientInfo.Visible=Visible;
            btnDelete.Visible = Visible;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(textBoxSearch.Text);
            if (clsPatient.Delete(PersonID))
            {
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSearch.Clear();
                _IsDeleteControlsVisible(false);
            }
            else
                MessageBox.Show("An Error Occuer When Try To Delete This Patient", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPatientsList_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_PatientsListForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
