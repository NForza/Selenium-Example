using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebApplication1.Models
{
    public class SendInfoViewModel
    {
        [Required(ErrorMessage="Your name is required")]
        public string Name { get; set; }
        
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}