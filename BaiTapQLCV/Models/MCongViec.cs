using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapQLCV.Models
{
    public class MCongViec
    {
        public int ID { get; set; }
        public String Ten { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        /// <summary>
        /// Người tạo công việc
        /// </summary>
        public int NguoiDungID { get; set; }
        public int PhanLoaiID { get; set; }

        
    }
}