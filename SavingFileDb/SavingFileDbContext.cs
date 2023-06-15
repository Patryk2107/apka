using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SavingFileDb.Entities;

namespace SavingFileDb
{
    public class SavingFileDbContext: DbContext
    {
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<StatusFile> StatusFiles { get; set; }

        public SavingFileDbContext(DbContextOptions<SavingFileDbContext> options) : base(options)
        {
        }

    }
}
