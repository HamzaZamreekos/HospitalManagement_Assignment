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
	public partial class AddHospital : Form
	{
		Hospital hospital = new Hospital();
		public AddHospital()
		{
			InitializeComponent();
			DoctorComboBox.DataSource = Program.doctorRepository.GetAllDoctors().Data;
		}

		private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
		{
			hospital.PhoneNumber = PhoneNumberBox.Text;
		}

		private void AddressBox_TextChanged(object sender, EventArgs e)
		{
			hospital.Address = AddressBox.Text;
		}

		private void DoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			hospital.ManagingDoctorId = ((Doctor)DoctorComboBox.SelectedItem).Id;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Program.hospitalRepository.AddHospital(hospital);
		}
	}
}
