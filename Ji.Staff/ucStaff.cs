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

namespace Ji.Staff
{
    public partial class ucStaff : ClientControl, IClientControl
    {
        /// <summary>
        /// Lưu tất cả User vào biến này để tái sử dụng khỏi truy vấn Database
        /// </summary>
        private List<Users> user = new List<Users>();
        private int UserID { get; set; }
        public ucStaff()
        {
            InitializeComponent();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            LoadControl();
            BindingData();
        }
        public void LoadControl()
        {
            PanelPermisson.Controls.Clear();
            var ds = API.API_GetAllApplication<Dictionary<string, string>>(Extension.GetAppSetting("API") + "Application/GetAllApplication", API.Access_Token);
            int NumberTableInRow = (PanelPermisson.Width - 6) / 5;
            int Width = (PanelPermisson.Width - 6) / NumberTableInRow;
            int i = 0;
            foreach (var item in ds)
            {
                CheckEdit chk = new CheckEdit();
                if (item["permissionBasic"].ToBoolean())
                {
                    chk.Enabled = false;
                    chk.Checked = true;
                }
                chk.Name = item["nameNonUnicode"];
                chk.Text = item["name"];
                chk.Tag = item["id"];
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
                    //Lấy User dựa vào UserID ra
                    Users user = this.user.FirstOrDefault(x => x.ID == UserID && txtUsername.Text.ToLower().Equals(x.Username.ToLower()));
                    if (user == null)
                        UI.Warning("Không được phép thay đổi tên đăng nhập, chỉ có thể thêm mới");
                    else
                    {
                        string ListAppID = string.Empty;
                        foreach (var control in PanelPermisson.Controls)
                        {
                            if (control is CheckEdit)
                            {
                                CheckEdit checkEdit = (CheckEdit)control;
                                if (checkEdit.Checked && checkEdit.Enabled)
                                    ListAppID += checkEdit.Tag.ToString() + ",";
                            }
                        }
                        if (!string.IsNullOrEmpty(ListAppID))
                            ListAppID = ListAppID.Substring(0, ListAppID.Length - 1);
                        //Nếu không thay đổi mật khẩu khi đăng nhập
                        string rs = string.Empty;
                        if (txtPassword.Text.ToLower().Equals(user.Password))
                        {
                            user.Phone = txtPhone.Text;
                            user.FullName = txtName.Text;
                            user.Birthday = txtBirthday.DateTime;
                            user.Address = txtAddress.Text;
                            rs = API.UpdateUser(user, ListAppID);
                        }
                        //Nếu thay đổi mật khẩu
                        else
                        {
                            if (UI.Question("Cập nhật thông tin bao gồm mật khẩu?"))
                            {
                                user.Phone = txtPhone.Text;
                                user.FullName = txtName.Text;
                                user.Password = txtPassword.Text.ToMD5();
                                user.Birthday = txtBirthday.DateTime;
                                user.Address = txtAddress.Text;
                                rs = API.UpdateUser(user, ListAppID);
                            }
                        }
                        if (!string.IsNullOrEmpty(rs))
                            UI.SaveInformation();
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
                //Lấy User dựa vào UserID ra
                Users user = this.user.FirstOrDefault(x => txtUsername.Text.ToLower().Equals(x.Username.ToLower()));
                if (user != null)
                {
                    UI.Warning("Tên tài khoản đã tồn tại, vui lòng chọn một tên tài khoản khác");
                    txtUsername.Focus();
                }
                else
                {
                    //Nếu không thay đổi mật khẩu khi đăng nhập
                    string rs = string.Empty;
                    Users users = new Users();
                    users.Active = true;
                    users.Address = txtAddress.Text;
                    users.Birthday = txtBirthday.DateTime;
                    users.CreateOn = DateTime.Now;
                    users.FullName = txtName.Text;
                    users.Password = txtPassword.Text;
                    users.Phone = txtPhone.Text;
                    users.Username = txtUsername.Text;
                    rs = API.CreateUser(user);
                    if (!string.IsNullOrEmpty(rs))
                        UI.SaveInformation();
                    else
                        UI.Warning("Lỗi! Chưa thêm tài khoản vào CSDL được!");
                }
            }
            else
                UI.Warning("Các thông tin bắt buộc khi : Tên, Tên tài khoản, Mật khẩu , Số điện thoại");
        }

        public void BindingData()
        {
            gridControl1.DataSource = null;
            var ds = API.GetUsers<Users>(Extension.GetAppSetting("API") + "Application/GetUsers", API.Access_Token)?.ToList();
            gridControl1.DataSource = ds;
            if (ds != null && ds.Count() > 0)
                user = ds;
            gridControl1.Tag = ds?[0]?.ID;
            UserID = ds?[0]?.ID ?? 0;
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
            gridControl1.Tag = gridView1.GetRowCellValue(row, "ID")?.ToString();
            UserID = gridView1.GetRowCellValue(row, "ID").ToInt();
            foreach (var control in PanelPermisson.Controls)
            {
                if (control is CheckEdit)
                {
                    CheckEdit checkEdit = (CheckEdit)control;
                    if (checkEdit.Enabled && checkEdit.Checked)
                        checkEdit.Checked = false;
                }
            }
            string ListAppID = API.GetPermissionUser(UserID);
            if (!string.IsNullOrEmpty(ListAppID))
            {
                var arr = ListAppID.Split(',');
                for (int i = 0; i < arr.Count(); i++)
                {
                    foreach (var control in PanelPermisson.Controls)
                    {
                        if (control is CheckEdit)
                        {
                            CheckEdit checkEdit = (CheckEdit)control;
                            if (checkEdit.Enabled && checkEdit.Tag.ToInt() == arr[i].VNDToNumber())
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
}
