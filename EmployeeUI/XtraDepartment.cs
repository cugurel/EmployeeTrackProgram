using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
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

        void GetList()
        {
            var result = _departmentService.GetList();
            gridControl1.DataSource = result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Department department = new Department
            {
                Name = txtDepartmentName.Text,
                Status = true
            };

            var result = _departmentService.Add(department);
            if (result)
            {
                MessageBox.Show("Departman başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetList();
            }
            else
            {
                MessageBox.Show("Hatalı ekleme", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryBtnDelete_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as Department).Name}Silmek istiyor musunuz", "Sil?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var department = (gridView1.GetFocusedRow() as Department);
                _departmentService.Delete(department);
                GetList();
            }
        }
    }
}