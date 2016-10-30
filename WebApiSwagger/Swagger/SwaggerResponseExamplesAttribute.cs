using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSwagger.Swagger
{
    public class SwaggerResponseExamplesAttribute : Attribute
    {
        public SwaggerResponseExamplesAttribute(Type responseType, Type examplesProviderType)
        {
            ResponseType = responseType;
            ExamplesProviderType = examplesProviderType;
        }

        public Type ResponseType { get; set; }
        public Type ExamplesProviderType { get; set; }
    }
}