using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSwagger.Swagger
{
    public class SwaggerResponseExamplesAttribute : Attribute
    {
        public SwaggerResponseExamplesAttribute(Type responseType, Type examplesType)
        {
            ResponseType = responseType;
            ExamplesType = examplesType;
        }

        public Type ResponseType { get; set; }
        public Type ExamplesType { get; set; }
    }
}