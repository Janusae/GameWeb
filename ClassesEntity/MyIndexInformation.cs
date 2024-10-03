using Microsoft.EntityFrameworkCore;

namespace MyTestProject.ClassesEntity
{
    public class MyIndexInformation : DbContext
    {
        public MyIndexInformation(DbContextOptions<MyIndexInformation> options)
        : base(options)
        {
        }
        public DbSet<IndexPagesInformation> IndexInfo { get; set; }
    }
}
