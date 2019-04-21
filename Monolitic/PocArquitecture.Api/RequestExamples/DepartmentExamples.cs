using PocArquitecture.Api.Model;
using Swashbuckle.AspNetCore.Filters;

namespace PocArquitecture.Api.RequestExamples
{
    public class CreateDepartmentModelExample : IExamplesProvider<CreateDepartmentModel>
    {
        public CreateDepartmentModel GetExamples()
        {
            return new CreateDepartmentModel()
            {
                hospitalcode = "1H",
                code = "1P",
                name = "Pediatria",
                typeofdeparment = "Type1"
            };
        }
    }
}
