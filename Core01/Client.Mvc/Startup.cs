using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;

using System.Text;
using System.IO;
using System.Diagnostics;

namespace ru.tsb.mvc
{
    public partial class Startup
    {
        public IConfiguration AppConfiguration { get; }
        public IConfiguration CustomConfiguration { get; set; }
        public Startup(IConfiguration configuration)
        {
            AppConfiguration = configuration;

            #region Services
            #region 4.������������
            #region 01 - ������ ������������
            if (1 == 2)
            {
                // ��������� ������������
                var builder = new ConfigurationBuilder()
                    .AddInMemoryCollection(new Dictionary<string, string>
                    {
                    {"firstname", "Tom"},
                    {"age", "31"}
                    });
                // ������� ������������
                CustomConfiguration = builder.Build();
            }
            #endregion

            #region 04 - �������� ���������� ������������ (������������ � JSON / XML / INI)
            if (1 == 2)
            {
                string path_conf = AppConfiguration["ASPNETCORE_IIS_PHYSICAL_PATH"] + "config.json";
                var builder = new ConfigurationBuilder().AddJsonFile(path_conf);
                //string path_conf = AppConfiguration["ASPNETCORE_IIS_PHYSICAL_PATH"] + "config.xml";
                //var builder = new ConfigurationBuilder().AddXmlFile(path_conf);
                //string path_conf = AppConfiguration["ASPNETCORE_IIS_PHYSICAL_PATH"] + "config.ini";
                //var builder = new ConfigurationBuilder().AddIniFile(path_conf);

                CustomConfiguration = builder.Build();
            }
            #endregion

            #region Start / 05 / 06 / 07 / 09 / 10
            if (1 == 1)
            {
                string path_conf = "";
                //path_conf = AppConfiguration["ASPNETCORE_IIS_PHYSICAL_PATH"]; ;

                var builder = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                    .AddJsonFile(path_conf + "config.json")
                    .AddEnvironmentVariables()
                    .AddInMemoryCollection(new Dictionary<string, string>
                    {
                        {"name", "Tom"},
                        {"age", "31"}
                    })
                    .AddConfiguration(configuration)
                    ;
                // ������� ������������

                CustomConfiguration = builder.Build();
            }
            #endregion

            #region 08 - ������ � ������������� (������ ����� ������������)
            if (1 == 2)
            {
                string path_conf = AppConfiguration["ASPNETCORE_IIS_PHYSICAL_PATH"];

                var builder = new ConfigurationBuilder()
                    .AddJsonFile(path_conf + "project.json")
                    ;
                // ������� ������������

                CustomConfiguration = builder.Build();
            }
            #endregion
            #endregion
            #endregion
        }

        private IServiceCollection _services;
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Default
            _services = services;

            #region Start
            if (1 == 1)
            {
                services.Configure<ConfigurationClass>(CustomConfiguration);
            }
            #endregion
            #endregion

            #region Services
            #region 3.Dependency Injection
            #region 05 - DI (�������� ����� ��������)
            if (1 == 2)
            {
                services.AddTransient<IMessageSender, EmailMessageSender>();
            }
            #endregion

            #region 06 - DI (���������� ��� ���������� ��������)
            if (1 == 2)
            {
                //services.AddTransient<TimeService>();
                services.AddTimeService();
            }
            #endregion

            #region 07 - DI (�������� ������������ - ������������)
            if (1 == 2)
            {
                services.AddTransient<IMessageSender, EmailMessageSender>();
                services.AddTransient<MessageService>();
            }
            #endregion

            #region 08 - DI (�������� ������������ - HttpContext.RequestServices / ApplicationServices)
            if (1 == 2)
            {
                services.AddTransient<IMessageSender, EmailMessageSender>();
            }
            #endregion

            #region 09 - DI (�������� ������������ - Invoke / InvokeAsync)
            if (1 == 2)
            {
                services.AddTransient<IMessageSender, EmailMessageSender>();
            }
            #endregion
            #endregion

            #region 4.������������
            #region 06 - ����������� ���������� ������������ (UseMiddleware)
            if (1 == 2)
            {
                services.AddTransient<IConfiguration>(provider => CustomConfiguration);
            }
            #endregion

