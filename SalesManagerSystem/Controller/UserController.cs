using SalesManagerSystem.Factories;
using SalesManagerSystem.Model;
using SalesManagerSystem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Controller
{
    public class UserController
    {
        /// <summary>
        /// Return all users
        /// </summary>
        /// <return></return>
        public async Task<IEnumerable<User>> GetUsers()
        {
            try
            {
                return await new UserService().GetAll();
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            } 
        }

        /// <summary>
        /// Return user by id
        /// </summary>
        /// <param name="id"></param>
        /// <return></return>
        public async Task<User> GetUserById(int id)
        {
            try
            {
                return await new UserService().GetUserById(id);
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        /// <sumary>
        /// Get user login
        /// </sumary>
        /// <param name="user_login"></param>
        /// <param name="user_password"></param>
        /// <returns></returns>
        public User GetUserLogin(string user_login, string user_password)
        {
            try
            {
                return new UserService().GetUserLogin(user_login, user_password);
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        /// <summary>
        /// Save new user
        /// </summary>
        /// <param name="user_name"></param>
        /// <param name="user_login"></param>
        /// <param name="user_password"></param>
        /// <param name="type_id"></param>
        /// <return></return>
        public User SaveUser(string user_name, string user_login, string user_password, int type_id)
        {
            try
            {
                return new UserService().SaveUser(user_name, user_login, user_password, type_id);
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }
    }
}
