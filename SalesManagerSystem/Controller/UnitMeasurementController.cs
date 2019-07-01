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
    public class UnitMeasurementController
    {
        /// <summary>
        /// Save unit measurement
        /// </summary>
        /// <param name="key_unit"></param>
        /// <param name="description_unit"></param>
        /// <param name="calc_type_id"></param>
        /// <return></return>
        public UnitMeasurement SaveUnitMeasurement(string key_unit, string description_unit, int calc_type_id)
        {
            try
            {
                return new UnitMeasurementService().SaveUnitMeasurement(key_unit, description_unit, calc_type_id);
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }
    }
}
