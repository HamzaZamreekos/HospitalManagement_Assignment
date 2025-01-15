using System;
using System.Windows.Forms;
using HospitalManagement.Core.Repositories.Interfaces;
using HospitalManagement.Infrastructure.Oracle.Repositories;
using HospitalManagement.Core.Entities;
using System.Collections.Generic;
using static HospitalManagement.Infrastructure.Oracle.Repositories.TestsRepository;

namespace HospitalManagement.Presentation
{
    internal static class Program
    {
        public static ILaboratoryRepository laboratoryRepository;
        public static IDeviceRepository deviceRepository;
        public static IOperationRepository operationRepository;
		public static IHospitalRepository hospitalRepository;
        public static IPatientRepository patientRepository;
        public static IDoctorRepository doctorRepository;
        public static ITestsRepository testsRepository;
        public static INurseRepository nurseRepository;
        public static IWardRepository wardRepository;

        public static List<Test> tests = new List<Test>();
        public static List<Ward> wards = new List<Ward>();
        public static List<Nurse> nurses = new List<Nurse>();
        public static List<Device> devices = new List<Device>();
        public static List<Doctor> doctors = new List<Doctor>();
        public static List<Patient> patients = new List<Patient>();
        public static List<Hospital> Hospitals = new List<Hospital>();
        public static List<Operation> operations = new List<Operation>();
        public static List<Laboratory> Laboratories = new List<Laboratory>();

        [STAThread]
        static void Main()
        {
            operationRepository = new OperationRepository();
			doctorRepository = new DoctorRepository(); 
			testsRepository = new TestRepository();
			wardRepository = new WardRepository();
            nurseRepository = new NurseRepository();
			deviceRepository = new DeviceRepository();
            patientRepository = new PatientRepository();
			hospitalRepository = new HospitalRepository();
			laboratoryRepository = new LaboratoryRepository();

            devices = deviceRepository.GetAllDevices().Data;
            Laboratories = laboratoryRepository.GetAllLaboratories().Data;
            Laboratories.ForEach(x => x.Ward = wardRepository.GetWard(x.WardId).Data );
			Hospitals = hospitalRepository.GetAllHospitals().Data;
			doctors = doctorRepository.GetAllDoctors().Data;
            nurses = nurseRepository.GetAllNurses().Data;
			tests = testsRepository.GetAllTests().Data;
            tests.ForEach(x => x.Laboratory = laboratoryRepository.GetLaboratory(x.LaboratoryId).Data );
            tests.ForEach(x => x.Patient = patientRepository.GetPatient(x.PatientId).Data );
            patients = patientRepository.GetAllPatients().Data;
            patients.ForEach(x => x.Doctor = doctorRepository.GetDoctor(x.DoctorId).Data);
            patients.ForEach(x => x.Nurse = nurseRepository.GetNurse(x.NurseId).Data);

            operations = operationRepository.GetAllOperations().Data;
            operations.ForEach(x => x.Patient = patientRepository.GetPatient(x.PatientId).Data);
            operations.ForEach(x => x.OperatingDoctor = doctorRepository.GetDoctor(x.OperatingDoctorId).Data);
            Hospitals.ForEach(x => x.ManagingDoctor = doctorRepository.GetDoctor(x.ManagingDoctorId).Data);
            wards = wardRepository.GetAllWards().Data;
            wards.ForEach(x => x.Hospital = Program.hospitalRepository.GetHospital(x.HospitalId).Data);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
