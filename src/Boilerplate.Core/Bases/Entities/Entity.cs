using System;

namespace Boilerplate.Core.Bases.Entities
{
    public abstract class Entity : Validator
    {
        public Guid Id {get; protected set;}
    }
}