namespace L2Earn.Domain.Abstractions;

public abstract class AggregateRoot<T>(T id) : Entity<T>(id);
