﻿using HospitalManagement.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Entities
{
    public class DischargeReceipt
    {
        public DateTime DateTime {  get; set; }
        public decimal PaymentAmount { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public StateAtDischarge StateAtDischarge { get; set; }
    }
}
