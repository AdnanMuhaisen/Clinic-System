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
    public partial class DeleteDoctorForm : Form
    {
        private DoctorsListForm _DoctorsListForm;


        public DeleteDoctorForm()
        {
            InitializeComponent();
            _DoctorsListForm = new DoctorsListForm();
        }

        private void btnPatientsList_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_DoctorsListForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty || ((TextBox)sender).Text == default)
                return;

            if (clsInputValidation.IsNumber(((TextBox)sender).Text))
            {
                errorProvider1.SetError((TextBox)sender, string.Empty);
                DataTable SearchDt = clsDoctor.FindDoctorByPersonID(Convert.ToInt32(((TextBox)sender).Text));
                if (SearchDt.Rows.Count > 0)
                {
                    _IsDeleteControlsVisible(true);
                    lblPersonID.Text = string.Concat("Person ID :  ", SearchDt.Rows[0]["PersonID"].ToString());
                    lblDoctorID.Text = string.Concat("Doctor ID :  ", SearchDt.Rows[0]["DoctorID"].ToString());
                    lblFullName.Text = string.Concat("Full Name :  ", SearchDt.Rows[0]["FirstName"].ToString(), "  ",
                        SearchDt.Rows[0]["LastName"].ToString());
                }
                else
                {
                    _IsDeleteControlsVisible(false);
                    errorProvider1.SetError((TextBox)sender, "The Doctor Does Not Exist !");
                }
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
            groupBoxPatientInfo.Visible = Visible;
            btnDelete.Visible = Visible;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsDoctor.Delete(Convert.ToInt32(textBoxSearch.Text)))
            {
                _IsDeleteControlsVisible(false);
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("An Error Occuer When Try To Delete This Doctor !", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
