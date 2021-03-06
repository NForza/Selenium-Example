﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RequestInfoViewModel
    {
        [Required(ErrorMessage="Your name is required")]
        public string Name { get; set; }
        
        [EmailAddress(ErrorMessage="A valid emailaddress is required")]
        [Required(ErrorMessage = "A valid emailaddress is required")]
        public string EmailAddress { get; set; }
    }
}