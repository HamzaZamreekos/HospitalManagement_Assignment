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
	public partial class AddWard : Form
	{
		public List<int> nursesIds = new List<int>();
		public List<int> doctorsIds = new List<int>();
		Ward ward = new Ward();
		public AddWard()
		{
			InitializeComponent();
			this.NursesBox.DataSource = Program.nurseRepository.GetAllNurses().Data;
			this.DoctorsBox.DataSource = Program.doctorRepository.GetAllDoctors().Data;
			this.hospitalsBox.DataSource = Program.hospitalRepository.GetAllHospitals().Data;
		}

		private void NameBox_TextChanged(object sender, EventArgs e)
		{
			ward.Name = NameBox.Text;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			ward.PhoneNumber = textBox1.Text;
		}

		private void ok_Click(object sender, EventArgs e)
		{
			ward.NumberOfEmployees = doctorsIds.Count + nursesIds.Count;
			var result = Program.wardRepository.AddWard(ward, doctorsIds, nursesIds);
			if(result.Success == false)
			{
				MessageBox.Show("فشل");
			}
		}

        private void NursesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nurse = ((Nurse)NursesBox.SelectedItem);
			nursesIds.Add(nurse.Id);
            this.NursesLabel.Text += ", " + nurse.Name;
        }

        private void DoctorsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			var doctor = ((Doctor)DoctorsBox.SelectedItem);
			doctorsIds.Add(doctor.Id);
			this.DoctorsLabel.Text += ", " + doctor.Name;
        }
        private void hospitalsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ward.HospitalId = ((Hospital)hospitalsBox.SelectedValue).Id;
        }

        private void AddWard_Load(object sender, EventArgs e)
        {

        }

    }
}
