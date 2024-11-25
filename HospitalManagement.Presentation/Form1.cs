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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Program.doctors;
            // ضبط خاصية Dock
            dataGridView1.Dock = DockStyle.Fill;

            // أو ضبط خاصية Anchor
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
    }
}
