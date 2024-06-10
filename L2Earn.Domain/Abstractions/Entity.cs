namespace L2Earn.Domain.Abstractions
{
    public abstract class Entity(Guid id)
    {
        Guid Id { get; init; } = id;
    }
}
