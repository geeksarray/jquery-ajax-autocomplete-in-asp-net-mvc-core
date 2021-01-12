using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using jquery_autocomplete_aspnet_mvc_core.Areas.Purchasing.Models;

namespace jquery_autocomplete_aspnet_mvc_core.Areas.Purchasing.Controllers
{    
    [Route("api/vendor")]
    [ApiController]
    public class VendorAPIController : ControllerBase
    {
        private VendorContext db = new VendorContext();

        [Produces("application/json")]
        [HttpGet("search")]
        [Route("api/vendor/search")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                
                var names = db.Vendors.Where(p => p.Name.Contains(term)).Select(p => p.Name).ToListAsync();
                return Ok(await names);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
