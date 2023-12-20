using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers
{
    //show all available movies
    //crud movies

    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {

        public CatalogController()
        {
        }

        [HttpGet]
        public int Get()
        {
            return -1;
        }
    }
}