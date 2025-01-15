using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Enums;
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
    public partial class DischargePatient : Form
    {
        public int PatientId { get; set; }
        public DischargePatient()
        {
            InitializeComponent();
            patientState.DataSource = Enum.GetValues(typeof(StateAtDischarge));
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Program.patientRepository.DischargePatient(PatientId, priceField.Value, (StateAtDischarge)patientState.SelectedValue);
        }

        private void priceField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DischargePatient_Load(object sender, EventArgs e)
        {

        }

        private void patientState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
