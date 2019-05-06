using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorizationModule.BAL.IServices;
using AuthorizationModule.BAL.Services;
using AuthorizationModule.Domain.Dtos;
using Kendo.DynamicLinqCore2;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1121.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public ValuesController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            var a = await _roleService.GetAllRoles(new DataSourceRequest { });
            var k = (List<RoleDto>)a.Data;
            return k.Select(e => e.Name).ToList();
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
