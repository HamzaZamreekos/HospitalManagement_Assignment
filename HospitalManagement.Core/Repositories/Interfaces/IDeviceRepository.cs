using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System.Collections.Generic;

namespace HospitalManagement.Core.Repositories.Interfaces
{
	public interface IDeviceRepository
	{
		DatabaseResponse AddDevice(Device device);
		DatabaseResponse<List<Device>> GetAllDevices();
		DatabaseResponse<Device> GetDevice(int deviceId);
		DatabaseResponse RemoveDevice(int deviceId);
	}
}
