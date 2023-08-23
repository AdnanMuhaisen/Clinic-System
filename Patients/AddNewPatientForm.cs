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
    public partial class AddNewPatientForm : Form
    {
        public AddNewPatientForm()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            _ClearControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsTextBoxEmpty(TextBox Tb)
        {
            return (Tb.Text == string.Empty) || (Tb.Text == default);
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
            if (_IsTextBoxEmpty(textBoxPhoneNumber) || (textBoxPhoneNumber.Text.Length != 10))
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsAllDataAreFilled())
            {
                if (clsPatient.IsPatientExist(Convert.ToInt32(textBoxPersonID.Text.Trim())))
                {
                    MessageBox.Show($"The Person With The ID {Convert.ToInt32(textBoxPersonID.Text)} Already Exist !",
                        "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _ClearControls();
                    return;
                }

                clsPatient NewPatient = new clsPatient();
                NewPatient.PersonID = Convert.ToInt32(textBoxPersonID.Text.Trim());
                NewPatient.FirstName = textBoxFirstname.Text.Trim();
                NewPatient.LastName = textBoxLastName.Text.Trim();
                NewPatient.Gender = _GetThePatientGender();
                NewPatient.DateOfBirth = dateTimePicker1.Value.Date;
                NewPatient.PhoneNumber= textBoxPhoneNumber.Text.Trim();
                NewPatient.Email = textBoxEmail.Text.Trim() ;
                NewPatient.Address = textBoxAddress.Text.Trim();

                if (NewPatient.Save())
                {
                    MessageBox.Show("Saved Successfully", "Saving Message", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    _ClearControls();
                }
                else
                {
                    MessageBox.Show("An Error Occuer When Try To Save This Patient !", "Saving Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
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

        private void textBoxPersonID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
