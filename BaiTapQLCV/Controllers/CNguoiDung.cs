using BaiTapQLCV.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BaiTapQLCV.Controllers
{
    public class CNguoiDung
    {
        private String tableName = "tbNguoiDung";
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

        private List<MNguoiDung> TableToList(DataTable tb)
        {
            List<MNguoiDung> ds = new List<MNguoiDung>();
            if (tb != null && tb.Rows.Count > 0)
            {
                foreach (DataRow dr in tb.Rows)
                {
                    var m = new MNguoiDung();
                    m.ID = int.Parse(dr["ID"].ToString());
                    m.Ten = dr["Ten"].ToString();
                    m.Email = dr["Email"].ToString();
                    m.MatKhau = dr["MatKhau"].ToString();
                    m.TrangThai = dr["TrangThai"].ToString();
                    ds.Add(m);
                }
            }
            return ds;
        }

        public List<MNguoiDung> GetList(String dieuKien)
        {
            return TableToList(GetAll(dieuKien));
        }

        public MNguoiDung GetByID(int id)
        {
            var ds = GetList("ID=" + id);
            if (ds != null && ds.Count > 0)
            {
                return ds[0];
            }
            else
            {
                return null;
            }
        }

        public int Insert(MNguoiDung m)
        {
            String query = "INSERT INTO " + tableName + "(Ten, Email, MatKhau, TrangThai) VALUES(";
            query += "N'" + m.Ten + "',";
            query += "N'" + m.Email.ToString() + "',";
            query += "N'" + m.MatKhau.ToString() + "',";
            query += "N'" + m.TrangThai + "')";
            return da.Ghi(query);
        }

        public int Update(MNguoiDung m)
        {
            String query = "UPDATE " + tableName + " SET ";
            query += "Ten = N'" + m.Ten + "',";
            query += "Email=N'" + m.Email.ToString() + "',";
            query += "MatKhau=N'" + m.MatKhau.ToString() + "',";
            query += "TrangThai=" + m.TrangThai + "";
            query += " WHERE ID=" + m.ID;
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
                kq += "<tr><th>TT</th><th>Họ và tên</th><th>Email</th><th>Trạng thái</th><th>Thao tác</th></tr>";
                int tt = 0;

                foreach (var m in ds)
                {
                    tt++;
                    kq += "<tr><td>" + tt + "</td>";
                    kq += "<td>" + m.Ten + "</td>";
                    kq += "<td>" + m.Email + "</td>";
                    kq += "<td>" + m.TrangThai + "</td>";

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

    }
}