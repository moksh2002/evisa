using System;

using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Databaselogic
    {
        public class MyComponent
        {
        public DataSet getdata(string s)
        {


            SqlConnection con = new SqlConnection
             ("uid=moksh;password=1234;database=employe;server=VDILEWVPNTH516");

        SqlDataAdapter da = new SqlDataAdapter(s, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
            return (ds);
        }

    }

}