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
	public partial class BestDoctor : Form
	{
		string doctorName;
		string numberOfOperations;
		string price;

		public BestDoctor()
		{
			var result = Program.doctorRepository.GetDoctorThatOperatedTheMost(DateTime.Now.AddYears(-1));
			doctorName = result.Data.doctorName;
			numberOfOperations = result.Data.operations.ToString();
			price = result.Data.price.ToString();
			InitializeComponent();
			this.label2.Text = doctorName;
			label3.Text = numberOfOperations;
			label4.Text = price;
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void BestDoctor_Load(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
