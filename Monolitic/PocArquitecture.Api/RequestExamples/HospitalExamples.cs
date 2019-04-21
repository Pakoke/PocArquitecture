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
                address = "Calle Wallabe, nº 15,Sidney",
                code = "1H",
                name = "Virgen del Rocio",
                phone = "+34666666666"
            };
        }
    }
}
