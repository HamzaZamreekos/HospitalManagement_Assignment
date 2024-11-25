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

        public static List<Doctor> doctors = new List<Doctor>();
        public static List<Nurse> nurses = new List<Nurse>();
        [STAThread]
        static void Main()
        {
            doctorRepository = new DoctorRepository();
            nurseRepository = new NurseRepository();
            doctors = doctorRepository.GetAllDoctors().Data;
            var res = nurseRepository.AddNurse(new Nurse {Address="3rd Avenue", Name="Akhmed", Salary=3.35m,PhoneNumber="0985642", WorkHours=8  });
            nurses = nurseRepository.GetAllNurses().Data;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
