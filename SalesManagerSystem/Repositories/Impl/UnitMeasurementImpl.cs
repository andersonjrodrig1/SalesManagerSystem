using SalesManagerSystem.Model;
using SalesManagerSystem.Repositories.Connection;
using SalesManagerSystem.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Repositories.Impl
{
    public class UnitMeasurementImpl : Connection<UnitMeasurement>, IUnitMeasurementRepository
    {
        private static readonly DbContext _dbContext = new SalesConnection();

        public UnitMeasurementImpl() : base(_dbContext)
        {
        }
    }
}
