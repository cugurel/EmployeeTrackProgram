using BusinessLayer.Abstract;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class XtraEmployee : DevExpress.XtraEditors.XtraForm
    {

        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        public XtraEmployee(IDepartmentService departmentService, IEmployeeService employeeService)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _employeeService = employeeService;
        }

        int departmentId = 0;

        private void XtraEmployee_Load(object sender, EventArgs e)
        {
            var departments = _departmentService.GetList();

            foreach (var department in departments)
            {
                txtDepartment.Properties.Items.Add(department.Name);
            }

            txtBirthDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtStartDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            txtSalary.Focus();
            txtSalary.SelectAll();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentId = _departmentService.GetDepartmentId(txtDepartment.Text);
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Employee employee = new Employee
            {
                BirthDate = Convert.ToDateTime(txtBirthDate.Text),
                DepartmentId = departmentId,
                LastName = txtLastname.Text,
                Name = txtName.Text,
                Salary = Convert.ToDecimal(txtSalary.Text),
                StartingDate = Convert.ToDateTime(txtStartDate.Text)
                
            };

            var result = _employeeService.Add(employee);
            if(result)
            {

            }
        }
    }
}