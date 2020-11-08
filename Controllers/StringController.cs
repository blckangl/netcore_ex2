using ex2.Models;
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
        public IActionResult getStringByIndex([FromRoute]int id)
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
        
        
        // POST api/strings/add
        [HttpPost("add")]
        public IActionResult AddString([FromBody]StringItem item)
        {
         
            _stringService.AddString(item);
            var result = new JsonResult(item);
            result.StatusCode = 201;
            return result;
        }

      
        [HttpPut("{id}")]
        public IActionResult UpdateStringItem(int id,StringItem item)
        {
            
            var newItem = _stringService.UpdateItem(id,item);
            var result = new JsonResult(newItem);
            result.StatusCode = 202;
            return result;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var isDeleted = _stringService.DeleteItem(id);
            var result = new JsonResult(isDeleted);
            result.StatusCode = 202;
            return result;
        }
       
    }
}