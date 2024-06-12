using StronglyTypedIds;

namespace L2Earn.Domain.Abstractions;

public abstract class Entity<T>(T id)
{
    protected T Id { get; init; } = id;
}
