using System;
using System.Diagnostics;
using System.Windows.Forms;
using HospitalManagement.Core.Repositories.Interfaces;
using HospitalManagement.Infrastructure.Oracle.Repositories;

namespace HospitalManagement.Presentation
{
    internal static class Program
    {
        public static IDoctorRepository doctorRepository;
        [STAThread]
        static void Main()
        {
            doctorRepository = new DoctorRepository();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
