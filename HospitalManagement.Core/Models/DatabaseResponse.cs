using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Models
{
    public class DatabaseResponse<T> :  DatabaseResponse
    {
        public T Data { get; set; }
    }
    public class DatabaseResponse
    {
        public bool Success { get; set; }

    }

}
