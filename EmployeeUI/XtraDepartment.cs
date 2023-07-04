using DevExpress.XtraEditors;
using Entities.Concrete;
using BusinessLayer.Abstract;

namespace EmployeeUI
{
    public partial class XtraDepartment : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmentService;

        int _id;

        public XtraDepartment(IDepartmentService departmentService)
        {
            InitializeComponent();
            _departmentService = departmentService;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if(btnClose.Text == "Vazgeç")
            {
                Clear();
            }
            else
            {
                this.Close();
            }
            
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

        void Clear()
        {
            txtDepartmentName.Text = "";
            btnClose.Text = "Kapat";
            btnSave.Text = "Kaydet";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Güncelleme işlemi
            if (btnSave.Text == "Güncelle")
            {
                var finddepartment = _departmentService.Get(_id);
                finddepartment.Name = txtDepartmentName.Text;
                var result = _departmentService.Update(finddepartment);

                if (result)
                {
                    XtraMessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetList();
                    Clear();
                    
                }
            }
            else
            {
                Department department = new Department
                {
                    Name = txtDepartmentName.Text,
                    Status = true
                };

                var result = _departmentService.Add(department);
                if (result)
                {
                    GetList();
                }
                else
                {
                    MessageBox.Show("Hatalı ekleme", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void repositoryBtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as Department).Name}Silmek istiyor musunuz", "Sil?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var department = (gridView1.GetFocusedRow() as Department);
                _departmentService.Delete(department);
                GetList();
            }
        }

        private void reposiitoryBtnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _id = (gridView1.GetFocusedRow() as Department).Id;
            string name = (gridView1.GetFocusedRow() as Department).Name;
            txtDepartmentName.Text = name;

            btnSave.Text = "Güncelle";
            btnClose.Text = "Vazgeç";
        }
    }
}