using L2Earn.Domain.Abstractions;
using StronglyTypedIds;

namespace L2Earn.Domain.Courses;

[StronglyTypedId]
public partial struct CourseId;

public sealed class Course : AggregateRoot<CourseId>
{
    private Course(
        CourseId id,
        CourseTitle title,
        Headline headline,
        Thumbnail thumbnail,
        string description,
        Difficulty difficulty,
        bool isPublished,
        bool isPaid,
        List<Module> modules,
        DateTime createdOn
    ) : base(id)
    {
        Title = title;
        Headline = headline;
        Thumbnail = thumbnail;
        Description = description;
        Difficulty = difficulty;
        IsPublished = isPublished;
        IsPaid = isPaid;
        Modules = modules;
        CreatedOn = createdOn;
    }

    public CourseTitle Title { get; private set; }

    public Headline Headline { get; private set; }

    public Thumbnail Thumbnail { get; private set; }

    public string Description { get; private set; }

    public Difficulty Difficulty { get; private set; }

    public bool IsPublished { get; private set; }

    public bool IsPaid { get; private set; }

    public List<Module> Modules { get; private set; }

    public DateTime CreatedOn { get; private set; }

    public static Course Create(
        CourseTitle courseTitle,
        Headline headline,
        Thumbnail thumbnail,
        string description,
        Difficulty difficulty,
        bool isPublished,
        bool isPaid,
        List<Module> modules,
        DateTime createdOn
    ) => new(
        CourseId.New(),
        courseTitle,
        headline,
        thumbnail,
        description,
        difficulty,
        isPublished,
        isPaid,
        modules,
        createdOn
    );

    public Module CreateModule(
        ModuleName name,
        ModuleSummary summary,
        List<Lesson> lessons,
        bool isActive
    ) => Module.Create(Id, name, summary, lessons, isActive);
}
