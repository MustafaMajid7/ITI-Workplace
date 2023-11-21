using Day1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;
using Day1.Repository;

namespace Day1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			builder.Services.AddDbContext<PcContext>(o=>o.UseSqlServer(builder.Configuration.GetConnectionString("PcContext")));

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();

			builder.Services.AddSwaggerGen(opt =>
			{
				opt.SwaggerDoc("v1", new OpenApiInfo { Title = "MyAPI", Version = "v1" });
				opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					In = ParameterLocation.Header,
					Description = "Enter only token",
					Name = "Authorization",
					Type = SecuritySchemeType.Http,
					BearerFormat = "JWT",
					Scheme = "bearer"
				});

				opt.AddSecurityRequirement(new OpenApiSecurityRequirement
				{
					{
						new OpenApiSecurityScheme
						{
							Reference = new OpenApiReference
							{
								Type=ReferenceType.SecurityScheme,
								Id="Bearer"
							}
						},
						new string[]{}
					}
				});
			});

			//builder.Services.AddTransient(typeof (RepositoryBase<>), typeof (RepositoryBase<>));
			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
			builder.Services.AddAutoMapper(typeof(Program).Assembly);
			builder.Services.AddAuthentication(op=>op.DefaultAuthenticateScheme="schema")
				.AddJwtBearer("schema",options =>
			{
				string secretKey = "hello my friend my name is mostafa";
				var SKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey));
				options.TokenValidationParameters = new TokenValidationParameters
				{
					IssuerSigningKey = SKey,
					ValidateIssuer = false,
					ValidateAudience = false,
				};
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.MapControllers();

			app.Run();
		}
	}
}