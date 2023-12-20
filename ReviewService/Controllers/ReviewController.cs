using Microsoft.AspNetCore.Mvc;

namespace ReviewService.Controllers
{
    //get all reviews
    // get review by ID
    // if review is not found ,return "Review not found!!"
    // get a db service


    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {

        public ReviewController()
        {
           
        }

        [HttpGet]
        public int Get()
        {
            return -1;
        }

        [HttpGet("{id}")]
        public int Get(int id)
        {
            return -1;
        }
    }
}