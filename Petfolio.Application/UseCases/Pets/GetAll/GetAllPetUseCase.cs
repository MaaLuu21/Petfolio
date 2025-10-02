using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets = new List<ResponseShortPetJson> 
            { 
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Mel",
                    Type = Communication.Enums.PetType.Dog
                }
            }
        };
    }
}
