using Microsoft.EntityFrameworkCore;

namespace EmployeesApi.Domain;

public class DepartmentsLookup
{
    private readonly EmployeesDataContext _context;

    public DepartmentsLookup(EmployeesDataContext context)
    {
        _context = context;
    }


    //get list of departments
    public async Task<List<DepartmentItem>> GetDepartmentsAsync()
    {
        // TODO: Tomorrow, this will get data from out database.        
        //return new List<DepartmentItem>
        //{
        //    new DepartmentItem("DEV", "Developers"),
        //        new DepartmentItem("QA", "Quality Assurance Analysts"),
        //        new DepartmentItem("SALES", "Sales Engineers")

        //};
        var response = await _context.Departments
            .Select(dept => new DepartmentItem(dept.Code, dept.Description))
            .ToListAsync();
        return response;
    }
}
