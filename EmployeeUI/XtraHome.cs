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
        public XtraHome()
        {
            InitializeComponent();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        
        private void btnDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraDepartment department;
            department = new XtraDepartment();
            department.MdiParent = this;
            department.Show();
            
        }
    }
}