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
    public class UserService : IDisposable
    {
        private UserImpl _userImpl = new UserImpl();

        public UserService()
        {
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            try
            {
                return await _userImpl.GetAll();
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        public async Task<User> GetUserById(int id)
        {
            try
            {
                return await _userImpl.GetUserById(id);
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        public async Task<IEnumerable<User>> GetUsersByFilter(string name, string login, int? typeId)
        {
            try
            {
                return await _userImpl.GetUserByFilter(name, login, typeId);
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        public User GetUserLogin(string login, string password)
        {
            try
            {
                return _userImpl.GetUserLogin(login, password);
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        public User SaveUser(string user_name, string user_login, string user_password, int type_id)
        {
            try
            {
                var user = new User()
                {
                    UserName = user_name,
                    UserLogin = user_login,
                    UserPassword = user_password,
                    UserTypeId = type_id
                };

                User _entity = _userImpl.Save(user);

                return _entity;
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }
 
        public void Dispose()
        {
            _userImpl = null;
        }
    }
}
