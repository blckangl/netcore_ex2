using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ex2.Controllers
{
    
  
    [ApiController]
    [Route("api/hello")]
    public class HelloController :ControllerBase
    {
      
        List<string> userList=new List<string>(new string[]{"string1","string2","string3"});
        
        [HttpGet("")]
        public IActionResult getString()
        {
            JsonResult res = new JsonResult(userList);
            // res.StatusCode = 200;
            return res;
            
        }
        [HttpGet("{id}")]
        public IActionResult getStringById(int id,int limit)
        {
            if (id > userList.Count)
            {
                JsonResult res2 = new JsonResult("Not Found");
                res2.StatusCode = 404;
                return res2;  
            }
            var elem = userList[id];
            JsonResult res = new JsonResult(elem);
            res.StatusCode = 200;
            return res;
        }
        
    }
}