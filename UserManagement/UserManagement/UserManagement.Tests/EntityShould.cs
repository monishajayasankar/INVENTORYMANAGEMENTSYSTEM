using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using UserManagement.API;
using UserManagement.API.DTOs;
using UserManagement.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Moq;

namespace UserManagement.Tests
{
    [TestFixture]
    class EntityShould
    {
        [Test]
        public async Task Return_201StatusCode()
        {
            var dto = new LoginRequestDTO()
            { 
                UserName = "admin@test.com",
                Password = "Admin@1234"
            };


            var repo = new Mock<UserManager<AppUser>>();
            var repoObj = repo.Object;

            var controller = new UserController(repo);

            var result = (StatusCodeResult)await controller.SignIn(dto).ConfigureAwait(false);
            Assert.That(result.StatusCode, Is.EqualTo(201));
        }
    }
}
