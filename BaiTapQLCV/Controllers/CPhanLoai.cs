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

        public List<MPhanLoai> GetList(String dieuKien)
        {
            return TableToList(GetAll(dieuKien));
        }

        public MPhanLoai GetByID(int id)
        {
            var ds = GetList("ID=" + id);
            if(ds != null && ds.Count > 0)
            {
                return ds[0];
            }
            else
            {
                return null;
            }
        }

        public int Insert(MPhanLoai m)
        {
            String query = "INSERT INTO " + tableName + "(Ten) VALUES(N'" + m.Ten + "')";
            return da.Ghi(query);
        }

        public int Update(MPhanLoai m)
        {
            String query = "UPDATE " + tableName + " SET Ten=N'" + m.Ten + "' WHERE ID=" + m.ID;
            return da.Ghi(query);
        }

        public int Delete(int id)
        {
            String query = "DELETE " + tableName + " WHERE ID=" + id;
            return da.Ghi(query);
        }

        public String GetView(String dieuKien, String css_class)
        {
            var ds = GetList(dieuKien);
            if (ds != null && ds.Count > 0)
            {
                String kq = "<table class='" + css_class + "'>";
                kq += "<tr><th>TT</th><th>Tên phân loại</th><th>Thao tác</th></tr>";
                int tt = 0;
                foreach (var m in ds)
                {
                    tt++;
                    kq += "<tr><td>" + tt + "</td><td>" + m.Ten + "</td>";
                    kq += "<td><a href=\"Index.aspx?id=" + m.ID + "&action=edit\">Sửa</a>";
                    kq += "<a href=\"Index.aspx?id=" + m.ID + "&action=delete\">Xóa</a></td></tr>";
                }
                kq += "</table>";
                return kq;
            }
            else
            {
                return "Không có dữ liệu";
            }
        }

        public String GetViewNoEdit(String dieuKien, String css_class)
        {
            var ds = GetList(dieuKien);
            if (ds != null && ds.Count > 0)
            {
                String kq = "<table class='" + css_class + "'>";
                kq += "<tr><th>TT</th><th>Tên phân loại</th></tr>";
                int tt = 0;
                foreach (var m in ds)
                {
                    tt++;
                    kq += "<tr><td>" + tt + "</td><td>" + m.Ten + "</td></tr>";
                }
                kq += "</table>";
                return kq;
            }
            else
            {
                return "Không có dữ liệu";
            }
        }
    }
}