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
    public class UserTypeImpl : Connection<UserType>, IUserTypeRepository
    {
        private static DbContext _dbContext = new SalesConnection();

        public UserTypeImpl() : base(_dbContext)
        {
        }

        public async Task<UserType> GetUserTypeById(int userTypeId)
        {
            var query = await _dbContext.Set<UserType>().ToListAsync();
            var userType = query.Where(x => x.Id.Equals(userTypeId)).FirstOrDefault();

            return userType;
        }
    }
}
