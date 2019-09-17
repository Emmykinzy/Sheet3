using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{

    public class Business
    {
        public void Add(Contact c)
        {
            c.Id = DB.LastId++;
            c.Active = true;

            DB.contactList.Add(c);

        }

        public List<Contact> GetAll()
        {
            return DB.contactList;
        }
        public List<Contact> GetAllActive()
        {
            List<Contact> cl = DB.contactList;
            List<Contact> activeList = new List<Contact>();
            foreach (Contact c in cl)
            {
                if(c.Active == true)
                {
                    activeList.Add(c);
                }
            }
            return activeList;
        }

        public void Delete(int id)
        {

            DB.contactList.Where(x => x.Id == id).Single().Active = false;

        }

        public Contact Details(int id)
        {
            return DB.contactList.Where(x => x.Id == id).Single();
        }
        public void Update(Contact c)
        {

            var tempRec = DB.contactList.Where(x => x.Id == c.Id).Single();

            tempRec.Id = c.Id;
            tempRec.Fname = c.Fname;
            tempRec.Lname = c.Lname;
            tempRec.MobilePN = c.MobilePN;
            tempRec.HomePN = c.HomePN;
            tempRec.BusinessPN = c.BusinessPN;
            tempRec.Address = c.Address;
            tempRec.Notes = c.Notes;

        }
    }
}
