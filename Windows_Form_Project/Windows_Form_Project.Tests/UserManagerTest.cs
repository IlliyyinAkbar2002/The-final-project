using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services;
using System.Collections.Generic;

namespace Windows_Form_Project.Tests
{
    [TestClass]
    public class UserManagerTests
    {
        private string testUserFile;
        private UserManager manager;

        [TestInitialize]
        public void Setup()
        {
            testUserFile = $"test_users_{Guid.NewGuid()}.json";
            File.WriteAllText(testUserFile, "[]");

            // Reset singleton
            typeof(UserManager)
                .GetField("_instance", BindingFlags.Static | BindingFlags.NonPublic)!
                .SetValue(null, null);

            // Create instance
            manager = (UserManager)Activator.CreateInstance(
                typeof(UserManager),
                BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                new object[] { testUserFile },
                null
            )!;

            typeof(UserManager)
                .GetField("usersFilePath", BindingFlags.Instance | BindingFlags.NonPublic)!
                .SetValue(manager, testUserFile);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testUserFile)) File.Delete(testUserFile);
        }

        [TestMethod]
        public void Register_ValidData_ShouldAddUser()
        {
            manager.Register("john", "pass123", Role.Masyarakat, "John Doe", "1234567890123456", "01", "02");

            var user = manager.GetUserByUsername("john");
            Assert.IsNotNull(user);
            Assert.AreEqual("John Doe", user.Nama);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Register_DuplicateUsername_ShouldThrow()
        {
            manager.Register("john", "pass123", Role.Masyarakat, "John", "1234567890123456", "01", "02");
            manager.Register("john", "pass456", Role.Masyarakat, "Johnny", "1234567890123457", "03", "04");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Register_DuplicateNIK_ShouldThrow()
        {
            manager.Register("john1", "pass123", Role.Masyarakat, "John", "1234567890123456", "01", "02");
            manager.Register("john2", "pass456", Role.Masyarakat, "Johnny", "1234567890123456", "03", "04");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Register_InvalidNIK_ShouldThrow()
        {
            manager.Register("john", "pass", Role.Masyarakat, "John", "1234", "01", "02");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Register_InvalidRT_ShouldThrow()
        {
            manager.Register("john", "pass", Role.Masyarakat, "John", "1234567890123456", "1", "02");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Register_InvalidRW_ShouldThrow()
        {
            manager.Register("john", "pass", Role.Masyarakat, "John", "1234567890123456", "01", "2");
        }

        [TestMethod]
        public void Authenticate_ValidCredentials_ShouldReturnUser()
        {
            manager.Register("john", "pass123", Role.Admin, "John", "1234567890123456", "01", "02");
            var user = manager.Authenticate("john", "pass123");

            Assert.IsNotNull(user);
            Assert.AreEqual(Role.Admin, user.Role);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Authenticate_InvalidPassword_ShouldThrow()
        {
            manager.Register("john", "pass123", Role.Admin, "John", "1234567890123456", "01", "02");
            manager.Authenticate("john", "wrong");
        }

        [TestMethod]
        public void GetUserByNIK_ShouldReturnCorrectUser()
        {
            manager.Register("john", "pass123", Role.Masyarakat, "John", "1234567890123456", "01", "02");
            var user = manager.GetUserByNIK("1234567890123456");

            Assert.IsNotNull(user);
            Assert.AreEqual("john", user.Username);
        }

        [TestMethod]
        public void GetAllUsers_ShouldReturnAll()
        {
            manager.Register("a", "p", Role.Masyarakat, "A", "1111111111111111", "01", "01");
            manager.Register("b", "p", Role.Lurah, "B", "2222222222222222", "01", "02");

            var all = manager.GetAllUsers();
            Assert.AreEqual(2, all.Count);
        }

        [TestMethod]
        public void SaveChanges_ShouldPersistUsers()
        {
            manager.Register("save", "123", Role.Masyarakat, "Save Test", "9999999999999999", "09", "09");
            manager.SaveChanges();

            string json = File.ReadAllText(testUserFile);
            Assert.IsTrue(json.Contains("\"Username\": \"save\""));
        }
    }
}
