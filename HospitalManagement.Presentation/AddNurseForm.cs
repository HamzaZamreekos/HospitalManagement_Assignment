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
    public partial class AddNurseForm : Form
    {
        public Nurse nurse = new Nurse();
        public AddNurseForm()
        {
            InitializeComponent();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            nurse.Name = NameBox.Text;
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            nurse.Address = AddressBox.Text;
        }

        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            nurse.PhoneNumber = PhoneNumberBox.Text;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            nurse.WorkHours = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nurse.Salary = numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = Program.nurseRepository.AddNurse(nurse);
            if (!res.Success)
            {
                MessageBox.Show("Failed, Check data.");
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
