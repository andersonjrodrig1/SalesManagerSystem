using SalesManagerSystem.Model;
using SalesManagerSystem.Repositories.Connection;
using SalesManagerSystem.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Repositories.Impl
{
    public class UserImpl : Connection<User>, IUserRepository
    {
        private static readonly DbContext _dbContext = new SalesConnection();

        public UserImpl() : base(_dbContext)
        {
        }

        public async Task<User> GetUserById(int id)
        {
            IQueryable<User> users = _dbContext.Set<User>().AsQueryable();
            var query = users.Where(x => x.Id == id).FirstOrDefaultAsync();

            return await query;
        }

        public async Task<IEnumerable<User>> GetUserByFilter(string name, string login, int? typeId)
        {
            IList<User> users = await _dbContext.Set<User>().ToListAsync();

            if (!string.IsNullOrEmpty(name))
            {
                users = users.Where(x => x.UserName.Equals(name)).ToList();
            }

            if (!string.IsNullOrEmpty(login))
            {
                users = users.Where(x => x.UserLogin.Equals(login)).ToList();
            }

            if (typeId.HasValue)
            {
                users = users.Where(x => x.UserTypeId == typeId).ToList();
            }

            return users;
        }

        public User GetUserLogin(string login, string password)
        {
            IQueryable<User> users = _dbContext.Set<User>().AsQueryable();
            IQueryable<UserType> userTypes = _dbContext.Set<UserType>().AsQueryable();

            var query = (from u in users
                         join t in userTypes on u.UserTypeId equals t.Id
                         where u.UserLogin.Equals(login) &&
                               u.UserPassword.Equals(password)
                         select u)
                             .FirstOrDefault(); 

            return query;
        }
    }
}
