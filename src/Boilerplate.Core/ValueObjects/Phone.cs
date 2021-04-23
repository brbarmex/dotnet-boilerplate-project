using System;
using Boilerplate.Core.Bases.Interfaces;
using Boilerplate.Core.Enumerations;

namespace Boilerplate.Core.ValueObjects
{
    public sealed class Phone : IValueObject
    {
        public static implicit operator Phone(string value)
        => new(value);
        private readonly string _value;

        private Phone(string value)
        => _value = value;

        public EPhoneType GetPhoneType()
        {
            if(_value is null)
                throw new ArgumentNullException("Phone object cannot be null.");

            return _value.Length > 10 ? EPhoneType.Celular : EPhoneType.Landline;
        }

        public override string ToString()
        => _value;

        public static string AsFormatted()
        {
            // implement logic to format number ex: 11-2222-2222 etc... avoid Helper
            return default;
        }
    }
}