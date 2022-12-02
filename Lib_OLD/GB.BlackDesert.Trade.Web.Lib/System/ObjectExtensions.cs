// Decompiled with JetBrains decompiler
// Type: System.ObjectExtensions
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace System
{
    public static class ObjectExtensions
    {
        private static readonly HashSet<string> _booleanValues = new HashSet<string>((IEqualityComparer<string>)StringComparer.OrdinalIgnoreCase)
    {
      "true",
      "1",
      "on",
      "yes",
      "y"
    };

        public static T ConvertTo<T>(this object value) => value.ConvertTo<T>(default(T));

        public static T ConvertTo<T>(this object value, T defaultValue) => value.ConvertTo<T>(defaultValue, true);

        public static T ConvertTo<T>(this object value, T defaultValue, bool ignoreException)
        {
            if (!ignoreException)
                return value.Convert<T>(defaultValue);
            try
            {
                return value.Convert<T>(defaultValue);
            }
            catch
            {
                return typeof(T).Equals(typeof(string)) && defaultValue.IsNull<T>() ? (T)(object)string.Empty : defaultValue;
            }
        }

        private static T Convert<T>(this object value, T defaultValue)
        {
            Type type = typeof(T);
            if (value.IsNull())
            {
                if (type.Equals(typeof(string)) && defaultValue.IsNull<T>())
                    return (T)(object)string.Empty;
            }
            else
            {
                if (type.Equals(typeof(bool)))
                    return (T)(object)(ValueType)ObjectExtensions._booleanValues.Contains(value.ToString().ToLower());
                if (type.Equals(typeof(Decimal)))
                {
                    Decimal result;
                    return Decimal.TryParse(value.ToString(), NumberStyles.Any, (IFormatProvider)CultureInfo.InvariantCulture, out result) ? (T)(object)(ValueType)result : default(T);
                }
                if (value.GetType() == type)
                    return (T)value;
                TypeConverter converter1 = TypeDescriptor.GetConverter(value);
                if (converter1.IsNotNull())
                {
                    if (converter1.CanConvertTo(type))
                        return (T)converter1.ConvertTo(value, type);
                    if (converter1.GetType() == typeof(EnumConverter) && type == typeof(int))
                        return (T)value;
                }
                TypeConverter converter2 = TypeDescriptor.GetConverter(type);
                if (converter2.IsNotNull() && converter2.CanConvertFrom(value.GetType()))
                    return (T)converter2.ConvertFrom(value);
            }
            return defaultValue;
        }

        public static bool IsNull(this object target) => target.IsNull<object>();

        public static bool IsNull<T>(this T target) => (object)target == DBNull.Value || (object)target == null;

        public static bool IsNotNull(this object target) => !target.IsNull();

        public static bool IsNullOrEmpty(this string target) => string.IsNullOrEmpty(target);

        public static bool IsNullOrWhiteSpace(this string target) => string.IsNullOrWhiteSpace(target);

        public static bool IsNotNullOrEmpty(this string target) => !string.IsNullOrEmpty(target);

        public static bool IsNotNullOrWhiteSpace(this string target) => !string.IsNullOrWhiteSpace(target);

        public static bool Contains(this string self, string value, StringComparison compare) => !string.IsNullOrEmpty(self) && !string.IsNullOrEmpty(value) && 0 <= self.IndexOf(value, compare);
    }
}
