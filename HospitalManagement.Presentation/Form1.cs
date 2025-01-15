using HospitalManagement.Core.Entities;
using HospitalManagement.Infrastructure.Oracle.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HospitalManagement.Presentation
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Program.doctors;
            dataGridView2.DataSource = Program.nurses;
            dataGridView3.DataSource = Program.patients;
            dataGridView4.DataSource = Program.tests;
            OperationsDataGrid.DataSource = Program.operations;
			dataGridView5.DataSource = Program.Hospitals;
			dataGridView6.DataSource = Program.Laboratories;
            dataGridView7.DataSource = Program.wards;

			dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
           DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            var wow = selectedRow;
            int id = Convert.ToInt32(selectedRow.Cells[2].Value);


            var result = Program.doctorRepository.RemoveDoctor(id);
            if(result.Success)
                dataGridView1.DataSource = Program.doctorRepository.GetAllDoctors().Data;
            else
            {
                MessageBox.Show("فشل الحذف");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDoctorForm add = new AddDoctorForm();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog();
            dataGridView1.DataSource = Program.doctorRepository.GetAllDoctors().Data;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNurseForm add = new AddNurseForm();
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog();
            dataGridView2.DataSource = Program.nurseRepository.GetAllNurses().Data;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var dialog = new DischargePatient();
                dialog.PatientId = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                dialog.ShowDialog();
            }
        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            var addPatient = new AddPatientForm();
            addPatient.StartPosition = FormStartPosition.CenterParent;
            addPatient.ShowDialog();
            var patients = Program.patientRepository.GetAllPatients().Data;
            patients.ForEach(x => x.Doctor = Program.doctorRepository.GetDoctor(x.DoctorId).Data);
            patients.ForEach(x => x.Nurse = Program.nurseRepository.GetNurse(x.NurseId).Data);
            dataGridView3.DataSource = patients;
        }

        private void OperationsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BestDoctor_Click(object sender, EventArgs e)
        {
			//var result= Program.doctorRepository.GetDoctorThatOperatedTheMost(DateTime.Now);
			var bestDoctor = new Presentation.BestDoctor();
			bestDoctor.ShowDialog();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void button3_Click(object sender, EventArgs e)
		{
            var addOperationDialog = new AddOperation();
            addOperationDialog.ShowDialog();
		}

		private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void AddHospital_Click(object sender, EventArgs e)
		{
            var dialog = new AddHospital();
            dialog.ShowDialog();
		}

		private void AddLab_Click(object sender, EventArgs e)
		{
			var dialog = new AddLaboratory();
			dialog.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var dialog = new AddWard();
			dialog.ShowDialog();
		}

		private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void liverFee_Click(object sender, EventArgs e)
        {
            var amount = Program.patientRepository.GetTotalAmountPaidByPatients();
            MessageBox.Show(amount.ToString());
        }

        private void GetPatient_Click(object sender, EventArgs e)
        {
            var amount = Program.patientRepository.GetTotalAmountPaidByPatients();
            MessageBox.Show(amount.Data.ToString());
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dialog = new AddTest();
            dialog.ShowDialog();
        }
    }
}
