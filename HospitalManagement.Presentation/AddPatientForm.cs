using HospitalManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Presentation
{
    public partial class AddPatientForm : Form
    {
        public Patient patient = new Patient();
        public AddPatientForm()
        {
            InitializeComponent();
            DoctorCombo.DataSource = Program.doctorRepository.GetAllDoctors().Data;
            NurseBox.DataSource = Program.nurseRepository.GetAllNurses().Data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgeNumeric_ValueChanged(object sender, EventArgs e)
        {
            patient.Age = Convert.ToInt32(AgeNumeric.Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            patient.Affliction = AddressBox.Text;
        }

        private void DoctorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            patient.DoctorId = ((Doctor)DoctorCombo.SelectedItem).Id;
        }

        private void NurseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            patient.NurseId = ((Nurse)NurseBox.SelectedItem).Id;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var result = Program.patientRepository.AddPatient(patient);
            if (!result.Success)
            {
                MessageBox.Show("Failed, Check data.");
            }
            else
            {
                this.Close();
            }
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			patient.Name = textBox1.Text;
		}
	}
}
