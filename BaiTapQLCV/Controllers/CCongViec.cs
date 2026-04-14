using BaiTapQLCV.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BaiTapQLCV.Controllers
{
    public class CCongViec
    {
        private String tableName = "tbCongViec";
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

        private List<MCongViec> TableToList(DataTable tb)
        {
            List<MCongViec> ds = new List<MCongViec>();
            if (tb != null && tb.Rows.Count > 0)
            {
                foreach (DataRow dr in tb.Rows)
                {
                    var m = new MCongViec();
                    m.ID = int.Parse(dr["ID"].ToString());
                    m.Ten = dr["Ten"].ToString();
                    m.NgayBatDau = DateTime.Parse(dr["NgayBatDau"].ToString());
                    m.NgayKetThuc = DateTime.Parse(dr["NgayKetThuc"].ToString());
                    m.NguoiDungID = int.Parse(dr["NguoiDungID"].ToString());
                    m.PhanLoaiID = int.Parse(dr["PhanLoaiID"].ToString());
                    ds.Add(m);
                }
            }
            return ds;
        }

        public List<MCongViec> GetList(String dieuKien)
        {
            return TableToList(GetAll(dieuKien));
        }

        public MCongViec GetByID(int id)
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

        public int Insert(MCongViec m)
        {
            String query = "INSERT INTO " + tableName + "(Ten, NgayBatDau, NgayKetThuc, NguoiDungID, PhanLoaiID) VALUES(";
            query += "N'" + m.Ten + "',";
            query += "N'" + m.NgayBatDau.ToString() + "',";
            query += "N'" + m.NgayKetThuc.ToString() + "',";
            query += "" + m.NguoiDungID + ",";
            query += "" + m.PhanLoaiID + ")";
            return da.Ghi(query);
        }

        public int Update(MCongViec m)
        {
            String query = "UPDATE " + tableName + " SET ";
            query += "Ten = N'" + m.Ten + "',";
            query += "NgayBatDau=N'" + m.NgayBatDau.ToString() + "',";
            query += "NgayKetThuc=N'" + m.NgayKetThuc.ToString() + "',";
            query += "NguoiDungID=" + m.NguoiDungID + ",";
            query += "PhanLoaiID=" + m.PhanLoaiID + "";
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
                kq += "<tr><th>TT</th><th>Tên công việc</th><th>Thời gian</th><th>Phân loại</th><th>Người tạo</th><th>Thao tác</th></tr>";
                int tt = 0;

                CPhanLoai cp = new CPhanLoai();
                CNguoiDung cnd = new CNguoiDung();

                foreach (var m in ds)
                {
                    var pl = cp.GetByID(m.PhanLoaiID);
                    String tenPL = "";
                    if(pl != null)
                        tenPL = pl.Ten;

                    var nd = cnd.GetByID(m.NguoiDungID);
                    String tenND = "";
                    if (nd != null)
                        tenND = nd.Ten;

                    tt++;
                    kq += "<tr><td>" + tt + "</td>";
                    kq += "<td>" + m.Ten + "</td>";
                    kq += "<td>" + m.NgayBatDau.ToString("dd/MM/yyyy") + " -> " + m.NgayKetThuc.ToString("dd/MM/yyyy") + "</td>";
                    kq += "<td>" + tenPL + "</td>";
                    kq += "<td>" + tenND + "</td>";

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