using L2Earn.Domain.Abstractions;
using StronglyTypedIds;

namespace L2Earn.Domain.Courses;

[StronglyTypedId]
public partial struct ModuleId;

public class Module : Entity<ModuleId>
{
    private Module(
        ModuleId id,
        CourseId courseId,
        ModuleName name,
        ModuleSummary moduleSummary,
        List<Lesson> lessons,
        bool isActive
    ) : base(id)
    {
        CourseId = courseId;
        Name = name;
        Summary = moduleSummary;
        Lessons = lessons;
        IsActive = isActive;
    }

    public CourseId CourseId { get; private set; }

    public ModuleName Name { get; private set; }

    public ModuleSummary Summary { get; private set; }

    public List<Lesson> Lessons { get; private set; }

    public bool IsActive { get; private set; }

    public int Duration => Lessons.Sum(lesson => lesson.Duration);

    public static Module Create
    (
        CourseId courseId,
        ModuleName name,
        ModuleSummary moduleSummary,
        List<Lesson> lessons,
        bool isActive
    )
    {
        return new Module(ModuleId.New(), courseId, name, moduleSummary, lessons, isActive);
    }
}
