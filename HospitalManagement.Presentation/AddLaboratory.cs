using HospitalManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalManagement.Presentation
{
	public partial class AddLaboratory : Form
	{
		Laboratory laboratory = new Laboratory();
		List<Device> devices = new List<Device>(); 
		public AddLaboratory()
		{
			InitializeComponent();
			wardSelector.DataSource = Program.wardRepository.GetAllWards().Data;
		}

		private void nameBox_TextChanged(object sender, EventArgs e)
		{
			laboratory.Name = nameBox.Text;
		}

		private void NumberOfRooms_ValueChanged(object sender, EventArgs e)
		{
			laboratory.NumberOfRooms = Convert.ToInt32(NumberOfRooms.Value);
		}
		private void wardSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			laboratory.WardId = ((Ward)(wardSelector.SelectedItem)).Id;
		}


		private void AddDeviceButton_Click(object sender, EventArgs e)
		{
			var device = new Device();
			device.Name = deviceName.Text;
			devices.Add(device);
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			var request = Program.laboratoryRepository.AddLaboratory(laboratory);
			if(!request.Success)
			{
				MessageBox.Show("فشل");
				return;
			}
			var laboratoryId = request.Data;
			foreach (var device in devices)
			{
				device.LaboratoryId = laboratoryId;
				Program.deviceRepository.AddDevice(device);
			}
		}
		private void deviceName_TextChanged(object sender, EventArgs e)
		{

		}

	}
}
