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
        public static List<Doctor> doctors = new List<Doctor>();
        [STAThread]
        static void Main()
        {
            doctorRepository = new DoctorRepository();
            doctors = doctorRepository.GetAllDoctors().Data;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
