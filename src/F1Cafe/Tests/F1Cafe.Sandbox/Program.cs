using System;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using AngleSharp.Parser.Html;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using F1Cafe.Web.Data;

namespace F1Cafe.Sandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"{typeof(Program).Namespace} ({string.Join(" ", args)}) starts working...");
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider(true);

            using (var serviceScope = serviceProvider.CreateScope())
            {
                serviceProvider = serviceScope.ServiceProvider;
                SandboxCode(serviceProvider);
            }
        }

        private static void SandboxCode(IServiceProvider serviceProvider)
        {
            //var context = serviceProvider.GetService<F1CafeDbContext>();
            ////Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //var parser = new HtmlParser();
            //var webClient = new WebClient(); /*{ Encoding = Encoding.GetEncoding("windows-1251") };*/
            //var url = "https://en.wikipedia.org/wiki/List_of_Formula_One_driver_numbers";
            //var html = webClient.DownloadString(url);

            //var document = parser.Parse(html);
            //var cellSelector = ".sortable wikitable jquery-tablesorter, tr td:nth-child(2)"?.Trim();
            //var cells = document.QuerySelectorAll(cellSelector);
            //var names = string.Join(Environment.NewLine, cells.Select(m => m.TextContent).ToList());
            //Console.WriteLine(names);
            //for (var i = 0; i < 1000; i++)
            //{
            //    var url = "https://en.wikipedia.org/wiki/List_of_Formula_One_driver_numbers";

            //    string html = null;

            //    for (int j = 0; j < 10; j++)
            //    {
            //        try
            //        {
            //            html = webClient.DownloadString(url);
            //            break;
            //        }
            //        catch (Exception e)
            //        {
            //            Thread.Sleep(10000);
            //        }
            //    }

            //    if (string.IsNullOrWhiteSpace(html))
            //    {
            //        continue;
            //    }

            //    var document = parser.Parse(html);
            //    var name = document.QuerySelector(".sortable wikitable jquery-tablesorter, tr td:nth-child(2)")?.TextContent?.Trim();
            //    var country = document.QuerySelector("tr td:nth-child(3)")?.TextContent?.Trim();

            //    Console.WriteLine($"{name} => {country}");
            //}
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .Build();

            services.AddDbContext<F1CafeDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
