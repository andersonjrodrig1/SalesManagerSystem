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
    public class UnitMeasurementService : IDisposable
    {
        public UnitMeasurementImpl _unitMeasurementImpl = new UnitMeasurementImpl();

        public UnitMeasurement SaveUnitMeasurement(string key_unit, string description_unit, int calc_type_id)
        {
            try {
                UnitMeasurement _entity = new UnitMeasurement()
                {
                    KeyUnit = key_unit,
                    DescriptionUnit = description_unit,
                    CalcTypeId = calc_type_id
                };

                return _unitMeasurementImpl.Save(_entity);
            }
            catch (Exception ex)
            {
                LoogerApplication.LoogerError(this.GetType().Name, MethodInfo.GetCurrentMethod().Name, ex);
                throw ex;
            }
        }

        public void Dispose()
        {
            _unitMeasurementImpl = null;
        }
    }
}
