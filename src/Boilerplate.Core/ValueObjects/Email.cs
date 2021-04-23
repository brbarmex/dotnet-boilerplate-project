using System.Text.RegularExpressions;
using Boilerplate.Core.Bases.Interfaces;

namespace Boilerplate.Core.ValueObjects
{
    public sealed class Email : IValueObject
    {
        protected Email(){}

        public static implicit operator Email(string value)
        => new(value);
        private Email(string value)
        => _value = value;
        private readonly string _value;

        public string Value {get {return _value;}}

        public override string ToString()
        => _value;

        public bool IsValid()
        => Regex
           .IsMatch(
               !string.IsNullOrWhiteSpace(_value) ? _value : string.Empty,
               @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
               RegexOptions.IgnoreCase
            );
    }
}