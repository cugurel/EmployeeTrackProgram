using BusinessLayer.Abstract;

namespace EmployeeUI
{
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmantService;

        public XtraHome(IDepartmentService departmantService)
        {
            InitializeComponent();
            _departmantService = departmantService;
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
            employee = new XtraEmployee();
            employee.MdiParent = this;
            employee.Show();
        }
    }
}