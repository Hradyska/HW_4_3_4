using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ConsoleDataBase
{
    public sealed class ConsoleDataBaseContextFactory : IDesignTimeDbContextFactory<ConsoleDataBaseContext>
    {
        public ConsoleDataBaseContext CreateDbContext(string[] args)
        {
            string connectionFile = File.ReadAllText("config.json");
            Connection connection = JsonSerializer.Deserialize<Connection>(connectionFile);
            string connectionString = connection.GetConnectionString.CString;
            var optionsBuilder = new DbContextOptionsBuilder<ConsoleDataBaseContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            return new ConsoleDataBaseContext(options);
        }
    }
}