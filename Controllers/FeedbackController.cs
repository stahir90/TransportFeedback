using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransportFeedback.Data;
using TransportFeedback.Models;

namespace TransportFeedback.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FeedbackController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Public endpoint to submit feedback
        [HttpPost]
        [Route("submit")]
        public async Task<ActionResult<Feedback>> SubmitFeedback(Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFeedback), new { id = feedback.Id }, feedback);
        }

        // Admin endpoint to view a specific feedback by ID
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Feedback>> GetFeedback(int id)
        {
            var feedback = await _context.Feedbacks.FindAsync(id);

            if (feedback == null)
            {
                return NotFound();
            }

            return feedback;
        }

        // Admin endpoint to view all feedback
        [Authorize]
        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<IEnumerable<Feedback>>> GetAllFeedbacks()
        {
            return await _context.Feedbacks.ToListAsync();
        }

        // Admin endpoint to mark feedback as resolved
        [Authorize]
        [HttpPut("{id}/resolve")]
        public async Task<IActionResult> ResolveFeedback(int id)
        {
            var feedback = await _context.Feedbacks.FindAsync(id);
            if (feedback == null)
            {
                return NotFound();
            }

            feedback.IsResolved = true;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Admin endpoint to delete feedback
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedback(int id)
        {
            var feedback = await _context.Feedbacks.FindAsync(id);
            if (feedback == null)
            {
                return NotFound();
            }

            _context.Feedbacks.Remove(feedback);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
