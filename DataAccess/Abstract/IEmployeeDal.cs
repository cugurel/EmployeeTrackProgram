﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal
    {
        void Add(Employee employee);
        List<Employee> GetAll();
        int CheckIdentityNumber(string identity);
    }
}
