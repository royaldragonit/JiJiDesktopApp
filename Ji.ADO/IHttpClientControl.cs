using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Ji.ADO
{
    public interface IHttpClientControl
    {
        SqlConnection con{ get; }
        /// <summary>
        /// Kết nối SQL Server
        /// </summary>
        /// <param name="conStr"></param>
        void Connect(string conStr);
        /// <summary>
        /// Trả về số dòng thay đổi (INSERT / UPDATE / DELETE)
        /// </summary>
        /// <returns></returns>
        HttpClientControl Save();        
    }
    public abstract class HttpClientControl
    {
        public HttpClientControl(SqlConnection _con)
        {
            //con = _con;
            //if (con.State == ConnectionState.Closed)
            //    con.Open();
        }
    }
    public static class Query
    {
        public static int Save(this IHttpClientControl http)
        {
            return 1;
        }
    }
}
