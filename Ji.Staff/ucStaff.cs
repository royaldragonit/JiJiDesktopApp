using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ji.Core;
using DevExpress.XtraEditors;
using Ji.Model;
using Ji.Commons;
using Ji.Services.Interface;
using Ji.Model.Entities;
using Ji.Model.StaffModels;
using Ji.Views;

namespace Ji.Staff
{
    public partial class ucStaff : ClientControl, IClientControl
    {
        /// <summary>
        /// Lưu tất cả User vào biến này để tái sử dụng khỏi truy vấn Database
        /// </summary>
        private List<LUsers> lstUser;
        private int UserID { get; set; }
        private readonly IStaffServices _staffServices;
        public ucStaff()
        {
            InitializeComponent();
            _staffServices = _staffServices.GetServices();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            LoadControl();
            BindingData();
        }
        public void LoadControl()
        {
            PanelPermisson.Controls.Clear();
            int NumberTableInRow = (PanelPermisson.Width - 6) / 5;
            int Width = (PanelPermisson.Width - 6) / NumberTableInRow;
            int i = 0;
            foreach (var item in Configure.ListSystemMenu)
            {
                CheckEdit chk = new CheckEdit();
                if (item.PermissionBasic)
                {
                    chk.Enabled = false;
                    chk.Checked = true;
                }
                chk.Name = item.NameNonUnicode;
                chk.Text = item.Name;
                chk.Tag = item.Id;
                chk.Width = NumberTableInRow;
                var font1 = chk.Font;
                chk.Font = new Font("Arial", 12, FontStyle.Bold);
                chk.Location = new Point(chk.Width * (i % Width), chk.Height * (i / Width));
                PanelPermisson.Controls.Add(chk);
                i++;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPhone.Text))
            {
                int? UserID = gridControl1.Tag?.ToInt();
                if (UserID == null)
                    UI.Warning("Không tìm thấy tài khoản mà bạn yêu cầu");
                else
                {
                    StaffInput staff = new StaffInput();
                    staff.StaffId = UserID.ToInt();
                    staff.Active = true;
                    staff.Address = txtAddress.Text;
                    staff.Birthday = txtBirthday.DateTime;
                    staff.CreateOn = DateTime.Now;
                    staff.FullName = txtName.Text;
                    staff.Password = txtPassword.Text;
                    staff.Phone = txtPhone.Text;
                    staff.Username = txtUsername.Text;
                    staff.ListPermissionId = ListPermissionId();
                    var data = _staffServices.CreateStaff(staff);
                    if (data.Success)
                        UI.SaveInformation();
                    else
                    {
                        UI.ShowError(data.Message["vn"]);
                    }
                }
            }
            else
                UI.Warning("Các thông tin bắt buộc khi : Tên, Tên tài khoản, Số điện thoại");
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {

                StaffInput staff = new StaffInput();
                staff.Active = true;
                staff.Address = txtAddress.Text;
                staff.Birthday = txtBirthday.DateTime;
                staff.CreateOn = DateTime.Now;
                staff.FullName = txtName.Text;
                staff.Password = txtPassword.Text;
                staff.Phone = txtPhone.Text;
                staff.Username = txtUsername.Text;
                staff.ListPermissionId = ListPermissionId();
                var data = _staffServices.CreateStaff(staff);
                if (data.Success)
                    UI.SaveInformation();
                else
                {
                    UI.ShowError(data.Message["vn"]);
                }
            }
            else
                UI.Warning("Các thông tin bắt buộc khi : Tên, Tên tài khoản, Mật khẩu , Số điện thoại");
        }
        private List<int> ListPermissionId()
        {
            List<int> data = new List<int>();
            foreach (var control in PanelPermisson.Controls)
            {
                if (control is CheckEdit)
                {
                    CheckEdit checkEdit = (CheckEdit)control;
                    if (checkEdit.Checked && checkEdit.Enabled)
                        data.Add(checkEdit.Tag.ToInt());
                }
            }
            return data;
        }
        public void BindingData()
        {
            List<LUsers> ds = _staffServices.ListStaff();
            gridControl1.DataSource = ds;
            if (ds != null && ds.Count() > 0)
            {
                lstUser = ds;
                gridControl1.Tag = ds?[0]?.Id;
                UserID = ds?[0]?.Id ?? 0;
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadData(e.FocusedRowHandle);
        }
        private void LoadData(int row)
        {
            txtName.Text = gridView1.GetRowCellValue(row, "FullName")?.ToString();
            txtAddress.Text = gridView1.GetRowCellValue(row, "Address")?.ToString();
            txtBirthday.Text = gridView1.GetRowCellValue(row, "Birthday")?.ToString();
            txtPhone.Text = gridView1.GetRowCellValue(row, "Phone")?.ToString();
            txtUsername.Text = gridView1.GetRowCellValue(row, "Username")?.ToString();
            txtPassword.Text = gridView1.GetRowCellValue(row, "Password")?.ToString();
            gridControl1.Tag = gridView1.GetRowCellValue(row, "Id")?.ToString();
            UserID = gridView1.GetRowCellValue(row, "Id").ToInt();
            foreach (var control in PanelPermisson.Controls)
            {
                if (control is CheckEdit)
                {
                    CheckEdit checkEdit = (CheckEdit)control;
                    if (checkEdit.Enabled && checkEdit.Checked)
                        checkEdit.Checked = false;
                }
            }
            List<int> ListAppID = _staffServices.GetUserPermissionId(UserID);
            foreach (var item in ListAppID)
            {
                foreach (var control in PanelPermisson.Controls)
                {
                    if (control is CheckEdit)
                    {
                        CheckEdit checkEdit = (CheckEdit)control;
                        if (checkEdit.Enabled && checkEdit.Tag.ToInt() == item)
                        {
                            checkEdit.Checked = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
