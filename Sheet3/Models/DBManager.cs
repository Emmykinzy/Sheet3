using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Entities;

namespace Sheet3.Models
{
    public class DBManager
    {
        BLL.Business bll = new BLL.Business();
        public void Add(Contact c)
        {
           bll.Add(c);
        }

        public List<Contact> GetAll()
        {
            return bll.GetAll();
        }
        public List<Contact> GetAllActive()
        {
            return bll.GetAllActive();
        }

        public void Delete(int id)
        {
            bll.Delete(id);           
        }

        public Contact Details(int id)
        {
            return bll.Details(id);
        }
        public void Update(Contact c)
        {
            bll.Update(c);           
        }
    }
}