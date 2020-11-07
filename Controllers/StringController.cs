using Microsoft.AspNetCore.Mvc;

namespace ex2.Controllers
{
    [ApiController]
    [Route("api/strings")]
    public class StringController
    {
        private readonly StringService _stringService;
        public StringController(StringService stringService)
        {
            _stringService = stringService;
        }

        [HttpGet()]
        public IActionResult getAllString()
        {
            var result = new JsonResult(_stringService.getAll());
            return result;
        }   
        
        [HttpGet("{id}")]
        public IActionResult getStringByIndex(int id)
        {
            var result = new JsonResult(null);

            var element = _stringService.getStringByIndex(id);

            if (element == null)
            {
                result.StatusCode = 404;
                return result;
            }

            result.Value = element;
            return result;
        }  
        
        [HttpGet("add/{name}")]
        public IActionResult AddString(string name)
        {
            _stringService.AddString(name);
            var result = new JsonResult(name);
            result.StatusCode = 201;
            return result;
        } 
       
    }
}