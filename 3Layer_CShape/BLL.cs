using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer_CShape
{
    class BLL
    {
        DAL dal = new DAL();
        public DataTable getAllData()
        {
            String sql = "select SoPhieu,ThanhVien.MaThe,HoTen,TenSach,NXB from Sach inner join MuonTra on Sach.MaSach=MuonTra.MaSach inner join ThanhVien on ThanhVien.MaThe= MuonTra.MaThe";

            DataTable dt = new DataTable();
            dt = dal.GetDataTable(sql);
            return dt;

        }
        public void insertBook(String name,DateTime ngaytra)
        {
            String sql = "insert into Sach values('" +name+"',"+ngaytra+ ")";
            dal.ExecuteNonQuery(sql);
        }
        public void insertResest(String IDmem,String nameMem,String Diachi,String SDT)
        {
            String sql = "insert into ThanhVien values('"+IDmem+"','"+nameMem+"','"+Diachi+"','"+SDT + "')";
            dal.ExecuteNonQuery(sql);
        }
        public void insertSoPhieu(String IDPhieu,String IDmem,String )
    }
}
