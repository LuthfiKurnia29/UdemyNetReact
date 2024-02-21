using System.Diagnostics;
using domain;
using infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Activity = domain.Activity;

namespace api.Controllers
{
    public class ActivityController : BaseAPIController
    {
        private readonly DataContext _context;
        public ActivityController(DataContext context)
        {
            _context = context;
        }
        [HttpGet] // api/activity
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] // api/activity/29eu
        public async Task<ActionResult<Activity>> GetActivityById([FromRoute] Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}