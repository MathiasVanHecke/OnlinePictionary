using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DrawIt.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DrawIt.API.Models
{
    public class DrawItAPIContext : IdentityDbContext<ApplicationUser>
    {
        public DrawItAPIContext (DbContextOptions<DrawItAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<DrawIt.Models.Data.Word> Word { get; set; }
        public DbSet<DrawIt.Models.Data.Categorie> Categorie { get; set; }
    }
}
