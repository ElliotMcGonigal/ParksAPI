using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
    public class ParksAPIContext : DbContext
    {
        public ParksAPIContext(DbContextOptions<ParksAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
              .HasData(
                  new Park { ParkId = 1, Name = "Crater Lake", Type = "National", Year = 1902  },
                  new Park { ParkId = 2, Name = "Yellowstone", Type = "National", Year = 1872  },
                  new Park { ParkId = 3, Name = "Yosemite", Type = "National", Year = 1890  },
                  new Park { ParkId = 4, Name = "Grand Teton", Type = "National", Year = 1950  },
                  new Park { ParkId = 5, Name = "Tryon Creek", Type = "State", Year = 1971  },
                  new Park { ParkId = 6, Name = "Champoeg", Type = "State", Year = 1913  },
                  new Park { ParkId = 7, Name = "Silver Falls", Type = "State", Year = 1933  }

              );
        
        }
        public DbSet<Park> Parks { get; set; }
    }
}