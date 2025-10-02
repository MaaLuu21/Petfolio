namespace Petfolio.Communication.Responses;

public class ResponseErrorsJson
{
    public List<string> Errors { get; set; } = []; // o [] é a mesma coisa que -> new List<string>()
                                                   // quando intanciado é iniciado vazio, evita null ;
}
