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
    public class CalcTypeImpl : Connection<CalcType>, ICalcTypeRepository
    {
        private static readonly DbContext _dbContext = new SalesConnection();

        public CalcTypeImpl() : base(_dbContext)
        {
        }

        public IEnumerable<CalcType> GetCalcTypes()
        {
            IQueryable<CalcType> query = _dbContext.Set<CalcType>().AsQueryable().AsNoTracking();
            var calcTypes = query.ToList();

            return calcTypes;
        }
    }
}
