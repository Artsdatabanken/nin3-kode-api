using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Xml.Linq;
using System.Xml.XPath;
using Microsoft.Extensions.DependencyInjection;

namespace NiN3.WebApi.Filters
{
    public class EnumSummarySchemaFilter : ISchemaFilter
    {
        private readonly XDocument _xmlComments;

        // The services object needs to be added as a parameter
        public EnumSummarySchemaFilter(XDocument xmlComments)
        {
            // Add this line of code in the ConfigureServices method of your Program.cs file
            _xmlComments = xmlComments;
        }

        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type.IsEnum)
            {
                var enumType = context.Type;
                var fullEnumName = $"T:{enumType.FullName}";
                string summary = _xmlComments.XPathEvaluate($"string(/doc/members/member[@name='{fullEnumName}']/summary)")
                    .ToString()
                    .Trim();
                if (!string.IsNullOrEmpty(summary))
                {
                    schema.Description = summary + Environment.NewLine + schema.Description;
                }
            }
        }
    }
}
