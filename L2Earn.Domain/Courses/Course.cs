using L2Earn.Domain.Abstractions;
using StronglyTypedIds;

namespace L2Earn.Domain.Courses;

[StronglyTypedId]
public partial struct CourseId;

public sealed class Course : AggregateRoot<CourseId>
{
    private Course(
        CourseId id,
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

    public CourseId Id { get; private set; }

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
        CourseId.New(),
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
