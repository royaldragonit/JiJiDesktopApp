using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji
{
  public static class UI
  {
    public static void SaveInformation()
    {
      MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    public static void ShowSplashForm()
    {
      if (SplashScreenManager.Default != null) return;
      SplashScreenManager.ShowForm(typeof(Pleasewait));
    }
    public static void CloseSplashForm()
    {
      if (SplashScreenManager.Default != null)
        SplashScreenManager.CloseForm();
    }
    public static void Error(Exception ex)
    {
      MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public static void ShowError(string ex)
    {
      MessageBox.Show(ex, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public static void Debug<T>(T ex)
    {
      MessageBox.Show(ex.ToString(), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    public static bool Question(string str)
    {
      return MessageBox.Show(str, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK;
    }
    public static void Warning(string str)
    {
      MessageBox.Show(str, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    public static void Information(string str)
    {
      MessageBox.Show(str, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
