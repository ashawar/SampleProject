using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Tests
{
    public class TestSampleAppContext : ISampleAppContext
    {
        public TestSampleAppContext()
        {
            this.Contacts = new TestContactDbSet();
        }

        public DbSet<Contact> Contacts { get; set; }

        public int SaveChanges()
        {
            return 0;
        }

        public void MarkAsModified(Contact item) { }
        public void Dispose() { }
    }
}
