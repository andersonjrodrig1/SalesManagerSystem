using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        #region 
        public virtual UserType UserType { get; set; }
        public int UserTypeId { get; set; }
        #endregion
    }
}
