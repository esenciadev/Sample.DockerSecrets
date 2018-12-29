using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HelloSecrets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly MySecrets _secrets;

        public HelloController(IOptions<MySecrets> secretOpts)
        {
            _secrets = secretOpts.Value;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new [] {_secrets.Codeword, _secrets.NestedSecrets.OtherCode };
        }
    }
}