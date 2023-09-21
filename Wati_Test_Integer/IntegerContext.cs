using Microsoft.EntityFrameworkCore;

namespace Wati_Test_Integer
{
    public class IntegerContext :DbContext, IIntegerContext
    {
        public IntegerContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<IntegerSumEntity> IntegerSumEntity { get; set; }
    }
}
