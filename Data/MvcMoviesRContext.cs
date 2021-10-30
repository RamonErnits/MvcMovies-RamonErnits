using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMoviesR.Models;

namespace MvcMoviesR.Data
{
    public class MvcMoviesRContext : DbContext
    {
        public MvcMoviesRContext (DbContextOptions<MvcMoviesRContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMoviesR.Models.Actor> Actor { get; set; }

        public DbSet<MvcMoviesR.Models.Movie> Movie { get; set; }
    }
}
