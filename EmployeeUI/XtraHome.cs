using Business.Abstract;
using DevExpress.XtraEditors;
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
    }
}