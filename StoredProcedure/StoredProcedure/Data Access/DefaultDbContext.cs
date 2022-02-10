using Microsoft.EntityFrameworkCore;
using StoredProcedure.Models;

namespace StoredProcedure.Data_Access
{
    public class DefaultDbContext:DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
             : base(options)
        {

        }
        public virtual DbSet<EmployeeDetails>? RetrieveEmployeeDetails { get; set; }
        public DbSet<EmployeeDetails>? EmployeeDetails { get; set; }
    }
}
