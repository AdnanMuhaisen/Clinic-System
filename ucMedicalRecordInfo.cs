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
    public partial class ucMedicalRecordInfo : UserControl
    {
        public ucMedicalRecordInfo()
        {
            InitializeComponent();
        }

        private void MedicalRecordInfo_Load(object sender, EventArgs e)
        {

        }


        public void FillControlInfo(int RecordID,string VisitDescription,string Diagnosis,string AdditionalNotes)
        {
            lblRecordID.Text = "Record ID : " + RecordID.ToString();
            lblVisitDescription.Text = "Visit Description : " + VisitDescription;
            lblDiagnosis.Text = "Diagnosis : " + Diagnosis;
            lblAdditionalNotes.Text = "Additional Notes : " + AdditionalNotes;
        }

    }
}
