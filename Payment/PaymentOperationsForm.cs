using Clinic_System___Middle_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_System.Payment
{
    public partial class PaymentOperationsForm : BaseForm
    {
        private AddNewBillForm _AddNewBillForm;
        private DeleteABillForm _DeleteABillForm;

        public PaymentOperationsForm()
        {
            InitializeComponent();
            _AddNewBillForm = new AddNewBillForm();
            _DeleteABillForm = new DeleteABillForm();
        }

        private void PaymentOperationsForm_Load(object sender, EventArgs e)
        {
            dataGridViewBills.DataSource = clsBill.GetAllBills();
        }

        private void _UpdateBillsGrid()
            => dataGridViewBills.DataSource = clsBill.GetAllBills();

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_AddNewBillForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
            _UpdateBillsGrid();
        }

        private void toolStripMenuItemDeleteABill_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_DeleteABillForm.ShowDialog() == DialogResult.Cancel)
                this.Show();
            _UpdateBillsGrid();
        }

    }
}
