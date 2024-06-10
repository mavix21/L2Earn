namespace L2Earn.Domain.Courses;

public sealed class Course
{
    public CourseId Id { get; private set; }
    public Title Title { get; private set; }
    public Headline Headline { get; private set; }
    public ImageUrl ImageUrl { get; private set; }
    public string Description { get; private set; }
    public bool IsPublished { get; private set; }
    public bool IsPaid { get; private set; }
    public DateTime CreatedOn { get; private set; }
}
