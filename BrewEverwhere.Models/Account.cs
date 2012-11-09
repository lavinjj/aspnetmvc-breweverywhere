using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrewEverywhere.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public byte[] Version { get; set; }
    }
}
