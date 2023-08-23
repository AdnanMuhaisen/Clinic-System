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
    public partial class UpdateMedicalRecordForm : BaseForm
    {
        clsMedicalRecord TargetRecord;
        string VisitDescription = default, Diagnosis = default, AdditionalNotes = default;

        public UpdateMedicalRecordForm()
        {
            InitializeComponent();
        }

        private void UpdateMedicalRecordForm_Load(object sender, EventArgs e)
        {
            _FillRecordsIDComboBox();
        }

        private void _FillRecordsIDComboBox()
        {
            DataTable dt = clsMedicalRecord.GetRecordsID();

            if (dt == null)
                return;

            foreach (DataRow dr in dt.Rows)
                comboBoxRecordsID.Items.Add(dr["RecordID"]);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsFormDataCompleted()
        {
            if (comboBoxRecordsID.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxRecordsID, "Select A Record !");
                comboBoxRecordsID.Focus();
                return false;
            }
            else 
                errorProvider1.SetError(comboBoxRecordsID, string.Empty);


            if (textBoxVisitDescription.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxVisitDescription, "Required !");
                textBoxVisitDescription.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBoxVisitDescription, string.Empty);
                this.VisitDescription = textBoxVisitDescription.Text;
            }

            if (textBoxDiagnosis.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxDiagnosis, "Required !");
                textBoxDiagnosis.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBoxDiagnosis, string.Empty);
                this.Diagnosis = textBoxDiagnosis.Text;
            }
            this.AdditionalNotes = textBoxAdditionalNotes.Text;
            return true;
        }

        private void comboBoxRecordsID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRecordsID.SelectedIndex != -1)
            {
                _IsUpdateFormControlsVisible(true);
                textBoxRecordID.Text = comboBoxRecordsID.Text;
                this.TargetRecord = clsMedicalRecord.Find(int.Parse(comboBoxRecordsID.SelectedItem.ToString()));
                _FillFormData();
            }
            else 
                _IsUpdateFormControlsVisible(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_IsFormDataCompleted())
                return;

            TargetRecord.VisitDescription = this.VisitDescription;
            TargetRecord.Diagnosis = this.Diagnosis;
            TargetRecord.AdditionalNotes = this.AdditionalNotes;

            if (this.TargetRecord.Save())
            {
                MessageBox.Show("Updated Successfully", "MediSync", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _Clear();
                return;
            }
            else
                MessageBox.Show("An Error Occuer When Try To Update The Record !", "MediSync", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void _Clear()
        {
            comboBoxRecordsID.SelectedIndex = -1;
            textBoxVisitDescription.Text = textBoxDiagnosis.Text = textBoxAdditionalNotes.Text = string.Empty;
        }

        private void _IsUpdateFormControlsVisible(bool Visible)
        {
            panelUpdateRecord.Visible = Visible;
            btnUpdate.Visible = btnClose.Visible = Visible;
        }

        private void _FillFormData()
        {
            if (this.TargetRecord == null)
                return;

            textBoxRecordID.Text = TargetRecord.RecordID.ToString();
            textBoxVisitDescription.Text = TargetRecord.VisitDescription;
            textBoxDiagnosis.Text += TargetRecord.Diagnosis;
            textBoxAdditionalNotes.Text = TargetRecord.AdditionalNotes;
        }
    }
}
