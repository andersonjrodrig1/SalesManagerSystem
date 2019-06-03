using SalesManagerSystem.Factories;
using SalesManagerSystem.Model;
using SalesManagerSystem.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Service
{
    public class UserTypeService : IDisposable
    {
        private UserTypeImpl _userTypeImpl = new UserTypeImpl();

        public UserTypeService() { }

        public async Task<IEnumerable<UserType>> GetUserTypes()
        {
            try
            {
                return await _userTypeImpl.GetAll();
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        public async Task<UserType> GetUserTypeById(int id)
        {
            try
            {
                return await _userTypeImpl.GetUserTypeById(id);
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        public void Dispose()
        {
            _userTypeImpl.Dispose();
        }
    }
}
