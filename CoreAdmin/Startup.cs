﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.FrameWork.IRepository;
using Blog.Core.FrameWork.Repository;
using Blog.Core.Log;
using CoreAdmin.Filters;
using log4net;
using log4net.Config;
using log4net.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.PlatformAbstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace CoreAdmin
{
    public class Startup
    {

        /// <summary>
        /// log4net 仓储库
        /// </summary>
        public static ILoggerRepository repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //log4net
            repository = LogManager.CreateRepository(Configuration["Logging:Log4Net:Name"]);
            //指定配置文件，如果这里你遇到问题，应该是使用了InProcess模式，请查看Blog.Core.csproj,并删之
            XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
        }

        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
          //  services.Add(new ServiceDescriptor(serviceType: typeof(IUserRepository),
             //                            implementationType: typeof(UserRepository),
             //                            lifetime: ServiceLifetime.Transient));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v0.1.0",
                    Title = "AdminCore API",
                    Description = "框架说明文档",
                    TermsOfService = "None",
                    Contact = new Swashbuckle.AspNetCore.Swagger.Contact { Name = "AdminCore", Email = "AdminCore@xxx.com", Url = "https://www.jianshu.com/u/94102b59cc2a" }   
                });
                var basePath = ApplicationEnvironment.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "CoreAdmin.xml");//这个就是刚刚配置的xml文件名
                c.IncludeXmlComments(xmlPath, true);//默认的第二个参数是false，这个是controller的注释，记得修改
            });
            #endregion
            ////注入Repository
            services.AddSingleton<IUserRepository, UserRepository>();
            // log日志注入
            services.AddSingleton<ILoggerHelper, LogHelper>();
            //注入全局异常捕获
            services.AddMvc(o =>
            {
                // 全局异常过滤      
                o.Filters.Add(typeof(GlobalExceptionsFilter));
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                #region Swagger
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiHelp V1");
                    c.RoutePrefix = "";//路径配置，设置为空，表示直接访问该文件，
                                       //路径配置，设置为空，表示直接在根域名（localhost:8001）访问该文件,注意localhost:8001/swagger是访问不到的，
                                       //这个时候去launchSettings.json中把"launchUrl": "swagger/index.html"去掉， 然后直接访问localhost:8001/index.html即可
                });
                #endregion
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
