
using System;

namespace model.Common
{
    public interface IEntity<Tid>
    {
        Tid Id { get; }

        void SetId(Tid id);
    }

    public abstract class Entity : IEntity<Guid>
    {
        protected Entity() => Id = InitializeId();

        public Guid Id { get; private set; }

        public void SetId(Guid id)
        {
            Id = id;
        }

        Guid InitializeId() => Guid.NewGuid();
    }
}