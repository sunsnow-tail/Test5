using testApi2.Models;

namespace testApi2.Validations
{
    public interface IEventValidation
    {
        (bool IsValid, string Error) Validate(Event eventData);
    }
}