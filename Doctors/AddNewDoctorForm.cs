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
    public partial class AddNewDoctorForm : Form
    {
        public AddNewDoctorForm()
        {
            InitializeComponent();
        }

        private void _ClearPanelControlsContent(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c.Name.StartsWith("textBox"))
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

        private void _ClearGroupBoxControlsContent(GroupBox g)
        {
            foreach (Control c in g.Controls)
            {
                if (c.Name.StartsWith("textBox"))
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

        private void _ClearControls()
        {
            _ClearPanelControlsContent(this.panelCollectData);
            _ClearGroupBoxControlsContent(this.groupBoxContactInfo);
            dateTimePicker1.Value = DateTime.Now;
            radioButtonNeutral.Checked = true;
        }

        private bool _IsAllDataAreFilled()
        {
            foreach (Control c in this.panelCollectData.Controls)
            {
                if (c.Name.StartsWith("textBox"))
                {
                    if (_IsTextBoxEmpty((TextBox)c))
                    {
                        MessageBox.Show("Enter All Data Please !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            if (!clsInputValidation.IsPhoneNumber(textBoxPhoneNumber.Text))
            {
                MessageBox.Show("Enter All Data Please !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_IsTextBoxEmpty(textBoxAddress))
            {
                MessageBox.Show("Enter All Data Please !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!clsInputValidation.IsEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Enter All Data Please !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private char _GetThePatientGender()
        {
            if (radioButtonFemale.Checked)
                return Convert.ToString(radioButtonFemale.Tag).First();
            else if (radioButtonMale.Checked)
                return Convert.ToString(radioButtonMale.Tag).First();
            else
                return Convert.ToString(radioButtonNeutral.Tag).First();
        }
        private bool _IsTextBoxEmpty(TextBox Tb)
        {
            return (Tb.Text == string.Empty) || (Tb.Text == default);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _ClearControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsDoctor.IsDoctorExist(Convert.ToInt32(textBoxPersonID.Text)))
            {
                MessageBox.Show($"The Doctor With ID {Convert.ToInt32(textBoxPersonID.Text)} Already Exist !", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_IsAllDataAreFilled())
            {
                clsDoctor NewDoctor = new clsDoctor();
                NewDoctor.PersonID  = Convert.ToInt32(textBoxPersonID.Text.Trim());
                NewDoctor.FirstName = textBoxFirstname.Text.Trim();
                NewDoctor.LastName  = textBoxLastName.Text.Trim();
                NewDoctor.Gender = _GetThePatientGender();
                NewDoctor.DateOfBirth = dateTimePicker1.Value.Date;
                NewDoctor.PhoneNumber = textBoxPhoneNumber.Text.Trim();
                NewDoctor.Email = textBoxEmail.Text.Trim();
                NewDoctor.Address = textBoxAddress.Text.Trim();
                NewDoctor.Specialization = textBoxSpecialization.Text.Trim();

                if (NewDoctor.Save())
                {
                    MessageBox.Show("Saved Successfully", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    _ClearControls();
                }
                else
                    MessageBox.Show("An Error Occuer When Saving The Doctor !", "Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
