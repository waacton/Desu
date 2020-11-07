namespace Wacton.Desu.Enums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Taken from Wacton.Tovarisch 1.1.0
    /// </summary>
    public abstract class Enumeration : IEquatable<Enumeration>
    {
        private static readonly Dictionary<string, int> EnumValues = new Dictionary<string, int>();

        public int Value { get; }
        public string DisplayName { get; }

        protected Enumeration(string displayName)
        {
            var enumId = this.GetType().ToString();
            IncrementEnumCounter(enumId);
            this.Value = EnumValues[enumId];
            this.DisplayName = displayName;
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

            var typeMatches = this.GetType().Equals(obj.GetType());
            var valueMatches = this.Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public static T FromValue<T>(int value) where T : Enumeration, new()
        {
            var matchingItem = Parse<T, int>(value, "value", item => item.Value == value);
            return matchingItem;
        }

        public static T FromDisplayName<T>(string displayName) where T : Enumeration, new()
        {
            var matchingItem = Parse<T, string>(displayName, "display name", item => item.DisplayName == displayName);
            return matchingItem;
        }

        private static T Parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration, new()
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);

            if (matchingItem == null)
            {
                var message = string.Format("'{0}' is not a valid {1} in {2}", value, description, typeof(T));
                throw new FormatException(message);
            }

            return matchingItem;
        }

        public bool Equals(Enumeration other)
        {
            return this.GetType().ToString() == other.GetType().ToString() 
                && this.Value.Equals(other.Value);
        }

        public override string ToString() => this.DisplayName;
    }
}