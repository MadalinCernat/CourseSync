using CourseSync.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSync.Data.DatabaseContext
{
    public class CourseSyncDbContext : DbContext
    {
        public CourseSyncDbContext(DbContextOptions<CourseSyncDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityUser> CommunityUsers { get; set; }
        public DbSet<LearningPath> LearningPaths { get; set; }
        public DbSet<LearningStep> LearningSteps { get; set; }
    }
}
