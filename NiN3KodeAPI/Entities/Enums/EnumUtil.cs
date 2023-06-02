using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace NiN3KodeAPI.Entities.Enums
{
    public static class EnumUtil
    {
        public static T ParseEnum<T>(string value)
        {
            //todo-sat: Add logger to this class and logg the error-event to logfile.
            return (T)Enum.Parse(typeof(T), value, true);
        }


        public static string ToDescription(this Enum value)
        {
            try { 
                var da = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
                return da.Length > 0 ? da[0].Description : value.ToString();
            }catch (Exception ex)
            {
                //todo-sat: Add logger to this class and logg the error-event to logfile.
                return null;
            }
        }
        
    }
}
