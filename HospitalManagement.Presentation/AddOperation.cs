using HospitalManagement.Core.Entities;
using System;
using System.Windows.Forms;

namespace HospitalManagement.Presentation
{
	public partial class AddOperation : Form
	{
		Operation operation = new Operation();
		public AddOperation()
		{
			InitializeComponent();
			comboBox1.DataSource = Program.doctorRepository.GetAllDoctors().Data;
			comboBox2.DataSource = Program.patientRepository.GetAllPatients().Data;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			operation.OperatingDoctorId = ((Doctor)(comboBox1.SelectedItem)).Id;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			operation.PatientId = ((Patient)(comboBox2.SelectedItem)).Id;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			operation.DateTime = DateTime.Now.AddYears(-1);
			Program.operationRepository.AddOperation(operation);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			operation.Name = textBox1.Text;
		}

        private void costBox_ValueChanged(object sender, EventArgs e)
        {
			operation.Cost = costBox.Value;
        }
    }
}
