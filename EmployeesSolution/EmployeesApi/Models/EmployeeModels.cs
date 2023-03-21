﻿using System.Runtime.ExceptionServices;

namespace EmployeesApi.Models;

 
    //{
    //    "total": 18,
    //    "fullTime": 10,
    //    "partTime": 0
    //}

public record EmployeeSummaryResponse(int Total, int FullTime, int PartTime, string DepartmentFilter);

public record EmployeeResponse(string Id, string FirstName, string LastName, string Department);
