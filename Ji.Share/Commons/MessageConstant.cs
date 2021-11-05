using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Commons
{
    public static class MessageConstant
    {
        public const string InvalidInfoSave = "Thông tin đăng nhập đã lưu không chính xác, vui lòng thử đăng nhập lại";
        public const string CheckInternet = "Vui lòng kiểm tra kết nối mạng và thử lại";
        public const string ErrorSaveNote = "Có lỗi khi lưu Lưu Ý :( vui lòng thử lại nhé";
        public const string OrderBeforeNote = "Bạn chưa Order, vui lòng Order trước khi Note";
        public const string InputNoteOrder = "Bạn chưa nhập Lưu Ý cho đơn hàng";
        public const string SaleOffOverRange= "Giảm giá phải là số và không quá 100%";
        public const string TableNoOrder= "Bàn này chưa gọi món nào";
    }
}
