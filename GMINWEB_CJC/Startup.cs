using GMINWEB_Rebuild.Areas.Identity;
using GMINWEB_Rebuild.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DataAccessLibrary;
using DataAccessLibrary.Data;
using Blazored.Modal;
using Radzen;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.Blazor.Reporting;
using GMINWEB_Rebuild.Services;
using GMINWEB_Rebuild.Model;
using System.Linq;

namespace GMINWEB_Rebuild
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Configuration = configuration;

            //configurationfdsfdsdf
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllers();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddRazorPages();
            services.AddServerSideBlazor().AddHubOptions(o =>
            {
                o.MaximumReceiveMessageSize = 10 * 1024 * 1024;
            });
            services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });
            services.AddHttpClient();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            services.AddTransient<IRoleData, RoleData>();
            services.AddTransient<IWarehouseData, WarehouseData>();
            services.AddTransient<INoticeData, NoticeData>();
            services.AddTransient<IMenuData, MenuData>();
            services.AddTransient<IGroupData, GroupData>();
            services.AddTransient<IBizUnitData, BizUnitData>();
            services.AddTransient<IPOrderData, POrderData>();
            services.AddTransient<IUserData, UserData>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IFileData, FileData>();
            services.AddTransient<ICommonCodeData, CommonCodeData>();
            services.AddTransient<IOrderData, OrderData>();
            services.AddTransient<IWorkOrderData, WorkOrderData>();
            services.AddTransient<IItemData, ItemData>();
            services.AddTransient<ICustomerData, CustomerData>();
            services.AddTransient<ICustHistData, CustHistData>();
            services.AddTransient<IASData, ASData>();
            services.AddTransient<IVOCData, VOCData>();
            services.AddTransient<IPOInItemData, POInItemData>();
            services.AddTransient<IBOMData, BOMData>();
            services.AddTransient<IWorkData,WorkData>();
            services.AddTransient<IOutPDItemData, OutPDItemData>();
            services.AddTransient<IWorkPlanData, WorkPlanData>();
            services.AddTransient<IOutItemData, OutItemData>();
            services.AddTransient<IItemOrderData, ItemOrderData>();
            services.AddTransient<IOrderMonitoringData, OrderMonitoringData>();
            services.AddTransient<IInventoryData, InventoryData>();
            services.AddTransient<IInventoryCheckData, InventoryCheckData>();
            services.AddTransient<ISalesData, SalesData>();
            services.AddTransient<IDashboardData, DashboardData>();
            //services.AddTransient<IWorkOrderHData, WorkOrderHData>();
            services.AddTransient<IPDItemImageData, PDItemImageData>();


            services.AddBlazoredModal();
            services.AddScoped<TokenProvider>();
            services.AddScoped<DialogService>();
            services.AddScoped<NotificationService>();
            services.AddScoped<TooltipService>();
            services.AddScoped<ContextMenuService>();
            services.AddDevExpressBlazorReporting();
            services.AddScoped<ReportStorageWebExtension, ReportStorageWebExtension1>();
            services.AddScoped<GitHubService>();
          

        }
        private RequestLocalizationOptions GetLocalizationOptions()
        {
            var cultures = Configuration.GetSection("Cultures")
                .GetChildren().ToDictionary(x => x.Key, x => x.Value);

            var supportedCultures = cultures.Keys.ToArray();

            var localizationOptions = new RequestLocalizationOptions()
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);

            return localizationOptions;
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRequestLocalization(GetLocalizationOptions());
            app.UseDevExpressBlazorReporting();
            
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
