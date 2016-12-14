using Microsoft.EntityFrameworkCore;

namespace eftest1
{
    public partial class OnboardRetailContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=OnboardRetail;Integrated Security=True");
        }

        public DbSet<TbCcbdetails> TbCcbdetails { get; set; }
        public DbSet<TbCcbfiles> TbCcbfiles { get; set; }
        public DbSet<TbCcbsaleTypes> TbCcbsaleTypes { get; set; }
        public DbSet<TbCcbtrans> TbCcbtrans { get; set; }

    }
}