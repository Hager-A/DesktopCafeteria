using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DBManager
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;
        public DBManager() {
            conn = new SqlConnection("Data Source=DESKTOP-DV1U283\\SQLEXPRESS01;Initial Catalog=DesktopCafeteria;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

            //conn = new SqlConnection("Data Source=DESKTOP-N3T3R6C\\SQLEXPRESS;Initial Catalog=DesktopCafeteria;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            cmd = new SqlCommand("", conn);
        }

    }
}
