using Microsoft.EntityFrameworkCore;
using ElevenNote.data.Entities;

namespace ElevenNote.data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    public DbSet<UserEntity> Users { get; set; }

    }

}