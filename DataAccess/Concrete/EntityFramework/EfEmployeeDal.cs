using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : IEmployeeDal
    {
        public void Add(Employee employee)
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Employees.Add(employee);
                context.SaveChanges();
            }
        }
    }
}
