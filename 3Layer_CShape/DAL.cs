using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layer_CShape
{
    class DAL
    {
        public SqlConnection GetConnection()
        {
            String conString=@"Data Source=DESKTOP-BBUJIFK;Initial Catalog=QLThuVien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
        public DataTable GetDataTable(String sql)
        {
            //SqlConnection con = GetConnection();
            //SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //return dt;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            return dt;
        }
        
        public void ExecuteNonQuery(String sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.ExecuteNonQuery();
        }

    }
}
