using System;
using System.Diagnostics;
using System.Windows.Forms;
using HospitalManagement.Core.Repositories.Interfaces;
using HospitalManagement.Infrastructure.Oracle.Repositories;
using HospitalManagement.Core.Entities;
using System.Collections.Generic;

namespace HospitalManagement.Presentation
{
    internal static class Program
    {
        public static IDoctorRepository doctorRepository;
        public static INurseRepository nurseRepository;
        public static IPatientRepository patientRepository;
        public static IOperationRepository operationRepository;

        public static List<Doctor> doctors = new List<Doctor>();
        public static List<Nurse> nurses = new List<Nurse>();
        public static List<Patient> patients = new List<Patient>();
        public static List<Operation> operations = new List<Operation>();

        [STAThread]
        static void Main()
        {
            doctorRepository = new DoctorRepository();
            nurseRepository = new NurseRepository();
            patientRepository = new PatientRepository();
            operationRepository = new OperationRepository();

            doctors = doctorRepository.GetAllDoctors().Data;
            nurses = nurseRepository.GetAllNurses().Data;
            //doctorRepository.GetDoctorThatOperatedTheMost(DateTime.Now);
            patients = patientRepository.GetAllPatients().Data;
            patients.ForEach(x => x.Doctor = doctorRepository.GetDoctor(x.DoctorId).Data);
            patients.ForEach(x => x.Nurse = nurseRepository.GetNurse(x.NurseId).Data);

            //operationRepository.AddOperation(new Operation { Cost = 50.20m, Date = DateTime.Now, Name = "جراحة كبد", OperatingDoctorId = 48 });
            operations = operationRepository.GetAllOperations().Data;
            operations.ForEach(x => x.OperatingDoctor = doctorRepository.GetDoctor(x.OperatingDoctorId).Data);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
