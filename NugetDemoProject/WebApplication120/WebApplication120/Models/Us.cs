using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication120.Models
{
    [Table("users")]
    public class Us
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }
    }
}