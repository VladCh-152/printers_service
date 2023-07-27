using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Hosting;
using PrintersBackend.Models;
using PrintersBackend.Serviceis;
using Microsoft.IdentityModel.Tokens;
using PrintersBackend.Options;

namespace PrintersBackend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string printersConnection = Configuration.GetConnectionString("PrintersConnection");
            services.AddDbContext<PrinterContext>(options =>
                options.UseSqlServer(printersConnection));

            string usersConnection = Configuration.GetConnectionString("UsersConnection");
            services.AddDbContext<UserContext>(options =>
                options.UseSqlServer(usersConnection));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = AuthOptions.ISSUER,
                    ValidateAudience = true,
                    ValidAudience = AuthOptions.AUDIENCE,
                    ValidateLifetime = true,
                    IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                    ValidateIssuerSigningKey = true,
                };
            });

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.WithOrigins("https://localhost:44382")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            services.AddScoped<PrintersService>();
            services.AddScoped<PrinterTypesService>();
            services.AddScoped<PrinterModelsService>();
            services.AddScoped<VendorsService>();
            services.AddScoped<UserService>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
