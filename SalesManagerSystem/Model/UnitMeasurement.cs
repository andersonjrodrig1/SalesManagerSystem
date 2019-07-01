using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Model
{
    public class UnitMeasurement
    {
        public int Id { get; set; }
        public string KeyUnit { get; set; }
        public string DescriptionUnit { get; set; }

        #region CalcType
        public int CalcTypeId { get; set; }
        public CalcType CalcType { get; set; }
        #endregion
    }
}
