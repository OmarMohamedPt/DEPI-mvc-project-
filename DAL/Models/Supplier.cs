using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class Supplier
    {
        public int id { get; set; }
        public string name { get; set; } // company
        public int contact_name { get; set; } // person
        public string email { get; set; }
        public string phone { get; set; }
    }
}
