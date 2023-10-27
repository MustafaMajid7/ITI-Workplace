using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVCPRO.Models;
using MVCPRO.Repository.CourseRepository;
using MVCPRO.Repository.DepartmentRepository;
using NuGet.Protocol;

namespace MVCPRO
{
    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews().AddJsonOptions(options=>
			options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

			builder.Services.AddDbContext<InstituteCTX>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("developmentConnectionString"));
			});

			builder.Services.AddIdentity<AppUser, IdentityRole>(o =>
			{
				o.Password.RequiredLength = 10;
				o.Password.RequireUppercase = true;
				o.Password.RequireLowercase = true;
				o.Password.RequireDigit = true;

			})
			  .AddEntityFrameworkStores<InstituteCTX>();

			builder.Services.AddSession();

			builder.Services.AddScoped<ICourseRepository,CourseRepository>();
			builder.Services.AddScoped<IDepartmentRepository,DepartmentRepository>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
			}
			app.UseStaticFiles();

			app.UseRouting();

			app.UseSession();

			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}