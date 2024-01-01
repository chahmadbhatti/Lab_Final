using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace labf

{
    public class YourDatabaseContext : dbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public YourDatabaseContext() : base(GetOptions())
        {
        }

        private static DbContextOptions<YourDatabaseContext> GetOptions()
        {
            return new DbContextOptionsBuilder<YourDatabaseContext>()
                .UseSqlServer(ConnectionString)
                .Options;
        }
    }
}
