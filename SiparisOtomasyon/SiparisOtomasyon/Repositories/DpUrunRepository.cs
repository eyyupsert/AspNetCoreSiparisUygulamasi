using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using SiparisOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon.Repositories
{
    public class DpUrunRepository
    {
        public List<Urun> GetirHepsi()
        {
            using var connection = new SqlConnection("server=DESKTOP-5CQ9SAR\\EYYUPSERT; " +
                "database=SiparisDatabase; integrated security=true;");
            return connection.GetAll<Urun>().ToList();
        }
    }
}
