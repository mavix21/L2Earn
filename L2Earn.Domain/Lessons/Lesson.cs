using L2Earn.Domain.Abstractions;
using L2Earn.Domain.Lessons;
namespace L2Earn.Domain.Lessons
{
    public sealed class Lesson : Entity
    {
        private Lesson(
            Guid id,
            LessonName name,
            int order,
            LessonDetail detail,
            int duration,
            bool isPaid,
            LessonVideoUrl videoUrl

        ) : base(id)
        {
            Name = name;
            Order = order;
            Detail = detail;
            Duration = duration;
            IsPaid = isPaid;
            VideoUrl = videoUrl;
        }
        public LessonName Name { get; private set; }
        public int Order { get; private set; }
        public LessonDetail Detail { get; private set; }
        public int Duration { get; private set; }
        public bool IsPaid { get; private set; }
        public LessonVideoUrl VideoUrl { get; private set; }

        public static Lesson Create(
            LessonName name,
            int order,
            LessonDetail detail,
            int duration,
            bool isPaid,
            LessonVideoUrl videoUrl
        )
        {
            return new Lesson(Guid.NewGuid(), name, order, detail, duration, isPaid, videoUrl);
        }

    }
}

