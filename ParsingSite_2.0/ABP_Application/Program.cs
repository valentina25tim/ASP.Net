using ABP_Bll.Repositories;
using ABP_Dal.DataBase;
using ABP_Dal.Parsing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABP_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Print print = new Print();
            print.PrintAtConsole();

            //DbMigrations migration = new DbMigrations();
            //migration.ConfigureServices();
        }

    }
}