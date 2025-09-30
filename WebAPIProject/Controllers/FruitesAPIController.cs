using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitesAPIController : ControllerBase
    {

        public List<string> fruites = new List<string>()
        {
            "Apple",
            "Banana",
            "Mango",
            "Orange",
            "Pineapple"
        };

        [HttpGet]
        public List<string> GetFruites()
        {
            return fruites;
        }

        [HttpGet("{id}")]
        public string GetFruitesByIndex(int id)
        {
            return fruites.ElementAt(id);
        }
    }
}
