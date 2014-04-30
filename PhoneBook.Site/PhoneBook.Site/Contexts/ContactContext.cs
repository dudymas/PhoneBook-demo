using PhoneBook.Site.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneBook.Site.Contexts
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}