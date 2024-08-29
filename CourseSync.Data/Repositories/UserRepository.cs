using CourseSync.Data;
using CourseSync.Domain.Models;
using CourseSync.Data.DatabaseContext;

namespace CourseSync.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(CourseSyncDbContext context) : base(context)
        {
        }

        // Add specific methods for User if needed
    }

    public interface IUserRepository : IRepository<User>
    {
        // Add specific methods for User if needed
    }
}
