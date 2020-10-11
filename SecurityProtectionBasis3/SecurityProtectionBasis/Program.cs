using Microsoft.Extensions.DependencyInjection;
using SecurityProtectionBasis.DataAccess;
using SecurityProtectionBasis.Interfaces;
using SecurityProtectionBasis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityProtectionBasis
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IFileManager, FileManager>();
            services.AddScoped<IUser, UserService>();
            services.AddScoped<IAdmin, AdminService>();
            services.AddScoped<ICryptService, CryptService>();
            ServiceProvider = services.BuildServiceProvider();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1(false));
        }
    }
}
