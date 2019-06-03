using SalesManagerSystem.Model;
using SalesManagerSystem.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Controller
{
    public class UserTypeController
    {
        /// <summary>
        /// Return Types of User to System
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<UserType>> GetUserTypes()
        {
            try
            {
                return await new UserTypeService().GetUserTypes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Return Type of User by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<UserType> GetUserTypeById(int id)
        {
            try
            {
                return await new UserTypeService().GetUserTypeById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
