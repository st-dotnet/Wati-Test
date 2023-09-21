using Microsoft.EntityFrameworkCore;

namespace Wati_Test_Integer
{
    public interface IIntegerContext
    {
        DbSet<IntegerSumEntity> IntegerSumEntity { get; set; }
        int SaveChanges();
    }
}
