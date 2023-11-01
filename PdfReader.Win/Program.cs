using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PdfReader.Ioc;
using System;
using System.Windows.Forms;

namespace PdfReader.Win
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var host = CreateHostBuilder().Build())
            {
                Application.Run(host.Services.GetRequiredService<MainForm>());
            }
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                       .ConfigureLogging(builder => builder.ClearProviders().AddConsole())
                       .ConfigureServices(service =>
                       {
                           service.AddTransient<MainForm>();
                           RegisterServices.Register(service);
                       });
        }
    }
}