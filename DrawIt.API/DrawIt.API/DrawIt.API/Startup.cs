using DrawIt.API.Models;
using DrawIt.Models.Data;
using DrawIt.Models.Hubs;
using DrawIt.Models.Repositories;
using DrawIt.Models.Seeders;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System.Text;

namespace DrawIt.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("CorsPolicy",
               builder =>
               {
                   builder.AllowAnyMethod().AllowAnyHeader()
                   .WithOrigins("http://localhost:8080/", "http://localhost:44321/", "http://192.168.0.210:8080", "http://192.168.56.1:8080")
                   .AllowCredentials();
               }));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddTransient<IWordRepo, WordRepo>();

            services.AddDbContext<DrawItAPIContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DrawItAPIContext")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<DrawItAPIContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
             .AddJwtBearer(options =>
             {
                 options.SaveToken = true;
                 options.RequireHttpsMetadata = false;
                 options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidAudience = "http://online-pictionary.com",
                     ValidIssuer = "http://online-pictionary.com",
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySercureKeySuperrrrr"))
                 };

             });

            services.AddSignalR();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Pictionary API", Description = "De api + hub die communiceert met de client" });
            });
            
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseCors("CorsPolicy");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); 
            }
            else
            {
                app.UseHsts();
            }

            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/chatHub");
            });

            SeedDatabase.Initialize(app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope().ServiceProvider);
            
            app.UseAuthentication();

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI( c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Draw Api");
            });

        }

        
    }
}
