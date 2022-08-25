using Microsoft.EntityFrameworkCore;
using EFMVC.Models;

namespace EFMVC.Context
{
    public class MVCContext:DbContext
    {
        public MVCContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
