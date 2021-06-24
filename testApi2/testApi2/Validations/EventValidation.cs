using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testApi2.Models;

namespace testApi2.Validations
{
    public class EventValidation : IEventValidation
    {
        public (bool IsValid, string Error) Validate(Event eventData)
        {
            throw new NotImplementedException();
        }
    }
}
