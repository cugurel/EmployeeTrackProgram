using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal
    {
        void Add(Department department);
        void Delete(Department department);
        void Update(Department department);
        void StatusChange(Department department);
        Department Get(int id);
        List<Department> GetList();
        bool CheckDepartmentInUse(int departmentId);
    }
}
