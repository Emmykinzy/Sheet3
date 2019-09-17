using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string MobilePN { get; set; }
        public string HomePN { get; set; }
        public string BusinessPN { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set;}


    }
}
