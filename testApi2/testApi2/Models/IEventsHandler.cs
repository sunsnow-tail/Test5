using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace testApi2.Models
{
    public interface IEventsHandler
    {
        Task<IEnumerable<Event>> GetAllEvents(string search = null);

        Task<IEnumerable<Event>> GetAllEvents(int pageNumber, int pageSize, string search = null);

        Task<Event> GetEvent(Guid id);

        void UpdateEvent(Event eventData);

        void DeleteEvent(Guid id);
    }
}