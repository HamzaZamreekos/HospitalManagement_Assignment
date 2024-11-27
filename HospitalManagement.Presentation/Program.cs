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
            doctors = doctorRepository.GetAllDoctors().Data;
            nurses = nurseRepository.GetAllNurses().Data;
            doctorRepository.GetDoctorThatOperatedTheMost(DateTime.Now);
            //patientRepository.AddPatient(new Patient { Age = 12, Affliction = "homa", DoctorId = 25, NurseId = 5 });
            patients = patientRepository.GetAllPatients().Data;
            patients.ForEach(x => x.Doctor = Program.doctorRepository.GetDoctor(x.DoctorId).Data);
            patients.ForEach(x => x.Nurse = Program.nurseRepository.GetNurse(x.NurseId).Data);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
