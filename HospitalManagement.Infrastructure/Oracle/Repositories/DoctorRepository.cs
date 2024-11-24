using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Repositories.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Numerics;
namespace HospitalManagement.Infrastructure.Oracle.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private OracleConnection _db;
        public DoctorRepository() 
        {
            _db = new OracleConnection(Static.ConnectionString);
            _db.Open();
        }
        public bool AddDoctor(Doctor doctor)
        {
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = "INSERT INTO Employee (Id, Name, PhoneNumber, Salary, Address, Specialization, DateTime)" +
                    $"VALUES ( , {doctor.Name}, {doctor.PhoneNumber}, {doctor.Salary},{doctor.Address},{doctor.Specialization}, {doctor.DateTime});";
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Doctor> GetAllDoctors()
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctor(int doctorId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveDoctor(int doctorId)
        {
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = $"REMOVE FROM Doctors where Id = {doctorId}";
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
