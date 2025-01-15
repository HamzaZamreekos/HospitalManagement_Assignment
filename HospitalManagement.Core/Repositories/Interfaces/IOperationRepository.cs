using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System.Collections.Generic;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IOperationRepository
    {
        DatabaseResponse AddOperation(Operation operation);
        DatabaseResponse<List<Operation>> GetAllOperations();
        DatabaseResponse<Operation> GetOperation(int operationId);
    }
}
