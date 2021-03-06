﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Alkohol> Alkoholev2 { get; set; }
        public DbSet<Drink> Drinki { get; set; }
        public DbSet<Sciek> Klienci { get; set; }
    }
}
