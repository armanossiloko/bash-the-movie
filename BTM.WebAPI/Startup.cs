using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTM.Database;
using BTM.Models;
using BTM.WebAPI.Handlers;
using BTM.WebAPI.Services;
using BTM.WebAPI.Settings;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;

namespace BTM.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Global.Avatars = $@"{env.ContentRootPath}\Assets\Avatars";
            Global.Covers = $@"{env.ContentRootPath}\Assets\Covers";
            Global.News = $@"{env.ContentRootPath}\Assets\News";
            Global.Logos = $@"{env.ContentRootPath}\Assets\News\Logos";
            Global.Soundtracks = $@"{env.ContentRootPath}\Assets\Soundtracks";
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            services.AddSingleton<IApplicationInfo, ApplicationInfo>(
                c => Configuration.GetSection("AppInfo").Get<ApplicationInfo>());

            // Adding database
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("LocalConnection")));

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            // CRUD
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IData<Media>, BaseData<Media>>();
            services.AddScoped<IData<News>, BaseData<News>>();
            services.AddScoped<IData<Image>, BaseData<Image>>();
            services.AddScoped<IData<Soundtrack>, BaseData<Soundtrack>>();
            services.AddScoped<IData<Trailer>, BaseData<Trailer>>();
            services.AddScoped<IData<Bug>, BaseData<Bug>>();
            services.AddScoped<IData<Feedback>, BaseData<Feedback>>();
            services.AddScoped<IData<Ticket>, BaseData<Ticket>>();
            services.AddScoped<IData<List>, BaseData<List>>();


            // Read
            services.AddScoped<IDataService<Country>, BaseDataService<Country>>();
            services.AddScoped<IDataService<Genre>, BaseDataService<Genre>>();
            services.AddScoped<IDataService<Studio>, BaseDataService<Studio>>();
            services.AddScoped<IDataService<Language>, BaseDataService<Language>>();


            // Create and read
            services.AddScoped<ICRData<PlotKeywords>, BaseCRData<PlotKeywords>>();
            services.AddScoped<ICRData<People>, BaseCRData<People>>();
            services.AddScoped<ICRData<Award>, BaseCRData<Award>>();



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseAuthentication();
            //app.UseHttpsRedirection();
            app.UseMvc();

            //CreateUserRoles(serviceProvider).Wait();
        }

        //private async Task CreateUserRoles(IServiceProvider serviceProvider)
        //{
        //    var RoleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();
        //    var UserManager = serviceProvider.GetRequiredService<UserManager<User>>();

        //    string[] roleNames = { "Member", "Admin" };

        //    IdentityResult roleResult;
        //    foreach (var roleName in roleNames)
        //    {
        //        var roleExist = await RoleManager.RoleExistsAsync(roleName);
        //        if (!roleExist)
        //        {
        //            roleResult = await RoleManager.CreateAsync(new Role(roleName));
        //        }
        //    }

        //    var poweruser = new User
        //    {
        //        UserName = Configuration["UserSettings:Username"],
        //        Email = Configuration["UserSettings:UserEmail"]
        //    };

        //    string userPWD = Configuration["UserSettings:UserPassword"];
        //    var _user = await UserManager.FindByEmailAsync(Configuration["UserSettings:AdminUserEmail"]);

        //    if (_user == null)
        //    {
        //        var createPowerUser = await UserManager.CreateAsync(poweruser, userPWD);
        //        if (createPowerUser.Succeeded)
        //        {
        //            await UserManager.AddToRoleAsync(poweruser, roleNames[0]);
        //            await UserManager.AddToRoleAsync(poweruser, roleNames[1]);
        //        }
        //    }
        //}
    }
}
