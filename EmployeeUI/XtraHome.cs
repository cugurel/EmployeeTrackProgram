using BusinessLayer.Abstract;
using Entities.Concrete;

namespace EmployeeUI
{
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmantService;
        private readonly IEmployeeService _employeeService;
        

        public XtraHome(IDepartmentService departmantService, IEmployeeService employeeService)
        {
            InitializeComponent();
            _departmantService = departmantService;
            _employeeService = employeeService;
        }


        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraDepartment department;
            department = new XtraDepartment(_departmantService);
            department.MdiParent = this;
            department.Show();

        }

        private void XtraHome_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployeeAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraEmployee employee;
            employee = new XtraEmployee(_departmantService, _employeeService);
            employee.MdiParent = this;
            employee.Show();
        }
    }
}