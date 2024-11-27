using HospitalManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Presentation
{
    public partial class AddDoctorForm : Form
    {
        Doctor doctor;
        public AddDoctorForm()
        {
            doctor = new Doctor();
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            doctor.Salary = numericUpDown1.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            doctor.Name = NameBox.Text;
        }

        private void AddDoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            doctor.Address = AddressBox.Text;
        }

        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            doctor.PhoneNumber = PhoneNumberBox.Text;
        }

        private void HireDatePicker_ValueChanged(object sender, EventArgs e)
        {
            doctor.DateTime = HireDatePicker.Value;
        }

        private void SpecializationBox_TextChanged(object sender, EventArgs e)
        {
            doctor.Specialization = SpecializationBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = Program.doctorRepository.AddDoctor(doctor);
            if (result.Success == false)
                MessageBox.Show("فشل في الاضافة تحقق من المعلومات");
            else
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
