using DrawIt.API.Models;
using DrawIt.Models.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawIt.Models.Seeders
{
    public class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DrawItAPIContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            context.Database.EnsureCreated();


            // Als er nog geen user in de db zit => aanmaken
            if (!context.Users.Any())
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = "mathias.vanhecke@icloud.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "Mathias"

                };
                //Opgelet bij geen goed wachtwoord wilt hij deze user niet aanmaken
                userManager.CreateAsync(user, "Password@123");
            }
        }
    }
}
