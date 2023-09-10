using BusinessLayer.Abstract;
using BusinessLayer.Validation.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public bool Add(Employee employee)
        {
            bool validation = ValidationTool.Validate(new EmployeeValidator(), employee);
            if (validation)
            {
                var result = _employeeDal.CheckIdentityNumber(employee.IdentityNumber);
                if (result > 0)
                {
                    MessageBox.Show("Bu kimlik numarası ile bir çalışan kayıtlı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _employeeDal.Add(employee);
                MessageBox.Show("Kaydetme işlemi başarıyla gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }
    }
}
