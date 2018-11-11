using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DrawIt.Models.Data;

namespace DrawIt.API.Models
{
    public class DrawItAPIContext : DbContext
    {
        public DrawItAPIContext (DbContextOptions<DrawItAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DrawIt.Models.Data.Word> Word { get; set; }
        public DbSet<DrawIt.Models.Data.Categorie> Categorie { get; set; }
    }
}
