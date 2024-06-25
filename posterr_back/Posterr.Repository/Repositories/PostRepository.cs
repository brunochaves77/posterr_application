using Posterr.Domain.Entities;
using Posterr.Domain.Interfaces;

namespace Posterr.Repository.Repositories {
    public class PostRepository : RepositoryBase<Post>, IRepositoryBase<Post> {

        public PostRepository(AppDataContext context) : base(context) { }

        public int CountPostsByUsersInDay(Guid userId, DateTime date) {

            var count = this.Context
                .Posts
                .Where(x => x.UserID == userId && x.CreatedAt.Date == date.Date)
                .Count();

            return count;

        }

    }
}
