using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UrnaWeb.Models;

namespace UrnaWeb.Data
{
    public class UrnaWebContext : DbContext
    {
        public UrnaWebContext (DbContextOptions<UrnaWebContext> options)
            : base(options)
        {
        }

        public DbSet<UrnaWeb.Models.Candidate> Candidate { get; set; }
    }
}
