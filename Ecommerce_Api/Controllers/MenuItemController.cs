using Ecommerce_Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Api.Controllers
{
    [Route("api/MenuItem")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        //creating a private field that refernces the db
        private readonly ApplicationDbContext _db;

        public MenuItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetMenuItems()
        {
            return Ok(_db.MenuItems);
        }
    }
}
