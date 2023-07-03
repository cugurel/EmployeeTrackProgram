using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public bool Add(Department department)
        {
            _departmentDal.Add(department);
            return true;
        }

        public void Delete(Department department)
        {
            _departmentDal.Delete(department);
            
        }

        public Department Get(int id)
        {
            return _departmentDal.Get(id);
        }

        public List<Department> GetList()
        {
            return _departmentDal.GetList();
        }

        public bool Update(Department department)
        {
            _departmentDal.Update(department);
            return true;
        }
    }
}
