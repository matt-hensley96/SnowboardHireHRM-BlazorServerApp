﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnowboardHireHRM.Shared;

namespace SnowboardHireHRM.Api.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
    }
}
