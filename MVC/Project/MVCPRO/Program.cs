using System.Text.Json.Serialization;
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

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Instructor}/{action=Index}/{id?}");

			app.Run();
		}
	}
}