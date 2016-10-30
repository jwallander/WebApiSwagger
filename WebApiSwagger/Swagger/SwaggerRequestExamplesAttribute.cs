using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSwagger.Swagger
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class SwaggerRequestExamplesAttribute : Attribute
    {
        public SwaggerRequestExamplesAttribute(Type requestType, Type examplesProviderType)
        {
            RequestType = requestType;
            ExamplesProviderType = examplesProviderType;
        }

        public Type ExamplesProviderType { get; private set; }

        public Type RequestType { get; private set; }
    }
}