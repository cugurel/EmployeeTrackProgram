using Entities.Concrete;
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
        Department Get(int id);
        List<Department> GetList();
    }
}
