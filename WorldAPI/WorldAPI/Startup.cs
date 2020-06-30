using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WorldAPI.DAL;
using WorldAPI.DAL.Contracts;
using WorldAPI.Entities.Data;
using WorldAPI.Profiles;

namespace WorldAPI
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
			services.AddDbContext<WorldDbContext>(options =>
				options.UseMySql(Configuration.GetConnectionString("MySqlConnection")));
			services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

			services.AddAutoMapper(typeof(CountryProfile), typeof(StateProfile), typeof(CityProfile));


			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "World API", Version = "v1" });
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c =>
				{
					c.SwaggerEndpoint("v1/swagger.json", "World API V1");
				});
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
