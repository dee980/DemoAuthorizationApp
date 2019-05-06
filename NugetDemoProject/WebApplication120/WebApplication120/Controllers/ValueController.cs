using Authorization_Module_BAL.Services;
using Authorization_Module_Domain.Dtos.RoleDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication120.Controllers
{
    public class ValueController : ApiController
    {

        public readonly RoleService _roleservice;
        public ValueController(RoleService roleService)
        {
            _roleservice = roleService;
        }
       
      
        public async Task<List<string>> GetValue()
        {
          var a=await _roleservice.GetAllRoles(new Kendo.DynamicLinq.DataSourceRequest { });
            var k = (List<RoleDto>)a.Data;
           return k.Select(e => e.Name).ToList();
        }
    }
}
