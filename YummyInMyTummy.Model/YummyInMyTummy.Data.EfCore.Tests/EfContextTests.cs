using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace YummyInMyTummy.Data.EfCore.Tests
{
    public class EfContextTests
    {
        public EfContext CreateContext()
        {
            string conString = "Server=(localdb)\\mssqllocaldb;Database=YummyInMyTummy_TestDb;Trusted_Connection=true;TrustServerCertificate=true;";
            var optionsBuilder = new DbContextOptionsBuilder<EfContext>();
            optionsBuilder.UseSqlServer(conString);

            return new EfContext(optionsBuilder.Options);
        }

        [Fact]
        public void Can_create_Db()
        {
            var con = CreateContext();  
            con.Database.EnsureDeleted();

            var result = con.Database.EnsureCreated();

            Assert.True(result);
        }
    }
}