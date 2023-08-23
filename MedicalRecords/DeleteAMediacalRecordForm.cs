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
    public partial class DeleteAMediacalRecordForm : BaseForm
    {
        int MediacalRecordID;

        public DeleteAMediacalRecordForm()
        {
            InitializeComponent();
        }

        private void DeleteAMediacalRecordForm_Load(object sender, EventArgs e)
        {
            _FillRecordsIDComboBox();
        }

        private void _FillRecordsIDComboBox()
        {
            comboBoxRecordsID.Items.Clear();
            DataTable dataTable = clsMedicalRecord.GetRecordsID();

            if (dataTable == null)
                return;

            foreach (DataRow dr in dataTable.Rows)
                comboBoxRecordsID.Items.Add(dr["RecordID"].ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsMedicalRecord.DeleteAMedicalRecord(MediacalRecordID))
            {
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Update The Combobox Content :
                _FillRecordsIDComboBox();
                _Clear();
            }
            else
            {
                MessageBox.Show("An Error Occuer When Try To Delete This Record", "Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxRecordsID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRecordsID.SelectedIndex == -1)
                return;

            clsMedicalRecord Record = clsMedicalRecord.Find(int.Parse(comboBoxRecordsID.SelectedItem.ToString()));
            if (Record != null)
            {
                ucMedicalRecordInfo1.Visible = true;
                ucMedicalRecordInfo1.FillControlInfo((int)Record.RecordID, Record.VisitDescription, Record.Diagnosis,
                    Record.AdditionalNotes);
                this.MediacalRecordID = (int)Record.RecordID;
                btnDelete.Visible = btnClose.Visible = true ;
            }
            else
            {
                ucMedicalRecordInfo1.Visible = false;
                btnDelete.Visible = btnClose.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _Clear()
        {
            ucMedicalRecordInfo1.Visible = false;
            btnDelete.Visible = btnClose.Visible = false ;
            comboBoxRecordsID.SelectedIndex = -1;
        }
    }
}
