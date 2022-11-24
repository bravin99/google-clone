using Microsoft.AspNetCore.Mvc;
using GoogleClone.Shared.Models;

using Microsoft.EntityFrameworkCore;
using GoogleClone.Server.Data.Context;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoogleSearchController : ControllerBase
    {
        private readonly ISearchService _searchService;
        private readonly ApplicationDbContext _context;

        public GoogleSearchController(ISearchService searchService, ApplicationDbContext context)
        {
            _searchService = searchService;
            _context = context;
        }

        [HttpGet("{searchString}")]
        public async Task<ActionResult<IEnumerable<ResultObject>>> GoogleSearch(string searchString)
        {
            try
            {
                var results = await _searchService.GoogleSearch(searchString);
                if (results != null)
                {
                    return Ok(results);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, 
                ex.Message);
            }

        }

        // [HttpPost("addsearchobject")]
        // public async Task<string> AddObject([FromBody]ResultObject request)
        // {
        //     var res = new ResultObject(){
        //         Title = request.Title,
        //         Url = request.Url,
        //         Updated = DateTime.UtcNow,
        //         Type = request.Type
        //     };

        //     await _context.GoogleSets!.AddAsync(res);
        //     await _context.SaveChangesAsync();
        //     return "Success";
        // }

        // [HttpDelete("DeleteResult")]
        // public async Task<string> DeleteResult(int id)
        // {
        //     string msg = string.Empty;
        //     var res = await _context.GoogleSets!.FirstOrDefaultAsync(r => r.Id == id);
        //     if (res != null)
        //     {
        //         _context.GoogleSets!.Remove(res);
        //         await _context.SaveChangesAsync();
        //         msg = $"Deleted successfully: {res.Title}";
        //         return msg;
        //     }
        //     msg = $"Error deleting item with Id: {id}";
        //     return msg;
        // }

    }
}