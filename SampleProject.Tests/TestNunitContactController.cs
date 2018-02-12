using System;
using SampleApp.Models;
using SampleApp.Controllers;
using System.Web.Http.Results;
using System.Net;
using NUnit.Framework;

namespace SampleApp.Tests
{
    public class TestNunitContactController
    {
        [Test]
        public void PostContact_ShouldReturnSameContact()
        {
            var controller = new ContactController(new SampleAppContext());

            var item = GetDemoContact();

            var result =
                controller.PostContact(item) as CreatedAtRouteNegotiatedContentResult<Contact>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteName, "DefaultApi");
            Assert.AreEqual(result.RouteValues["id"], result.Content.Id);
            Assert.AreEqual(result.Content.FirstName, item.FirstName);
            Assert.AreEqual(result.Content.LastName, item.LastName);
        }

        [Test]
        public void PutContact_ShouldReturnStatusCode()
        {
            var controller = new ContactController(new TestSampleAppContext());

            var item = GetDemoContact();

            var result = controller.PutContact(item.Id, item) as StatusCodeResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOf(typeof(StatusCodeResult), result);
            Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
        }

        [Test]
        public void PutContact_ShouldFail_WhenDifferentID()
        {
            var controller = new ContactController(new TestSampleAppContext());

            var badresult = controller.PutContact(999, GetDemoContact());
            Assert.IsInstanceOf(typeof(BadRequestResult), badresult);
        }

        [Test]
        public void GetContact_ShouldReturnContactWithSameID()
        {
            var context = new TestSampleAppContext();
            context.Contacts.Add(GetDemoContact());

            var controller = new ContactController(context);
            var result = controller.GetContact(3) as OkNegotiatedContentResult<Contact>;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Content.Id);
        }

        [Test]
        public void GetContact_ShouldReturnNotFound()
        {
            var context = new TestSampleAppContext();
            context.Contacts.Add(GetDemoContact());

            var controller = new ContactController(context);
            var result = controller.GetContact(10);

            Assert.IsNotNull(result);
            Assert.IsInstanceOf(typeof(NotFoundResult), result);
        }

        [Test]
        public void GetContacts_ShouldReturnAllContacts()
        {
            var context = new TestSampleAppContext();
            context.Contacts.Add(new Contact { Id = 1, FirstName = "Demo1", LastName = "Demo1", Email = "demo1@test.com", Mobile = "+972599142563", Age = 30 });
            context.Contacts.Add(new Contact { Id = 2, FirstName = "Demo2", LastName = "Demo2", Email = "demo2@test.com", Mobile = "+972599142564", Age = 30 });
            context.Contacts.Add(new Contact { Id = 3, FirstName = "Demo3", LastName = "Demo3", Email = "demo3@test.com", Mobile = "+972599142565", Age = 30 });

            var controller = new ContactController(context);
            var result = controller.GetContacts() as TestContactDbSet;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Local.Count);
        }

        [Test]
        public void DeleteContact_ShouldReturnOK()
        {
            var context = new TestSampleAppContext();
            var item = GetDemoContact();
            context.Contacts.Add(item);

            var controller = new ContactController(context);
            var result = controller.DeleteContact(3) as OkNegotiatedContentResult<Contact>;

            Assert.IsNotNull(result);
            Assert.AreEqual(item.Id, result.Content.Id);
        }

        [Test]
        public void DeleteContact_ShouldReturnNotFound()
        {
            var context = new TestSampleAppContext();
            var item = GetDemoContact();
            context.Contacts.Add(item);

            var controller = new ContactController(context);
            var result = controller.DeleteContact(10);

            Assert.IsNotNull(result);
            Assert.IsInstanceOf(typeof(NotFoundResult), result);
        }

        Contact GetDemoContact()
        {
            return new Contact() { Id = 3, FirstName = "Ahmad", LastName = "Shawar", Email = "ahmad.shawar@gmail.com", Mobile = "+972568305766", Age = 28 };
        }
    }
}
