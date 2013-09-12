using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brm.Commerce.DataLayer
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext _dbContext;

        public UnitOfWork()
        {
            _dbContext = new DbContext();
        }

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
