using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBackend.BuildingBlocks.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public IReadOnlyCollection<T> List();
        public T Get(Guid id);
        public T Update(Guid id);
        public T Delete(Guid id);
    }
}
