namespace DddFramework
{
    public interface ICreateUpdateRepository<T>
        where T : AggregateRoot
    {
        void Save(T aggregateRoot);
    }
}
