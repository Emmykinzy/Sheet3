using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public static class DB
    {
        public static int LastId = 0;

        public static List<Contact> contactList = new List<Contact>();
    }
}
