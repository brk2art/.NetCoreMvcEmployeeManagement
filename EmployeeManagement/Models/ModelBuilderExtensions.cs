using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mahmut",
                    Department = Dept.IT,
                    Email = "mahmut@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Ayşe",
                    Department = Dept.HR,
                    Email = "ayse@gmail.com"
                }
            );
        }
    }
}
