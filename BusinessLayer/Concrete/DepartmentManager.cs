using BusinessLayer.Abstract;
using BusinessLayer.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Results;

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
            DepartmentValidator validationRules = new DepartmentValidator();
            ValidationResult validationResult = validationRules.Validate(department);
            IList<ValidationFailure> failures = validationResult.Errors;
            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            else
            {
                _departmentDal.Add(department);
                MessageBox.Show("Kaydetme işlemi başarıyla gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
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
            DepartmentValidator validationRules = new DepartmentValidator();
            ValidationResult validationResult = validationRules.Validate(department);
            IList<ValidationFailure> failures = validationResult.Errors;
            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            else
            {
                _departmentDal.Update(department);
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            
        }
    }
}