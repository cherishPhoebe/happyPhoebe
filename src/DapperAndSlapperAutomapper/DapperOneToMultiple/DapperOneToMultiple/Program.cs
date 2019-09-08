using System;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DapperOneToMultiple
{
    class Program
    {
        private const string connectionString = @"Data Source=127.0.0.1;User ID=sa;Password=sa;Initial Catalog=AKDDB;Pooling=true;Max Pool Size=100;";
        
        static void Main(string[] args)
        {
            using (var conn = new SqlConnection(connectionString)) {
                Slapper.AutoMapper.Cache.ClearInstanceCache();

                var sql = @"select mb.Id,mb.Name,mb.OtherName,mb.EnglishName,mb.Introduction
                ,m.Id as Makes_ID,m.MasterBrandId as Makes_MasterBrandId,m.Name as Makes_Name,m.OtherName as Makes_Other_Name,m.Phone as Makes_Phone,m.WebSite as Makes_Web_Site,m.Introduction as Makes_Introduction
                from MasterBrand mb inner join Make m on mb.Id = m.MasterBrandId";

                dynamic tempResult = conn.Query<dynamic>(sql);

                Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(MasterBrand), new List<string> { "Id" });
                Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(Make), new List<string> { "Id" });
                Slapper.AutoMapper.Configuration.AddIdentifier(typeof(Make),"Id");

                var masterBrandList = (Slapper.AutoMapper.MapDynamic<MasterBrand>(tempResult) as IEnumerable<MasterBrand>).Take(1).ToList();

                Console.WriteLine(JsonConvert.SerializeObject(masterBrandList));

                Console.ReadKey();

            }




            Console.WriteLine("Hello World!");
        }


    }
}
