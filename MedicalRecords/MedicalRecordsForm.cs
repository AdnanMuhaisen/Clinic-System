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
    public partial class MedicalRecordsForm : BaseForm
    {
        private AddNewMedicalRecordForm _AddNewMedicalRecord;
        private DeleteAMediacalRecordForm _DeleteAMediacalRecord;
        private UpdateMedicalRecordForm _UpdateMedicalRecord;


        public MedicalRecordsForm()
        {
            InitializeComponent();
            _AddNewMedicalRecord = new AddNewMedicalRecordForm();
            _DeleteAMediacalRecord = new DeleteAMediacalRecordForm();
            _UpdateMedicalRecord = new UpdateMedicalRecordForm();
        }

        private void MedicalRecordsForm_Load(object sender, EventArgs e)
        {
            dataGridViewRecords.DataSource = _GetAllRecords();
        }

        private void createNewMedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_AddNewMedicalRecord.ShowDialog() == DialogResult.Cancel)
                this.Show();
            dataGridViewRecords.DataSource = _GetAllRecords();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_DeleteAMediacalRecord.ShowDialog() == DialogResult.Cancel)
                this.Show();
            dataGridViewRecords.DataSource = _GetAllRecords();
        }

        private DataTable _GetAllRecords()
            => clsMedicalRecord.GetAllRecords();

        private void updateMedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(_UpdateMedicalRecord.ShowDialog()==DialogResult.Cancel)
                this.Show();
            dataGridViewRecords.DataSource = _GetAllRecords();
        }
    }
}
