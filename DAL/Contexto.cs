using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P1_AP1_Frankelyn_20190276.Entidades;

namespace P1_AP1_Frankelyn_20190276.DAL
{
    public class Contexto : DbContext
    {
        DbSet<Aportes> Aportes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\DbAportes.db");
        }
    }
}
