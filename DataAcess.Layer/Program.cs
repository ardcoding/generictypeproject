using Microsoft.EntityFrameworkCore;
using EmployeesDb.Entities;
using System.Collections.Generic;

public class EmployeesDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Database=Employee;Integrated Security=True;;Encrypt=False;Trust Server Certificate=False;");
    }
}

class Start
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");
    }
}