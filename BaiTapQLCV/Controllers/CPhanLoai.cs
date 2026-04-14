using BaiTapQLCV.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BaiTapQLCV.Controllers
{
    public class CPhanLoai
    {
        private String tableName = "tbPhanLoai";
        private CDataAccess da = new CDataAccess();

        public DataTable GetAll(String dieuKien)
        {
            String query = "SELECT * FROM " + tableName;
            if (dieuKien.Length > 0)
            {
                query += " WHERE " + dieuKien;
            }
            query += " ORDER BY ID ASC";

            return da.Doc(query);
        }

        public DataTable GetAll()
        {
            return GetAll("");
        }

        private List<MPhanLoai> TableToList(DataTable tb)
        {
            List<MPhanLoai> ds = new List<MPhanLoai>();
            if (tb != null && tb.Rows.Count > 0)
            {
                foreach (DataRow dr in tb.Rows)
                {
                    var m = new MPhanLoai();
                    m.ID = int.Parse(dr["ID"].ToString());
                    m.Ten = dr["Ten"].ToString();
                    ds.Add(m);
                }
            }
            return ds;
        }
    }
}