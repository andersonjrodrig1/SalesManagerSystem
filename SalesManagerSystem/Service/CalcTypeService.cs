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
    public class CalcTypeService : IDisposable
    {
        private CalcTypeImpl calcTypeImpl = new CalcTypeImpl();

        public IEnumerable<CalcType> GetCalcTypes()
        {
            try
            {
                return calcTypeImpl.GetCalcTypes();
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        public void Dispose()
        {
            calcTypeImpl = null;
        }
    }
}
