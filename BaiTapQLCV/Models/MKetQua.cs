using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapQLCV.Models
{
    public class MKetQua
    {
        public int ID { get; set; } 
        public String DanhGia { get; set; }
        public int ChiTietCongViecID { get; set; }
        /// <summary>
        /// Thời điểm đánh giá
        /// </summary>
        public DateTime ThoiDiem { get; set; }
        /// <summary>
        /// Người đánh giá
        /// </summary>
        public int NguoiDungID { get; set; }
    }
}