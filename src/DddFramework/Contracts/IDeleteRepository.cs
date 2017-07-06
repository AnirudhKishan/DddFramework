using System;

namespace DddFramework
{
    public interface IDeleteRepository<T>
        where T : AggregateRoot
    {
        void Delete(Guid id);
    }
}
