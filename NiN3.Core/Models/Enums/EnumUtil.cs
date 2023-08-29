/// <summary>
/// Provides utility methods for working with Enums.
/// </summary>
/// <returns>
/// The parsed enum value or the description of the enum value.
/// </returns>

using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace NiN3.Core.Models.Enums
{
    public static class EnumUtil
    {
        public static T ParseEnum<T>(string value)
        {
            //todo-sat: Add logger to this class and logg the error-event to logfile.
            try
            {
                return (T)Enum.Parse(typeof(T), value, true);
            }
            catch (Exception ex)
            {
                //todo-sat: Add logger to this class and logg the error-event to logfile.
                return default(T);
            }
        }

        public static string ToDescription(this Enum value)
        {
            if (value!=null) { 
            try
            {
                var da = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
                return da.Length > 0 ? da[0].Description : value.ToString();
            }
            catch (Exception ex)
            {
                //todo-sat: Add logger to this class and logg the error-event to logfile.
                return null;
            }
            }
            else
            {
                return null;
            }
        }

        public static string ToDescriptionBlankIfNull(this Enum value)
        {
            try
            {
                var da = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
                return da.Length > 0 ? da[0].Description : value.ToString();
            }
            catch (Exception ex)
            {
                //todo-sat: Add logger to this class and logg the error-event to logfile.
                return "";
            }
        }
    }
}

