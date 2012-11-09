using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrewEverywhere.Models.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
    }
}
