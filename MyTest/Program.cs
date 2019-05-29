using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyTest.Models;
using RepositoryAndUnitOfWork.Repositories;

namespace MyTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customers = new List<TodoItem>()
            {
                new TodoItem()
                {
                    Id = 1,
                    Name ="Pratik",
                    IsComplete = true
                },
                new TodoItem()
                {
                    Id = 2,
                    Name ="Ram",
                    IsComplete = true
                }
               
            };

            var annoyingCustomer = new TodoItem()
            {
               Id = 1,
               Name ="Pratik",
               IsComplete = true
            };

            // select the desired operation
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
