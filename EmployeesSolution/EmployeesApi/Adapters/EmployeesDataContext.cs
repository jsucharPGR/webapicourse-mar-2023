﻿using Microsoft.EntityFrameworkCore;

namespace EmployeesApi.Adapters;

public class EmployeesDataContext : DbContext
{

    public EmployeesDataContext(DbContextOptions<EmployeesDataContext> options) : base(options)
    {

    }

    // You create a property of type DbSet<T> for each Entity you want this to take control of.

    public DbSet<DepartmentEntity> Departments { get; set; }

    public DbSet<DepartmentEntity> Employees { get; set; } 
}
