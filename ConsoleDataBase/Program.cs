using System.Text.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ConsoleDataBase
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (ConsoleDataBaseContext context = new ConsoleDataBaseContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                context.Database.EnsureCreated();
            }
        }
    }
}