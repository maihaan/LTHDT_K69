using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapQLCV.Models
{
    public class MNguoiDung
    {
        public int ID { get; set; }
        public String Ten { get; set; }
        public String Email { get; set; }
        public String MatKhau { get; set; }
        public String TrangThai { get; set; }

        // Các phương thức
        // - Lấy về DS các công việc đã tạo
        // - Lấy về DS các công việc phải thực hiện
        // ...

    }
}