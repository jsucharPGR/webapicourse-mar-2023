using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace EmployeesApi.Domain;

public class DepartmentsLookup : ILookupDepartments
{
    private readonly EmployeesDataContext _context;
    private readonly MapperConfiguration _config;

    public DepartmentsLookup(EmployeesDataContext context, MapperConfiguration config)
    {
        _context = context;
        _config = config;
    }

    public async Task<List<DepartmentItem>> GetDepartmentsAsync()
    {
        // Never use .Result! Always use the Async version of methods, and await them.

        var response = await _context.Departments
                //.Where(dept => dept.Code != "sales")
                .OrderBy(dept => dept.Code)
                .ProjectTo<DepartmentItem>(_config)
              //.Select(dept => new DepartmentItem(dept.Code, dept.Description))
              
              .ToListAsync();


        return response;

    }
}
