using System;
using System.Diagnostics.CodeAnalysis;

namespace IlCats_Domain.Entity
{
    public class Entity : IEntity, IEquatable<IEntity>
    {
        public int Id { get; set; }

        public bool Equals(IEntity? other)
        {
            return other != null && Id == other.Id && GetType() == other.GetType();
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as IEntity);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
