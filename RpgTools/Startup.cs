﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RpgTools.Business;
using RpgTools.Business.Implementations;
using RpgTools.Repository;
using RpgTools.Repository.Implementations;
using Microsoft.EntityFrameworkCore;
using RpgTools.Model.Context;
using Newtonsoft.Json;

namespace RpgTools
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
            var connection = Configuration["MySqlConnection:MySqlConnectionString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection));
            services.AddMvc()
             .AddJsonOptions(options => {
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
     });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IMonsterRepository, MonsterRepositoryImpl>();
            services.AddScoped<IActionRepository, ActionRepositoryImpl>();
            services.AddScoped<IMonsterBusiness, MonsterBusinessImpl>();
            services.AddScoped<IActionBusiness, ActionBusinessImpl>();
            services.AddScoped<IStatusBusiness, StatusBusinessImpl>();
            services.AddScoped<IStatusRepository, StatusRepositoryImpl>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
