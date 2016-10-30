using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSwagger.Swagger
{
    public interface IExamplesProvider
    {
        object GetExamples();
    }
}
