using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class ITIcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DV1U283\\SQLEXPRESS01;Initial Catalog=DesktopCafeteria;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
