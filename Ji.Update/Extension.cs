﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ji.Update
{
  /// <summary>
  /// Lớp Extension để kiểm tra các trường hợp như SĐT, Email, Number, ...
  /// </summary>
  public static class Extension
  {
    /// <summary>
    /// Get giá trị trong app.config by key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static string GetAppSetting(string key)
    {
      return ConfigurationManager.AppSettings[key].ToString();
    }
    /// <summary>
    /// Kiểm tra kết nối mạng
    /// </summary>
    /// <returns></returns>
    public static bool CheckInternet()
    {
      return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
    }
    /// <summary>
    /// Lấy địa chỉ IP V4 Private
    /// </summary>
    /// <returns></returns>
    public static string GetIPPrivate()
    {
      var host = Dns.GetHostEntry(Dns.GetHostName());
      foreach (var ip in host.AddressList)
      {
        if (ip.AddressFamily == AddressFamily.InterNetwork)
        {
          return ip.ToString();
        }
      }
      return "No network adapters with an IPv4 address in the system!";
    }
    /// <summary>
    /// Hàm này mã hóa chuỗi thành MD5 (Hash 1 chiều)
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToMD5(this string input)
    {
      // Use input string to calculate MD5 hash
      using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
      {
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hashBytes = md5.ComputeHash(inputBytes);

        // Convert the byte array to hexadecimal string
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hashBytes.Length; i++)
        {
          sb.Append(hashBytes[i].ToString("X2"));
        }
        return sb.ToString();
      }
    }
    /// <summary>
    /// Hàm kiểm tra số điện thoại có hợp lệ không
    /// </summary>
    /// <param name="phone"></param>
    /// <returns></returns>
    public static bool IsPhoneNumber(this string phone)
    {
      if (!string.IsNullOrEmpty(phone))
      {
        string pattern = @"^-*[0-9,\.?\-?\(?\)?\ ]+$";
        return Regex.IsMatch(phone, pattern);
      }
      else
        return false;
    }
    public static DateTime ToTimeZone7(this DateTime dateTime)
    {
      TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
      DateTime dt = TimeZoneInfo.ConvertTime(dateTime, timeZone);
      return dt;
    }
    /// <summary>
    /// Hàm kiểm tra Email có hợp lệ không
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    public static bool IsEmail(this string email)
    {
      try
      {
        var addr = new System.Net.Mail.MailAddress(email);
        return addr.Address == email;
      }
      catch
      {
        return false;
      }
    }
    /// <summary>
    /// Chuyển ngày mặc định sang dạng dd/mm/yyyy Ví dụ: 25/12/2019
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToDateTime(this DateTime input)
    {
      DateTime dt = DateTime.ParseExact(input.ToString(), "MM,dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
      return dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
    }
    public static string ToDateTime(this DateTime? input)
    {
      DateTime date = Convert.ToDateTime(input);
      return date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
    }
    /// <summary>
    /// Hàm này chuyển từ một số bất kỳ --->Int
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int ToInt<T>(this T input)
    {
      int test = 0;
      int.TryParse(input.ToString(), out test);
      return Convert.ToInt32(test);
    }
    /// <summary>
    /// Chuyển thành tiền tệ x.xxx.xxx
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToMoney<T>(this T input)
    {
      if (input == null)
        return "";
      return string.Format("{0:n0}", input);
    }
    /// <summary>
    /// Hàm chuyển con về tiền Việt Nam
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToVND<T>(this T input)
    {
      if (input == null)
        return "";
      return string.Format("{0:n0}", input) + " VNĐ";
    }
    /// <summary>
    /// Hàm kiểm tra số nhập vào có phải là một con số không
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsNumber(this string input)
    {
      int result;
      return int.TryParse(input, out result);
    }
    /// <summary>
    /// Hàm kiểm tra Email có hợp lệ hay không?
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    public static bool IsValidEmail(this string email)
    {
      try
      {
        var addr = new System.Net.Mail.MailAddress(email);
        return addr.Address == email;
      }
      catch
      {
        return false;
      }
    }
    /// <summary>
    /// Hàm này chuyển số về tiền VNĐ. Ví Dụ: 10000-> 10.000 VNĐ
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int VNDToNumber(this string input)
    {
      string StringNumber = "";
      for (int i = 0; i < input.Length; i++)
      {
        if (char.IsDigit(input[i]))
          StringNumber += input[i];
      }
      if (StringNumber.Length > 0)
        return Convert.ToInt32(StringNumber);
      else
        return 0;
    }
    /// <summary>
    /// Hàm chuyển tất cả Tiếng Việt thành Tiếng Việt không dấu và các ký tự đặc biệt thành dấu - đồng thời chuyển thành chữ thường
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string NonUnicode(this string text)
    {
      string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
      string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
      for (int i = 0; i < arr1.Length; i++)
      {
        text = text.Replace(arr1[i], arr2[i]);
        text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
        text = text.Replace(" ", "-").Replace("+", "-").Replace(".", "-").Replace(")", "-").Replace("(", "-").Replace("@", "-").Replace("!", "-").Replace("#", "-").Replace("$", "-").Replace("%", "-").Replace("^", "-").Replace("&", "-").Replace("*", "-").Replace("{", "-").Replace("}", "-").Replace("[", "-").Replace("]", "-").Replace("|", "-").Replace("\\", "-").Replace("'", "-").Replace(";", "-").Replace(",", "-").Replace("?", "-").Replace("/", "-").Replace("\"", "-").Replace(":", "-");
      }
      return text.ToLower();
    }
    /// <summary>
    /// Chuyển đổi mã hóa base64 về hình ảnh
    /// </summary>
    /// <param name="base64String"></param>
    /// <returns></returns>
    public static Image Base64ToImage(this string base64String)
    {
      // Convert base 64 string to byte[]
      byte[] imageBytes = Convert.FromBase64String(base64String);
      // Convert byte[] to Image
      using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
      {
        Image image = Image.FromStream(ms, true);
        return image;
      }
    }
    /// <summary>
    /// Chuyển đổi hình ảnh sang mã hóa Base64
    /// </summary>
    /// <param name="image"></param>
    /// <param name="format"></param>
    /// <returns></returns>

    public static string ImageToBase64(this Image image, System.Drawing.Imaging.ImageFormat format)
    {
      using (MemoryStream ms = new MemoryStream())
      {
        // Convert Image to byte[]
        image.Save(ms, format);
        byte[] imageBytes = ms.ToArray();

        // Convert byte[] to base 64 string
        string base64String = Convert.ToBase64String(imageBytes);
        return base64String;
      }
    }
    /// <summary>
    /// Gets the MAC address of the current PC.
    /// </summary>
    /// <returns></returns>
    public static string GetMACAddress()
    {
      NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
      String sMacAddress = string.Empty;
      foreach (NetworkInterface adapter in nics)
      {
        if (sMacAddress == String.Empty)// only return MAC Address from first card
        {
          IPInterfaceProperties properties = adapter.GetIPProperties();
          sMacAddress = adapter.GetPhysicalAddress().ToString();
        }
      }
      return sMacAddress;
    }
    /// <summary>
    /// Chuyển chuỗi Base64 về lại file
    /// </summary>
    /// <param name="base64string"></param>
    /// <param name="name"></param>
    /// <param name="path"></param>
    public static void Base64ToFile(this string base64string, string name, string path)
    {
      File.WriteAllBytes(Path.Combine(path, name), Convert.FromBase64String(base64string));
    }
    /// <summary>
    /// Chuyển file sang Base64
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static string ConvertFileToBase64(this string path)
    {
      byte[] bytes = File.ReadAllBytes(path);
      return Convert.ToBase64String(bytes);
    }
    /// <summary>
    /// Chỉnh sửa kích thước hình ảnh (độ dài và độ rộng)
    /// </summary>
    /// <param name="imgPhoto"></param>
    /// <param name="newWidth"></param>
    /// <param name="newHeight"></param>
    /// <returns></returns>
    public static Image Resize(this Image imgPhoto, int newWidth, int newHeight)
    {

      int sourceWidth = imgPhoto.Width;
      int sourceHeight = imgPhoto.Height;
      if (sourceWidth < sourceHeight)
      {
        int buff = newWidth;

        newWidth = newHeight;
        newHeight = buff;
      }

      int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
      float nPercent = 0, nPercentW = 0, nPercentH = 0;

      nPercentW = ((float)newWidth / (float)sourceWidth);
      nPercentH = ((float)newHeight / (float)sourceHeight);
      if (nPercentH < nPercentW)
      {
        nPercent = nPercentH;
        destX = System.Convert.ToInt16((newWidth -
                  (sourceWidth * nPercent)) / 2);
      }
      else
      {
        nPercent = nPercentW;
        destY = System.Convert.ToInt16((newHeight -
                  (sourceHeight * nPercent)) / 2);
      }

      int destWidth = (int)(sourceWidth * nPercent);
      int destHeight = (int)(sourceHeight * nPercent);


      Bitmap bmPhoto = new Bitmap(newWidth, newHeight,
                    PixelFormat.Format24bppRgb);

      bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                   imgPhoto.VerticalResolution);

      Graphics grPhoto = Graphics.FromImage(bmPhoto);
      grPhoto.Clear(Color.Black);
      grPhoto.InterpolationMode =
          System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

      grPhoto.DrawImage(imgPhoto,
          new Rectangle(destX, destY, destWidth, destHeight),
          new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
          GraphicsUnit.Pixel);

      grPhoto.Dispose();
      imgPhoto.Dispose();
      return bmPhoto;
    }
    public static ImageCodecInfo GetEncoderInfo(string mimeType)
    {
      ImageCodecInfo[] encoders;
      encoders = ImageCodecInfo.GetImageEncoders();
      for (int j = 0; j <= encoders.Length; j++)
      {
        if (encoders[j].MimeType == mimeType)
          return encoders[j];
      }
      return null/* TODO Change to default(_) if this is not a reference type */;
    }
    public static void CompessImage(this Image image, string szFileName, long lCompression)
    {
      EncoderParameters eps = new EncoderParameters(1);
      eps.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, lCompression);
      ImageCodecInfo ici = GetEncoderInfo("image/jpeg");
      image.Save(szFileName, ici, eps);
    }
    /// <summary>
    /// Hàm mã hóa chuỗi với key
    /// </summary>
    /// <param name="source"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static string Encrypt(this string source, string key)
    {
      using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
      {
        using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
        {
          byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
          tripleDESCryptoService.Key = byteHash;
          tripleDESCryptoService.Mode = CipherMode.ECB;
          byte[] data = Encoding.UTF8.GetBytes(source);
          return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
        }
      }
    }
    /// <summary>
    /// Hàm giải mã chuỗi với key
    /// </summary>
    /// <param name="encrypt"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static string Decrypt(this string encrypt, string key)
    {
      using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
      {
        using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
        {
          byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
          tripleDESCryptoService.Key = byteHash;
          tripleDESCryptoService.Mode = CipherMode.ECB;
          byte[] data = Convert.FromBase64String(encrypt);
          byte[] test = tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(data, 0, data.Length);
          return Encoding.UTF8.GetString(test);
        }
      }
    }
  }

}
