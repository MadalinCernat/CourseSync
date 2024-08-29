using CourseSync.Data;
using CourseSync.Domain.Models;
using CourseSync.Data.DatabaseContext;

namespace CourseSync.Data.Repositories
{
    public class LearningStepRepository : Repository<LearningStep>, ILearningStepRepository
    {
        public LearningStepRepository(CourseSyncDbContext context) : base(context)
        {
        }

        // Add specific methods for LearningStep if needed
    }

    public interface ILearningStepRepository : IRepository<LearningStep>
    {
        // Add specific methods for LearningStep if needed
    }
}
