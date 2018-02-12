using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Models
{
    public interface ISampleAppContext : IDisposable
    {
        DbSet<Contact> Contacts { get; }
        int SaveChanges();
        void MarkAsModified(Contact item);
    }
}
