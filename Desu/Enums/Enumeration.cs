namespace Wacton.Desu.Enums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    public abstract class Enumeration : IEquatable<Enumeration>
    {
        private static readonly Dictionary<string, int> EnumValues = new Dictionary<string, int>();

        public int Value { get; }
        public string DisplayName { get; }

        protected Enumeration(string displayName)
        {
            var enumId = GetType().ToString();
            IncrementEnumCounter(enumId);
            Value = EnumValues[enumId];
            DisplayName = displayName;
        }

        private static void IncrementEnumCounter(string enumId)
        {
            if (EnumValues.ContainsKey(enumId))
            {
                EnumValues[enumId]++;
            }
            else
            {
                EnumValues.Add(enumId, 0);
            }
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var type = typeof(T);
            var enumerationFields =
                type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                    .Where(field => field.FieldType == type);

            return enumerationFields.Select(f => f.GetValue(null)).Cast<T>();
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;

            if (otherValue == null)
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public bool Equals(Enumeration other)
        {
            return GetType().ToString() == other.GetType().ToString() 
                && Value.Equals(other.Value);
        }

        public override string ToString() => DisplayName;
    }
}