            #region 10 - �������� ������������ ����� IOptions
            if (1 == 2)
            {
                services.Configure<ConfigurationClass>(CustomConfiguration);
                services.Configure<ConfigurationClass>(opt =>
                {
                    opt.color = "blue";
                });
            }
            #endregion
            #endregion

            #region 5.��������� ����������
            #region 03 - ������
            if (1 == 2)
            {
                services.AddDistributedMemoryCache();
                //services.AddSession();
                services.AddSession(options =>
                {
                    options.Cookie.Name = ".MyApp.Session";
                    options.IdleTimeout = TimeSpan.FromSeconds(3600);
                    options.Cookie.IsEssential = true;
                });
            }
            #endregion

            #region 04 - ������ (�������� ������� ��������)
            if (1 == 2)
            {
                services.AddDistributedMemoryCache();
                services.AddSession();
            }
            #endregion
            #endregion

            #region 7.�������������
            #region 05 - �������� ������ ��������
            if (1 == 2)
            {
                services.AddRouting();
            }
            #endregion
            #endregion

            #region 8.ASP.NET Core MVC
            #region 01 - ������ ����������
            if (1 == 2)
            {
                services.AddRouting();
                //services.AddDbContext<EntityContext>(options =>
                //    options.UseSqlServer(AppConfiguration["Data:gos:ConnectionString"]));
                //services.AddDbContext<EntityContext>(options =>
                //    options.UseSqlServer(AppConfiguration["Data:renovation_web:ConnectionString"]));
                //services.AddTransient<ICoreEdm, CoreEdm>();

                //services.AddDbContext<AppidentityDbContext>(options =>
                //    options.UseSqlServer(AppConfiguration["Data:auth:ConnectionString"]));

                //services.AddIdentity<scr_user, IdentityRole>()
                //    .AddEntityFrameworkStores<AppidentityDbContext>()
                //    .AddDefaultTokenProviders();
            }
            #endregion
            #endregion

            #region 9.�����������
            #region 01 - �������� ������������ � ����������
            if (1 == 2)
            {
                services.AddTransient<ITimeService, SimpleTimeService>();
            }
            #endregion
            #endregion

            #region 19.WEB API
            #region 01 - �������� �����������
            if (1 == 2)
            {
                services.AddControllers();
            }
            #endregion
            #endregion
            #endregion

            if (1 == 1)
            {
                //services.AddControllersWithViews();
                services.AddMvc();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env
        #region
            //, IMessageSender messageSender  // 15 - DI (�������� ����� ��������)
            //, TimeService timeService  // 16 - DI (���������� ��� ���������� ��������)
            //, MessageService messageService // 17 - DI (�������� ������������ - ������������)
            //, ILogger<Startup> logger // 01 - ������� ���� � ILogger
        #endregion
            )
        {
            #region Default - start
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //endpoints.MapGet("/", DefaultRequest);
                //endpoints.MapControllers();
            });

            app.UseMiddleware<RequestResponseLoggingMiddleware>();
            //app.UseLogUrl();
            return;
            #endregion

