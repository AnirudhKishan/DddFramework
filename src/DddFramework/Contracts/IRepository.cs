namespace DddFramework
{
    interface IRepository<T> : IReadRepository<T>, ICreateUpdateRepository<T>, IDeleteRepository<T>
        where T : AggregateRoot
    {
    }
}
