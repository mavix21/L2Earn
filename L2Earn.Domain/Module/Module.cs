
using L2Earn.Domain.Abstractions;
using L2Earn.Domain.Lessons;

namespace L2Earn.Domain.Module
{
    public class Module : Entity
    {
        private Module(
            Guid id,
            ModuleName name,
            int duration,
            List<Lesson> lessons,
            bool isActive
        ) : base(id)
        {
            Name = name;
            Duration = duration;
            Lessons = lessons;
            IsActive = isActive;
        }
        public ModuleName Name { get; private set; }
        public int Duration { get; private set; }
        public List<Lesson> Lessons { get; private set; }
        public bool IsActive { get; private set; }

        public static Module Create
        (
            ModuleName name,
            int duration,
            List<Lesson> lessons,
            bool isActive
        )
        {
            return new Module(Guid.NewGuid(), name, duration, lessons, isActive);
        }
    }
}
