﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public static class EmployeeManager
    {
        static DBManager db=new DBManager();
        public static Employee GetEmployee(string email,string pass)
        {
            DataTable dt = db.GetDataTable($"select *from Employees where Email='{email}' and Password='{pass}'");
            Employee res = new Employee();

            foreach (DataRow dr in dt.Rows) {
                res = ConvertFromDataRowToEmp(dr);
                
            }
            return res;
        }

        internal static Employee ConvertFromDataRowToEmp(DataRow dr)
        {
            var res = new Employee();
            int.TryParse(dr[0]?.ToString() ?? "-1", out int x);
            res.Id = x;

            res.Email = dr[1]?.ToString()?? "ND";
            res.Name = dr[2]?.ToString() ?? "ND";
            res.Password = dr[3]?.ToString() ?? "ND";
            res.Role = dr[4]?.ToString() ?? "ND";

            return res;
        }
    }
}
