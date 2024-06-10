using L2Earn.Domain.Abstractions;
using L2Earn.Domain.Lessons;
namespace L2Earn.Domain.Lessons
{
    public sealed class Lesson : Entity
    {
        private Lesson(
            Guid id,
            Guid moduleId,
            LessonName name,
            int order,
            LessonDetail detail,
            int duration,
            bool isPaid,
            LessonVideoUrl videoUrl

        ) : base(id)
        {
            ModuleId = moduleId;
            Name = name;
            Order = order;
            Detail = detail;
            Duration = duration;
            IsPaid = isPaid;
            VideoUrl = videoUrl;
        }
        public Guid ModuleId { get; private set; }
        public LessonName Name { get; private set; }
        public int Order { get; private set; }
        public LessonDetail Detail { get; private set; }
        public int Duration { get; private set; }
        public bool IsPaid { get; private set; }
        public LessonVideoUrl VideoUrl { get; private set; }

        public static Lesson Create(
            Guid moduleId,
            LessonName name,
            int order,
            LessonDetail detail,
            int duration,
            bool isPaid,
            LessonVideoUrl videoUrl
        )
        {
            return new Lesson(Guid.NewGuid(), moduleId, name, order, detail, duration, isPaid, videoUrl);
        }

    }
}

