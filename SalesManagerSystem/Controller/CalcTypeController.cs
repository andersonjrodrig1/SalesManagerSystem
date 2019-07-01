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
    public class CalcTypeController
    {
        /// <summary>
        /// Get Calc Types
        /// </summary>
        /// <return></return>
        public IEnumerable<CalcType> GetCalcTypes()
        {
            try
            {
                return new CalcTypeService().GetCalcTypes();
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }
    }
}
