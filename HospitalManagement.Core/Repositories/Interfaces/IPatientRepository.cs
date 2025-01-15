using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Enums;
using HospitalManagement.Core.Models;
using System.Collections.Generic;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IPatientRepository
    {
		(DatabaseResponse addReceiptResponse, DatabaseResponse updatePatientResponse) DischargePatient(int patientId,
                                                                                                            decimal paymentAmount,
                                                                                                            StateAtDischarge stateAtDischarge
                                                                                                        );
        DatabaseResponse<decimal> GetTotalAmountPaidByPatients();
        DatabaseResponse<List<Patient>> GetAllPatientsWithReceipts();
        DatabaseResponse AddPatient(Patient patient);
        DatabaseResponse RemovePatient(int patientId);
        DatabaseResponse<List<Patient>> GetAllPatients();
        DatabaseResponse<Patient> GetPatient(int patientId);
    }
}
