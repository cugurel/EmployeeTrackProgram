namespace EmployeeUI
{
    partial class XtraEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraEmployee));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtIdentity = new DevExpress.XtraEditors.TextEdit();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            txtDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
            txtStartDate = new DevExpress.XtraEditors.DateEdit();
            txtSalary = new DevExpress.XtraEditors.TextEdit();
            txtBirthDate = new DevExpress.XtraEditors.DateEdit();
            txtLastname = new DevExpress.XtraEditors.TextEdit();
            txtName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtIdentity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDepartment.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLastname.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtIdentity);
            layoutControl1.Controls.Add(txtDepartment);
            layoutControl1.Controls.Add(txtStartDate);
            layoutControl1.Controls.Add(txtSalary);
            layoutControl1.Controls.Add(txtBirthDate);
            layoutControl1.Controls.Add(txtLastname);
            layoutControl1.Controls.Add(txtName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 30);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1094, 621);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtIdentity
            // 
            txtIdentity.Location = new Point(130, 168);
            txtIdentity.MenuManager = barManager1;
            txtIdentity.Name = "txtIdentity";
            txtIdentity.Properties.MaxLength = 11;
            txtIdentity.Size = new Size(952, 22);
            txtIdentity.StyleController = layoutControl1;
            txtIdentity.TabIndex = 10;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnClose, btnAdd });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 2;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnClose), new DevExpress.XtraBars.LinkPersistInfo(btnAdd) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnClose
            // 
            btnClose.Caption = "Kapat";
            btnClose.Id = 0;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.LargeImage = (Image)resources.GetObject("btnClose.ImageOptions.LargeImage");
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnClose.ItemClick += btnClose_ItemClick;
            // 
            // btnAdd
            // 
            btnAdd.Caption = "Personel Ekle";
            btnAdd.Id = 1;
            btnAdd.ImageOptions.Image = (Image)resources.GetObject("btnAdd.ImageOptions.Image");
            btnAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnAdd.ImageOptions.LargeImage");
            btnAdd.Name = "btnAdd";
            btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnAdd.ItemClick += btnAdd_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(1094, 30);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 651);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1094, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 30);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 621);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1094, 30);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 621);
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(130, 142);
            txtDepartment.MenuManager = barManager1;
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            txtDepartment.Size = new Size(952, 22);
            txtDepartment.StyleController = layoutControl1;
            txtDepartment.TabIndex = 9;
            txtDepartment.SelectedIndexChanged += txtDepartment_SelectedIndexChanged;
            // 
            // txtStartDate
            // 
            txtStartDate.EditValue = null;
            txtStartDate.Location = new Point(130, 116);
            txtStartDate.MenuManager = barManager1;
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtStartDate.Size = new Size(952, 22);
            txtStartDate.StyleController = layoutControl1;
            txtStartDate.TabIndex = 8;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(130, 90);
            txtSalary.MenuManager = barManager1;
            txtSalary.Name = "txtSalary";
            txtSalary.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtSalary.Properties.MaskSettings.Set("mask", "n2");
            txtSalary.Properties.UseMaskAsDisplayFormat = true;
            txtSalary.Size = new Size(952, 22);
            txtSalary.StyleController = layoutControl1;
            txtSalary.TabIndex = 7;
            txtSalary.Enter += txtSalary_Enter;
            // 
            // txtBirthDate
            // 
            txtBirthDate.EditValue = null;
            txtBirthDate.Location = new Point(130, 64);
            txtBirthDate.MenuManager = barManager1;
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirthDate.Size = new Size(952, 22);
            txtBirthDate.StyleController = layoutControl1;
            txtBirthDate.TabIndex = 6;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(130, 38);
            txtLastname.MenuManager = barManager1;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(952, 22);
            txtLastname.StyleController = layoutControl1;
            txtLastname.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 12);
            txtName.MenuManager = barManager1;
            txtName.Name = "txtName";
            txtName.Size = new Size(952, 22);
            txtName.StyleController = layoutControl1;
            txtName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7 });
            Root.Name = "Root";
            Root.Size = new Size(1094, 621);
            Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 182);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(1074, 419);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtName;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(1074, 26);
            layoutControlItem1.Text = "Personel Adı";
            layoutControlItem1.TextSize = new Size(106, 16);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtLastname;
            layoutControlItem2.Location = new Point(0, 26);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(1074, 26);
            layoutControlItem2.Text = "Personel Soyadı";
            layoutControlItem2.TextSize = new Size(106, 16);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtBirthDate;
            layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            layoutControlItem3.Location = new Point(0, 52);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(1074, 26);
            layoutControlItem3.Text = "Doğum Tarihi";
            layoutControlItem3.TextSize = new Size(106, 16);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtSalary;
            layoutControlItem4.Location = new Point(0, 78);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(1074, 26);
            layoutControlItem4.Text = "Maaş";
            layoutControlItem4.TextSize = new Size(106, 16);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = txtStartDate;
            layoutControlItem5.Location = new Point(0, 104);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(1074, 26);
            layoutControlItem5.Text = "İşe Başlama Tarihi";
            layoutControlItem5.TextSize = new Size(106, 16);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = txtDepartment;
            layoutControlItem6.Location = new Point(0, 130);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(1074, 26);
            layoutControlItem6.Text = "Departmanı";
            layoutControlItem6.TextSize = new Size(106, 16);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = txtIdentity;
            layoutControlItem7.Location = new Point(0, 156);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(1074, 26);
            layoutControlItem7.Text = "T.C.";
            layoutControlItem7.TextSize = new Size(106, 16);
            // 
            // XtraEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 671);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "XtraEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Ekleme Formu";
            Load += XtraEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtIdentity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDepartment.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLastname.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtDepartment;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private DevExpress.XtraEditors.TextEdit txtSalary;
        private DevExpress.XtraEditors.DateEdit txtBirthDate;
        private DevExpress.XtraEditors.TextEdit txtLastname;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraEditors.TextEdit txtIdentity;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}