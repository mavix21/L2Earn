using L2Earn.Domain.Abstractions;
using L2Earn.Domain.Modules;

namespace L2Earn.Domain.Courses;

public sealed class Course : Entity
{
    private Course(
        Guid id,
        Title title,
        Headline headline,
        ImageUrl imageUrl,
        string description,
        bool isPublished,
        bool isPaid,
        List<Module> modules,
        DateTime createdOn
    ) : base(id)
    {
        Id = id;
        Title = title;
        Headline = headline;
        ImageUrl = imageUrl;
        Description = description;
        IsPublished = isPublished;
        IsPaid = isPaid;
        Modules = modules;
        CreatedOn = createdOn;
    }

    public Guid Id { get; private set; }
    public Title Title { get; private set; }
    public Headline Headline { get; private set; }
    public ImageUrl ImageUrl { get; private set; }
    public string Description { get; private set; }
    public bool IsPublished { get; private set; }
    public bool IsPaid { get; private set; }
    public List<Module> Modules { get; private set; }
    public DateTime CreatedOn { get; private set; }

    public static Course Create(
        Title title,
        Headline headline,
        ImageUrl imageUrl,
        string description,
        bool isPublished,
        bool isPaid,
        List<Module> modules,
        DateTime createdOn
    ) => new(
        Guid.NewGuid(),
        title,
        headline,
        imageUrl,
        description,
        isPublished,
        isPaid,
        modules,
        createdOn
    );
}
