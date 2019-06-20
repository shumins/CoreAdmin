using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.FrameWork.IRepository;
using Blog.Core.FrameWork.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoreAdmin.Controllers
{
    /// <summary>
    ///Values控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private  readonly IUserRepository _userRepository;
        public ValuesController(IUserRepository userRepository) {
            this._userRepository = userRepository;
        }

        /// <summary>
        /// GET请求
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()

        {
            var a=_userRepository.Query();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
