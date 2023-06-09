using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using journalism.Models;

    public class journalismContext : DbContext
    {
        public journalismContext (DbContextOptions<journalismContext> options)
            : base(options)
        {
        }

        public DbSet<journalism.Models.journalism1> journalism1 { get; set; }
    }
