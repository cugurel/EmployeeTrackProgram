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
    public class EfDepartmentDal : IDepartmentDal
    {
        public List<Department> GetList()
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Departments.ToList();
                return result;
            }
        }
    }
}
