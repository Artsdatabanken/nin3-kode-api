using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace NiN3.WebApi.Filters
{
    public class EnumDescriptionSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type.IsEnum)
            {
                schema.Enum.Clear();
                var enumType = context.Type;
                foreach (var name in Enum.GetNames(enumType))
                {
                    var field = enumType.GetField(name);
                    if (field != null)
                    {
                        var attribute = field.GetCustomAttribute<DescriptionAttribute>();
                        //var description = attribute?.Description ?? name;
                        schema.Enum.Add(new OpenApiString($"{name}"));
                    }
                }
            }
        }
    }
}
