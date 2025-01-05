using HospitalManagement.Core.Entities;
using HospitalManagement.Infrastructure.Oracle.Repositories;
using System;
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
            OperationsDataGrid.DataSource = Program.operations;

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
            dataGridView1.DataSource = Program.doctorRepository.GetDoctorThatOperatedTheMost(DateTime.Now);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
