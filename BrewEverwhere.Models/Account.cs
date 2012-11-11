using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BrewEverywhere.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string Password { get; set; }
        public byte[] Version { get; set; }
    }
}