            #region Services
            // ************************************************************************
            // https://metanit.com/sharp/aspnet5/1.1.php
            #region 2.������ ASP.NET Core
            #region 01 - Run()
            if (1 == 2)
            {
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello World !");
                });
            }
            #endregion

            #region 02 - Use() + Run() (1)
            if (1 == 2)
            {
                int x = 5;
                int y = 8;
                int z = 0;
                app.Use(async (context, next) =>
                {
                    z = x * y;
                    await next.Invoke();
                });

                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync($"x * y = {z}");
                });
            }
            #endregion

            #region 03 - () + Run() (2)
            if (1 == 2)
            {
                int x = 2;
                app.Use(async (context, next) =>
                {
                    x = x * 2;      // 2 * 2 = 4
                    await next.Invoke();    // ����� app.Run
                    x = x * 2;      // 8 * 2 = 16
                    await context.Response.WriteAsync($"Result: {x}");
                });

                app.Run(async (context) =>
                {
                    x = x * 2;  //  4 * 2 = 8
                    await Task.FromResult(0);
                });
            }
            #endregion

            #region 04 - Map()
            if (1 == 2)
            {
                app.Map("/index", Index);
                app.Map("/Home/about", About);
                //app.Map("/home", home =>
                //{
                //    home.Map("/index", Index);
                //    home.Map("/about", About);
                //});

                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Page Not Found");
                });
            }
            #endregion

            #region 05 - TokenMiddleware
            if (1 == 2)
            {
                // http://localhost:58982/Home/about?token=12345678
                app.UseMiddleware<TokenMiddleware>();

                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Page Not Found");
                });
            }
            #endregion

            #region 06 - TokenExtensions
            if (1 == 2)
            {
                // http://localhost:58982/Home/about?token=12345678
                app.UseToken();

                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Page Not Found");
                });
            }
            #endregion

            #region 07 - TokenParamExtensions
            if (1 == 2)
            {
                // http://localhost:58982/Home/about?token=555555
                app.UseTokenParam("555555");

                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello World");
                });
            }
            #endregion

            #region 08 - Authentication
            if (1 == 2)
            {
                // http://localhost:58982/about
                // http://localhost:58982/about?token=555555
                app.UseMiddleware<AuthenticationMiddleware>();
                app.UseMiddleware<RoutingMiddleware>();
            }
            #endregion

            #region 09 - ErrorHandling
            if (1 == 2)
            {
                // http://localhost:58982/about
                // http://localhost:58982/about?token=555555
                app.UseMiddleware<ErrorHandlingMiddleware>();
                app.UseMiddleware<AuthenticationMiddleware>();
                app.UseMiddleware<RoutingMiddleware>();
            }
            #endregion

            #region 10 - IWebHostEnvironment
            if (1 == 2)
            { 
                if (env.ApplicationName != null             // ��� ����������
                    && env.EnvironmentName != null          // �������� �����
                    && env.ContentRootPath != null          // ���� � �������� ����� ����������
                    && env.WebRootPath != null              // ���� � ����� wwwroot (����������� �������)
                    && env.ContentRootFileProvider != null  // ���������� ���������� Microsoft.AspNetCore.FileProviders.IFileProvider
                    && env.WebRootFileProvider != null      // ���������� ���������� Microsoft.AspNetCore.FileProviders.IFileProvider
                    )
                { }
            }
            #endregion
            #endregion

            #region 3.Dependency Injection
            #region 01 - UseDeveloperExceptionPage
            if (1 == 2)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.Run(async (context) =>
                {
                    int x = 0;
                    int y = 8 / x;
                    await context.Response.WriteAsync($"Result = {y}");
                });
            }
            #endregion

            #region 02 - UseExceptionHandler
            if (1 == 2)
            {
                env.EnvironmentName = "Production";
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                    app.UseExceptionHandler("/error");
                }
                app.Map("/error", ap => ap.Run(async context =>
                {
                    await context.Response.WriteAsync("DivideByZeroException occured!");
                }));
                app.Run(async (context) =>
                {
                    int x = 0;
                    int y = 8 / x;
                    await context.Response.WriteAsync($"Result = {y}");
                });
            }
            #endregion

            #region 03 - StatusCodePagesMiddleware 
            if (1 == 2)
            {
                // http://localhost:58982/hello
                // http://localhost:58982/about
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                // ��������� ������ HTTP
                app.UseStatusCodePages();

                app.Map("/hello", ap => ap.Run(async (context) =>
                {
                    await context.Response.WriteAsync($"Hello ASP.NET Core");
                }));
            }
            #endregion

            #region 04 - Dependency Injection
            if (1 == 2)
            {
                // ��� �������
                app.Run(async context =>
                {
                    var sb = new StringBuilder();
                    sb.Append("<h1>��� �������</h1>");
                    sb.Append("<table>");
                    sb.Append("<tr><th>���</th><th>Lifetime</th><th>����������</th></tr>");
                    foreach (var svc in _services)
                    {
                        sb.Append("<tr>");
                        sb.Append($"<td>{svc.ServiceType.FullName}</td>");
                        sb.Append($"<td>{svc.Lifetime}</td>");
                        sb.Append($"<td>{svc.ImplementationType?.FullName}</td>");
                        sb.Append("</tr>");
                    }
                    sb.Append("</table>");
                    context.Response.ContentType = "text/html;charset=utf-8";
                    await context.Response.WriteAsync(sb.ToString());
                });
            }
            #endregion

            #region 05 - DI (�������� ����� ��������)
            if (1 == 2)
            {
                //app.Run(async (context) =>
                //{
                //    await context.Response.WriteAsync(messageSender.Send());
                //});
            }
            #endregion

            #region 06 - DI (���������� ��� ���������� ��������)
            if (1 == 2)
            {
                //app.Run(async (context) =>
                //{
                //    context.Response.ContentType = "text/html; charset=utf-8";
                //    await context.Response.WriteAsync($"������� �����: {timeService?.GetTime()}");
                //});
            }
            #endregion

            #region 07 - DI (�������� ������������ - ������������)
            if (1 == 2)
            {
                //app.Run(async (context) =>
                //{
                //    await context.Response.WriteAsync(messageService.Send());
                //});
            }
            #endregion

            #region 08 - DI (�������� ������������ - HttpContext.RequestServices / ApplicationServices)
            if (1 == 2)
            {
                app.Run(async (context) =>
                {
                    //IMessageSender messageSender = context.RequestServices.GetService<IMessageSender>();
                    IMessageSender messageSender = app.ApplicationServices.GetService<IMessageSender>();
                    { }
                    context.Response.ContentType = "text/html;charset=utf-8";
                    await context.Response.WriteAsync(messageSender.Send());
                });
            }
            #endregion

            #region 09 - DI (�������� ������������ - Invoke / InvokeAsync)
            if (1 == 2)
            {
                app.UseMiddleware<MessageMiddleware>();
            }
            #endregion
            #endregion

            #region 4.������������
            #region 01 - ������ ������������
            if (1 == 2)
            {
                #region 1
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync(CustomConfiguration["firstname"]);
                });
                #endregion

                #region 2 - (�� ����� ����������� �������� ��� ��������� ��������� ��� ���������� �����)
                CustomConfiguration["firstname"] = "alice";
                CustomConfiguration["lastname"] = "simpson";
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync($"{CustomConfiguration["firstname"]} {CustomConfiguration["lastname"]} - {CustomConfiguration["age"]}");
                });
                #endregion
            }
            #endregion

            #region 02 - ������������ �� ���������
            if (1 == 2)
            {
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello world");
                });
            }
            #endregion

            #region 03 - ���������� ����� ��������� ��� �������� ������������
            if (1 == 2)
            {
                string envVars = "";
                envVars += "JAVA_HOME - ";
                if (AppConfiguration["JAVA_HOME"] != null) envVars += AppConfiguration["JAVA_HOME"];
                else envVars += "not set";

                envVars += "\nTEMP - ";
                if (AppConfiguration["TEMP"] != null) envVars += AppConfiguration["TEMP"];
                else envVars += "not set";

                envVars += "\nProgram Files - ";
                if (AppConfiguration["ProgramFiles"] != null) envVars += AppConfiguration["ProgramFiles"];
                else envVars += "not set";

                { }
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync(envVars);
                });
            }
            #endregion

            #region 04 - �������� ���������� ������������ (������������ � JSON / XML / INI)
            if (1 == 2)
            {
                var color = CustomConfiguration["color"];
                var text = CustomConfiguration["text"];
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync($"<p style='color:{color};'>{text}</p>");
                });
            }
            #endregion

            #region 05 - ����������� ���������� ������������
            if (1 == 2)
            {
                // ��������� � ����� conf.json
                string color = CustomConfiguration["color"];

                // ��������� � ������
                string name = CustomConfiguration["name"] + " - " + CustomConfiguration["age"];

                // ��������� � ���������� ����� ���������
                string path = "TEMP - " + CustomConfiguration["TEMP"];

                string text = $"<p style='color:{color};'>{name}</p>";
                text += $"<p>{path}</p>";
                { }
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync(text);
                });
            }
            #endregion

            #region 06 - ����������� ���������� ������������ (UseMiddleware)
            if (1 == 2)
            {
                app.UseMiddleware<ConfigMiddleware>();
            }
            #endregion

            #region 07 - ������ � ������������� (GetSection)
            if (1 == 2)
            {
                string color = CustomConfiguration["color"];

                IConfigurationSection connStrings = CustomConfiguration.GetSection("ConnectionStrings");
                string def_con = connStrings.GetSection("DefaultConnection").Value;
                
                string tko_con = CustomConfiguration.GetSection("ConnectionStrings:TKOConnection").Value;
                string resk_con = CustomConfiguration["ConnectionStrings:RESKConnection"];
                string nesk_con = CustomConfiguration.GetConnectionString("NESKConnection");

                string text = "";
                text += $"<table><tr>";
                text += $"<td>default - </td><td style='color:{color};'>{def_con}</td>";
                text += $"</tr></table>";
                text += $"<p>RESK - {resk_con}</p>";
                text += $"<p>NESK - {nesk_con}</p>";
                { }
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync(text);
                });
            }
            #endregion

            #region 08 - ������ � ������������� (������ ����� ������������)
            if (1 == 2)
            {
                string projectJsonContent = GetSectionContent(CustomConfiguration);
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("{\n" + projectJsonContent + "}");
                });
            }
            #endregion

            #region 09 - �������� ������������ �� ������
            if (1 == 2)
            {
                ConfigurationClass conf = new ConfigurationClass();
                CustomConfiguration.Bind(conf);

                // �������� ������ ������������ 
                ConnectionStringsClass conf_conn = CustomConfiguration
                    .GetSection("ConnectionStrings")
                    .Get<ConnectionStringsClass>()
                    ;

                string text = "";
                text += $"<table><tr>";
                text += $"<td>default - </td><td style='color:{conf.color};'>{conf.ConnectionStrings.DefaultConnection}</td>";
                text += $"</tr></table>";
                text += $"<p>TKO - {conf.ConnectionStrings.TKOConnection}</p>";
                text += $"<p>RESK - {conf_conn.RESKConnection}</p>";
                text += $"<p>NESK - {conf_conn.NESKConnection}</p>";
                { }
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync(text);
                });
            }
            #endregion

            #region 10 - �������� ������������ ����� IOptions
            if (1 == 2)
            {
                app.UseMiddleware<ConfigurationClassMiddleware>();
            }
            #endregion
            #endregion

            #region 5.��������� ����������
            #region 01 - HttpContext.Items
            if (1 == 2)
            {
                app.Use(async (context, next) =>
                {
                    context.Items["text1"] = "Text from HttpContext.Items";
                    context.Items.Add("text2", "������ ��� !!!");
                    await next.Invoke();
                });

                app.Run(async (context) =>
                {
                    string text = "";
                    if (context.Items.ContainsKey("text1")) text += $"<p>text1 - {context.Items["text1"]}</p>";
                    if (context.Items.ContainsKey("text2")) text += $"<p>text2 - {context.Items["text2"]}</p>";
                    context.Response.ContentType = "text/html; charset=utf-8";
                    await context.Response.WriteAsync(text);
                });
            }
            #endregion

            #region 02 - ����
            if (1 == 2)
            {
                app.Run(async (context) =>
                {
                    if (context.Request.Cookies.ContainsKey("name"))
                    {
                        // ������ ������
                        string name = context.Request.Cookies["name"];
                        await context.Response.WriteAsync($"Hello {name}!");
                    }
                    else
                    {
                        // ������ ������
                        context.Response.Cookies.Append("name", "Tom");
                        await context.Response.WriteAsync("Hello World!");
                    }
                });
            }
            #endregion

            #region 03 - ������
            if (1 == 2)
            {
                app.UseSession();

                app.Run(async (context) =>
                {
                    // ������ ������
                    if (context.Session.Keys.Contains("name"))
                        await context.Response.WriteAsync($"Hello {context.Session.GetString("name")}!");
                    else
                    {
                        // ������ ������
                        context.Session.SetString("name", "Tom");
                        await context.Response.WriteAsync("Hello World!");
                    }
                });
            }
            #endregion

            #region 04 - ������ (�������� ������� ��������)
            if (1 == 2)
            {
                app.UseSession();

                app.Run(async (context) =>
                {
                    if (context.Session.Keys.Contains("configuration"))
                    {
                        ConfigurationClass conf = context.Session.Get<ConfigurationClass>("configuration");
                        string text = "";
                        text += $"<table><tr>";
                        text += $"<td>default - </td><td style='color:{conf.color};'>{conf.ConnectionStrings.DefaultConnection}</td>";
                        text += $"</tr></table>";
                        text += $"<p>TKO - {conf.ConnectionStrings.TKOConnection}</p>";
                        text += $"<p>RESK - {conf.ConnectionStrings.RESKConnection}</p>";
                        text += $"<p>NESK - {conf.ConnectionStrings.NESKConnection}</p>";
                        { }

                        await context.Response.WriteAsync(text);
                    }
                    else
                    {
                        ConfigurationClass conf = new ConfigurationClass 
                        { 
                            color = "blue",
                            ConnectionStrings = new ConnectionStringsClass
                            {
                                DefaultConnection = "renowation_web",
                                TKOConnection = "renowation_web_tko",
                                RESKConnection = "renowation_web_resk",
                                NESKConnection = "renowation_web_nesk",
                            }
                        };
                        context.Session.Set<ConfigurationClass>("configuration", conf);
                        await context.Response.WriteAsync("Hello World!");
                    }
                });
            }
            #endregion
            #endregion

            #region 6.������������
            #region 01 - ������� ���� � ILogger
            if (1 == 2)
            {
                app.Run(async (context) =>
                {
                    //logging(context, logger);
                    await context.Response.WriteAsync("Hello World!");
                });
            }
            #endregion

            #region 02 - ������� ������� � ���������� ������������
            if (1 == 2)
            {
                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                    builder.AddDebug();
                });
                //ILogger logger = loggerFactory.CreateLogger<Startup>();
                ILogger<Startup> logger = loggerFactory.CreateLogger<Startup>();
                app.Run(async (context) =>
                {
                    logging(context, logger);
                    await context.Response.WriteAsync("Hello World!");
                });
            }
            #endregion

            #region 03 - �������� ���������� ������������
            if (1 == 2)
            {
                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                    builder.AddDebug();
                });
                loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "logger.txt"));
                ILogger logger = loggerFactory.CreateLogger("FileLogger");

                app.Run(async (context) =>
                {
                    logging(context, logger);
                    await context.Response.WriteAsync("Hello World!");
                });
            }
            #endregion
            #endregion

            #region 7.�������������
            #region 01 - ������ ������������� � ASP.NET Core
            if (1 == 2)
            {
                app.Use(async (context, next) =>
                {
                    // �������� �������� �����
                    Endpoint endpoint = context.GetEndpoint();

                    if (endpoint != null)
                    {
                        // �������� ������ ��������, ������� ������������ � �������� ������
                        var routePattern = (endpoint as Microsoft.AspNetCore.Routing.RouteEndpoint)?.RoutePattern?.RawText;

                        Debug.WriteLine($"Endpoint Name: {endpoint.DisplayName}");
                        Debug.WriteLine($"Route Pattern: {routePattern}");

                        // ���� �������� ����� ����������, �������� ��������� ������
                        await next();
                    }
                    else
                    {
                        Debug.WriteLine("Endpoint: null");
                        // ���� �������� ����� �� ����������, ��������� ���������
                        // http://localhost:58982/About
                        await context.Response.WriteAsync("Endpoint is not defined");
                    }
                });
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapGet("/index", async context =>
                    {
                        // http://localhost:58982/index
                        await context.Response.WriteAsync("Hello Index!");
                    });
                    endpoints.MapGet("/", async context =>
                    {
                        // http://localhost:58982
                        await context.Response.WriteAsync("Hello World!");
                    });
                });
            }
            #endregion

            #region 02 - RouterMiddleware
            if (1 == 2)
            {
                // ���������� ���������� ��������
                var myRouteHandler = new RouteHandler(Handle);

                // ������� �������, ��������� ����������
                var routeBuilder = new RouteBuilder(app, myRouteHandler);

                // ���� ����������� �������� - �� ������ ��������������� ������� {controller}/{action}
                // http://localhost:58982/1
                routeBuilder.MapRoute("default", "{controller}/");
                // http://localhost:58982/1/2
                routeBuilder.MapRoute("two_param", "{controller}/{action}");
                // http://localhost:58982/1/2/3
                routeBuilder.MapRoute("three_param", "{controller}/{action}/{id}");

                // ������ �������
                app.UseRouter(routeBuilder.Build());

                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            }
            #endregion

            #region 03 - ����������� ���������
            if (1 == 2)
            {
                var routeBuilder = new RouteBuilder(app);

                // http://localhost:58982/1/2
                routeBuilder.MapRoute("{controller}/{action}",
                    async context => {
                        context.Response.ContentType = "text/html; charset=utf-8";
                        await context.Response.WriteAsync("�������������� ������");
                    });

                // http://localhost:58982/1/2/3
                routeBuilder.MapRoute("{controller}/{action}/{id}", Handle3);

                // ����������� ��������
                //routeBuilder.MapRoute("default", "store/{action}");

                // �������������� ���������
                //routeBuilder.MapRoute("default", "{controller}/{action?}/{id?}");

                // �������� ��� ���������� �� ���������
                //routeBuilder.MapRoute("default", "{controller}/{action}/{id?}", 
                //    new 
                //    { 
                //        controller = "home", 
                //        action = "index" 
                //    });
                //routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");

                // �������� ������������� ���������� ���������� � �������
                // http://localhost:58982/Home/Index/1/name/book/order
                //routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}/{*catchall}");

                // ������������� ���������
                //http://localhost:58982/RuHome/Index-en/1
                //routeBuilder.MapRoute("default", "Ru{controller=Home}/{action=Index}-en/{id?}");

                // ��������� ���������� � ��������
                //http://localhost:58982/Store/Order/lumia-2015
                //routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{name}-{year}");

                app.UseRouter(routeBuilder.Build());

                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            }
            #endregion

            #region 04 - ������ � ����������
            if (1 == 2)
            {
                //http://localhost:58982/ind/lumia-2015
                var myRouteHandler = new RouteHandler(Handle4);

                var routeBuilder = new RouteBuilder(app, myRouteHandler);

                routeBuilder.MapRoute("default", "{action=Index}/{name}-{year}");

                app.UseRouter(routeBuilder.Build());

                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            }
            #endregion

            #region 05 - �������� ������ ��������
            if (1 == 2)
            {
                // http://localhost:58982/admin/index
                var routeBuilder = new RouteBuilder(app);

                routeBuilder.Routes.Add(new AdminRoute());

                routeBuilder.MapRoute("{controller}/{action}",
                    async context => {
                        context.Response.ContentType = "text/html;charset=utf-8";
                        await context.Response.WriteAsync("�������������� ������");
                    });

                app.UseRouter(routeBuilder.Build());

                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            }
            #endregion
            #endregion

            #region 19.WEB API
            #region 01 - �������� �����������
            if (1 == 2)
            {
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers(); // ���������� ������������� �� �����������
                });
            }
            #endregion
            #endregion
            // ************************************************************************
            #endregion

            #region Start
            if (1 == 2)
            {
                app.UseMiddleware<StartMiddleware>();
                app.UseMiddleware<StartEndpointVerifyMiddleware>();

                //app.UseMiddleware<StartEndpointVerifyMiddleware1>();

                //var routeBuilder = new RouteBuilder(app);
                //routeBuilder.MapRoute("{controller}/{action}/{id}", StartHandle1);
                //routeBuilder.MapRoute("{controller}/{action}", StartHandle2);
                //app.UseRouter(routeBuilder.Build());
            }
            #endregion

            #region Default - end
            //if (1 == 1)
            //{
            //    app.UseEndpoints(endpoints =>
            //    {
            //        endpoints.MapControllerRoute(
            //            name: "default",
            //            pattern: "{controller=Home}/{action=Index}/{id?}");
            //    });
            //}
            #endregion
        }
    }
}
