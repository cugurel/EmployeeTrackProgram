using BusinessLayer.Abstract;
using BusinessLayer.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Results;
using Core.CrossCuttingConcerns;

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
            bool validation = ValidationTool.Validate(new DepartmentValidator(), department);
            if (validation)
            {
                _departmentDal.Add(department);
                MessageBox.Show("Kaydetme işlemi başarıyla gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
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
            bool validation = ValidationTool.Validate(new DepartmentValidator(), department);
            if (validation)
            {
                _departmentDal.Update(department);
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}