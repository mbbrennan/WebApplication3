using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoController : ControllerBase
    {
        public string Get()
        {
            return "Hello Mo! Keep working at it!!";
        }
    }
}
