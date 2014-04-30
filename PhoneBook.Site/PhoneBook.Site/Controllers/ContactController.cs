using PhoneBook.Site.Contexts;
using PhoneBook.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhoneBook.Site.Controllers
{
    public class ContactController : ApiController
    {
        // GET api/contact
        public IEnumerable<Contact> Get()
        {
            using (var db = new ContactContext())
            {
                var results = db.Contacts.ToArray();
                return results;
            }
            return new Contact[] { };
        }

        // GET api/contact/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/contact
        public bool Post([FromBody]Contact newContact)
        {
            using (var db = new ContactContext())
            {
                saveNewContact(db.Contacts, newContact);
                return true;
            }
            return false; // TODO: trycatch to this
        }

        private void saveNewContact(System.Data.Entity.DbSet<Contact> dbSet, Contact newContact)
        {
            throw new NotImplementedException();
        }

        // PUT api/contact/5
        public bool Put(int id, [FromBody]Contact updatedContact)
        {
            using (var db = new ContactContext ())
            {
                var target = db.Contacts.Where(c => c.Id == updatedContact.Id).FirstOrDefault();
                if (target != default(Contact))
                {
                    target.Name = updatedContact.Name;
                    target.Number = updatedContact.Number;
                }
                db.SaveChangesAsync();
                return true;
            }
            return false;//TODO : Trycatch to this
        }

        // DELETE api/contact/5
        public bool Delete(int id)
        {
            return true;
        }
    }
}
