using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        bool Add(Department department);
        bool Update(Department department);
        void Delete(Department department);
        Department Get(int id);
        List<Department> GetList();
    }
}
