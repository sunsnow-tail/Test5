using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testApi2.Data;
using testApi2.Models;
using testApi2.Validations;

namespace testApi2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase, IEventsHandler
    {
        //logging skipped here
        private readonly ILogger<EventsController> _logger;
        private BaseDbContext _dbContext;
        private IEventValidation _eventValidation;

        public EventsController(ILogger<EventsController> logger, BaseDbContext dbContext, IEventValidation eventValidation)
        {
            _logger = logger;
            _dbContext = dbContext;
            _eventValidation = eventValidation;
        }

        
        [HttpGet]
        public async Task<IEnumerable<Event>> GetAllEvents(string search = null)
        {
            var data = await _dbContext.Events
                .Select(p => p).ToListAsync();
            return data;
        }

        //server side paging
        [HttpPost]
        public async Task<IEnumerable<Event>> GetAllEvents(int pageNumber, int pageSize, string search = null)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<Event> GetEvent(Guid id)
        {
            return await _dbContext.Events.FirstOrDefaultAsync(p => p.Id == id);
        }

        [HttpPost]
        public async void UpdateEvent(Event eventData)
        {
            var validationResult = _eventValidation.Validate(eventData);

            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Error);
            }

            _dbContext.Attach(eventData);

            await _dbContext.SaveChangesAsync();
        }

        [HttpPost]
        public void DeleteEvent(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
