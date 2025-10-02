using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Resgister;

public class RegisterPetUseCase
{
    public ResponseResgisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseResgisteredPetJson
        {
            id = 7,
            Name = request.Name,
        };
    }
}
