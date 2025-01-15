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
    public partial class AddTest : Form
    {
        Test test = new Test();
        public AddTest()
        {
            InitializeComponent();
            this.patientBox.DataSource = Program.patients;
            this.LaboratoryBox.DataSource = Program.Laboratories;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            test.PatientId = ((Patient)(patientBox.SelectedValue)).Id;
        }

        private void LaboratoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            test.LaboratoryId = ((Laboratory)(LaboratoryBox.SelectedValue)).Id;
        }
        private void ok_Click(object sender, EventArgs e)
        {
            var result = Program.testsRepository.AddTest(test);
            if(result.Success == false)
            {
                MessageBox.Show("فشل");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            test.Name = textBox1.Text;
        }

        private void AddTest_Load(object sender, EventArgs e)
        {

        }

    }
}
