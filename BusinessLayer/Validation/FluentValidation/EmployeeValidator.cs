using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage("Personel adı boş olamaz");
            RuleFor(r => r.Name).MinimumLength(3).WithMessage("Personel adı en az 3 karakter olmalıdır");
            RuleFor(r => r.Name).MaximumLength(25).WithMessage("Personel adı en fazla 10 karakter olmalıdır");
            
        }
    }
}
