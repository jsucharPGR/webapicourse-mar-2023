using System.Runtime.ExceptionServices;

namespace EmployeesApi.Models;

 
    //{
    //    "total": 18,
    //    "fullTime": 10,
    //    "partTime": 0
    //}

public record EmployeeSummaryResponse(int Total, int FullTime, int PartTime, string DepartmentFilter);

public record ContactInformation(string Id, string FirstName, string LastName, string Department);

public record EmployeeResponse(string Id, NameInformation NameInformation, WorkDetails WorkDetails, Dictionary<string, Dictionary<string, string>> ContactInformation); 
public record NameInformation(string FirstName, string LastName); 
public record WorkDetails(string Department);

