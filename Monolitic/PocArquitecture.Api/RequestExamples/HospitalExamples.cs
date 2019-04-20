using PocArquitecture.Api.Model;
using Swashbuckle.AspNetCore.Filters;

namespace PocArquitecture.Api.RequestExamples
{
    public class CreateHospitalModelExample : IExamplesProvider<CreateHospitalModel>
    {
        public CreateHospitalModel GetExamples()
        {
            return new CreateHospitalModel()
            {
                Address = "Calle Wallabe, nº 15,Sidney",
                Code = "1H",
                Name = "Virgen del Rocio",
                Phone = "+34666666666"
            };
        }
    }
}
