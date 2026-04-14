using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapQLCV.Models
{
    public class MChiTietCongViec
    {
        public int ID { get; set; }
        public String Ten { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        /// <summary>
        /// Người thực hiện
        /// </summary>
        public int NguoiDungID { get; set; }
        public int CongViecID { get; set; }
    }
}