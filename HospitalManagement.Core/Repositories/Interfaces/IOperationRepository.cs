using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IOperationRepository
    {
        DatabaseResponse AddOperation(Operation operation);
        DatabaseResponse<List<Operation>> GetAllOperations();
        DatabaseResponse<Operation> GetOperation(int operationId);
    }
}
