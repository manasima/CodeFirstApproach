using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mis.contracts;
//using mis.Models;

namespace mis.Controllers
{
    [Route("api/Member")]
    public class MemberController : ControllerBase
    {
        private readonly ILoggerManager loggerManager;
        private readonly IRepositoryWrapper repositoryWrapper;
        public MemberController(
            ILoggerManager loggerManager,
            IRepositoryWrapper repositoryWrapper)
        {
            this.loggerManager = loggerManager;
            this.repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IActionResult GetAllMembers()
        {
            try
            {
                var members = repositoryWrapper.Member.GetAllMembers();
                loggerManager.LogInfo($"Returned all members from database");

                return Ok(members);
            }
            catch (Exception ex)
            {
                loggerManager.LogError($"Something went wrong inset GetAllMembers action:{ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        // GET api/member/5
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            return "value" + id;
        }

        // POST api/member
        [HttpPost("")]
        public void Post([FromBody] string value) { }

        // PUT api/member/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/member/5
        [HttpDelete("{id}")]
        public void DeleteById(int id) { }
    }
}