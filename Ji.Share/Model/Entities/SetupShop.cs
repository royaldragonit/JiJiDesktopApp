using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class SetupShop
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string Slogan { get; set; }
        /// <summary>
        /// Lời chào dòng 1 ở cuối Bill
        /// </summary>
        public string Bye1 { get; set; }
        /// <summary>
        /// Lời chào dòng 2 ở cuối Bill
        /// </summary>
        public string Bye2 { get; set; }
        /// <summary>
        /// Số lượng in Bill khi thanh toán (Thường 1 Bill cho khách, 1 Bill giữ lại để kiểm)
        /// </summary>
        public int NumberPrintBill { get; set; }
        /// <summary>
        /// Logo của Shop, mã hóa thành base64 để nén lên đây
        /// </summary>
        public string Logo { get; set; }
        /// <summary>
        /// Máy in mặc định
        /// </summary>
        public string DefaultPrinter { get; set; }
        public string FacId { get; set; }
        public string FaceBook { get; set; }
        public string Address { get; set; }
        public string Hotline { get; set; }
        public string Abbreviation { get; set; }
        public bool? ShowBarCode { get; set; }
        public bool WarningCheckout { get; set; }
        public DateTime Lisence { get; set; }
        public bool? Active { get; set; }
    }
}
