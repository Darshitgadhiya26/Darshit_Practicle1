using Darshit_Practicle1.Models;
using Microsoft.EntityFrameworkCore;

namespace Darshit_Practicle1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }
    }
}
