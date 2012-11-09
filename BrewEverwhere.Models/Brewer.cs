using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrewEverywhere.Models
{
    public class Brewer
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public String Name { get; set; }
        public string Email { get; set; }
    }
}
