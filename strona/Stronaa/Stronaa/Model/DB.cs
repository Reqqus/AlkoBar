using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stronaa.Model
{
    public class DB: DbContext
    {
        public DB(DbContextOptions <DB> options): base (options)
        {

        }

        public DbSet<Alkohole> Alkohole { get; set; }
       
    }
}
