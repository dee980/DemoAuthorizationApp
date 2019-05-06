using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1121
{
    [Table("Users")]
    public class Ur:AuthorizationModule.Domain.Entities.User<int>
    {
        public string Name { get; set; }
        public string UserJa { get; set; }
    }
}
