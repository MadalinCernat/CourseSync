using CourseSync.Data;
using CourseSync.Domain.Models;
using CourseSync.Data.DatabaseContext;

namespace CourseSync.Data.Repositories
{
    public class CommunityRepository : Repository<Community>, ICommunityRepository
    {
        public CommunityRepository(CourseSyncDbContext context) : base(context)
        {
        }

        // Add specific methods for Community if needed
    }

    public interface ICommunityRepository : IRepository<Community>
    {
        // Add specific methods for Community if needed
    }
}
