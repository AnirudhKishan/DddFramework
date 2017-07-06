using System;

namespace DddFramework
{
    public interface IReadRepository<T>
        where T : AggregateRoot
    {
        T GetById(Guid id);
    }
}