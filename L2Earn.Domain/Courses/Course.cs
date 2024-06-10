namespace L2Earn.Domain.Courses;

public sealed class Course
{
    public CourseId Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string ImageUrl { get; private set; }
    public string Author { get; private set; }
    public bool IsProgressLimited { get; private set; }
}
