using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
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
    public partial class XtraDepartment : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmentService;

        public XtraDepartment(IDepartmentService departmentService)
        {
            InitializeComponent();
            _departmentService = departmentService;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraDepartment_Load(object sender, EventArgs e)
        {
            var result = _departmentService.GetList();
            gridControl1.DataSource = result;
        }
    }
}