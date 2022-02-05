using ShoppingBackend.BuildingBlocks.Interfaces;
using System;
using System.Collections.Generic;

namespace ShoppingBackend.BuildingBlocks.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public T Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<T> List()
        {
            throw new NotImplementedException();
        }

        public T Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
