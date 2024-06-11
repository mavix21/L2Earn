
using L2Earn.Domain.Abstractions;
using L2Earn.Domain.Lessons;

namespace L2Earn.Domain.Modules
{
    public class Module : Entity
    {
        private Module(
            Guid id,
            ModuleName name,
            List<Lesson> lessons,
            bool isActive
        ) : base(id)
        {
            Name = name;
            Lessons = lessons;
            IsActive = isActive;
        }
        public ModuleName Name { get; private set; }

        public List<Lesson> Lessons { get; private set; }

        public bool IsActive { get; private set; }

        public int Duration => Lessons.Sum(lesson => lesson.Duration);

        public static Module Create
        (
            ModuleName name,
            List<Lesson> lessons,
            bool isActive
        )
        {
            return new Module(Guid.NewGuid(), name, lessons, isActive);
        }
    }
}
