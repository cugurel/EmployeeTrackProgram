using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Concrete.Dtos;

namespace BusinessLayer.Abstract
{
    public interface IDepartmentService
    {
        bool Add(Department department);
        bool Update(Department department);
        void StatusChange(Department department);
        void Delete(Department department);
        Department Get(int id);
        int GetDepartmentId(string departmentName);
        List<Department> GetList();
    }
}
