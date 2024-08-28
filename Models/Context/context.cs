using Microsoft.EntityFrameworkCore;

public class context:DbContext
{
    public DbSet<Users> Users_tbl { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
                optionsBuilder.UseSqlServer("server=.\\SQL2019;database=IliaForm;trusted_connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True");
    }
}