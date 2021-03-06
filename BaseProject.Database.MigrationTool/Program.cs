﻿using System;
using System.Configuration;
using System.Reflection;
using DbUp;

namespace BaseProject.Database.MigrationTool
{
    class Program
    {
        private static readonly string[] Databases = { "Users" };
        private const string ScriptPrefix = "BaseProject.Database.MigrationTool.Scripts";
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        static int Main(string[] args)
        {
            foreach (var database in Databases)
            {
                var connectionString = ConnectionString;
                // Ensure the database exists, if not, create it
                EnsureDatabase.For.SqlDatabase(connectionString);

                var upgrader =
                    DeployChanges.To
                        .SqlDatabase(connectionString)
                        .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly(),
                            s => s.StartsWith($"{ScriptPrefix}.{database}"))
                        .LogToConsole()
                        .Build();

                var result = upgrader.PerformUpgrade();

                if (!result.Successful)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result.Error);
                    Console.ResetColor();
#if DEBUG
                    Console.ReadLine();
#endif
                    return -1;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!");
                Console.ResetColor();
            }
            return 0;
        }
    }

}
