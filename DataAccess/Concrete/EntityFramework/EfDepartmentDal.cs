﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : IDepartmentDal
    {
        public void Add(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Departments.Add(department);
                context.SaveChanges();
            }
        }

        public bool CheckDepartmentInUse(int departmentId)
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Employees.Where(e=>e.DepartmentId == departmentId);
                return (result.Count() > 0 ? true : false);
            }
        }

        public void Delete(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Departments.Remove(department);
                context.SaveChanges();
            }
        }

        public Department Get(int id)
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Departments.Where(c=>c.Id == id).FirstOrDefault();
                return result;
            }
        }

        public List<Department> GetList()
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Departments.ToList();
                return result;
            }
        }

        public void StatusChange(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                if (department.Status)
                {
                    department.Status = false;
                }
                else
                {
                   department.Status=true;
                }
                context.Departments.Update(department);
                context.SaveChanges();
            }
        }

        public void Update(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                context.Departments.Update(department);
                context.SaveChanges();
            }
        }
    }
}
