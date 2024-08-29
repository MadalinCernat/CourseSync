using CourseSync.Data;
using CourseSync.Domain.Models;
using CourseSync.Data.DatabaseContext;

namespace CourseSync.Data.Repositories
{
    public class LearningPathRepository : Repository<LearningPath>, ILearningPathRepository
    {
        public LearningPathRepository(CourseSyncDbContext context) : base(context)
        {
        }

        // Add specific methods for LearningPath if needed
    }

    public interface ILearningPathRepository : IRepository<LearningPath>
    {
        // Add specific methods for LearningPath if needed
    }
}
