using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;


namespace BusinessLayer.Abstract
{
    public interface IDepartmentService
    {
        bool Add(Department department);
        bool Update(Department department);
        void Delete(Department department);
        Department Get(int id);
        int GetDepartmentId(string departmentName);
        List<Department> GetList();
    }
}
