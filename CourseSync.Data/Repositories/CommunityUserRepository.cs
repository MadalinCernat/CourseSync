using CourseSync.Data;
using CourseSync.Domain.Models;
using CourseSync.Data.DatabaseContext;

namespace CourseSync.Data.Repositories
{
    public class CommunityUserRepository : Repository<CommunityUser>, ICommunityUserRepository
    {
        public CommunityUserRepository(CourseSyncDbContext context) : base(context)
        {
        }

        // Add specific methods for CommunityUser if needed
    }

    public interface ICommunityUserRepository : IRepository<CommunityUser>
    {
        // Add specific methods for CommunityUser if needed
    }
}
