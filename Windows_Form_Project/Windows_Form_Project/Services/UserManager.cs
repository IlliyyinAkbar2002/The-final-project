using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows_Form_Project.Models;  // Make sure your User and Role classes are in Models

namespace Windows_Form_Project.Services
{
    public class UserManager
    {
        private static UserManager? _instance;
        private static readonly object _lock = new();

        private List<User> users;
        private string usersFilePath;

        // 🔒 Private constructor (Singleton)
        private UserManager(string? filePath = null)
        {
            usersFilePath = filePath ?? "users.json";
            if (File.Exists(usersFilePath))
            {
                string json = File.ReadAllText(usersFilePath);
                users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }
        }

        // ✅ Singleton Accessor
        public static UserManager GetInstance(string? filePath = null)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UserManager(filePath);
                    }
                }
            }
            return _instance;
        }

        // === Public Methods ===

        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                throw new InvalidOperationException("Username and password cannot be empty.");

            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
                throw new InvalidOperationException("Invalid username or password.");

            return user;
        }

        public void Register(string username, string password, Role role, string nama, string nik, string rt, string rw)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                throw new ArgumentException("Username and password cannot be empty.");

            var snapshot = users.ToList(); // prevent collection modified error

            if (snapshot.Any(u => u.Username == username))
                throw new ArgumentException("Username already exists.");

            if (snapshot.Any(u => u.NIK == nik))
                throw new ArgumentException("NIK sudah terpakai.");

            ValidateUserData(nik, rt, rw);

            User newUser = new User(username, password, role, nama, nik, rt, rw);
            users.Add(newUser);
            SaveUsersToFile();
        }


        public User? GetUserByUsername(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }

        public User? GetUserByNIK(string nik)
        {
            return users.FirstOrDefault(u => u.NIK == nik);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public void SaveChanges()
        {
            SaveUsersToFile();
        }

        // === Private Helper Methods ===

        private void SaveUsersToFile()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(usersFilePath, json);
        }

        private void ValidateUserData(string nik, string rt, string rw)
        {
            if (nik.Length != 16 || !nik.All(char.IsDigit))
                throw new ArgumentException("NIK harus 16 digit angka.");

            if (rt.Length != 2 || !rt.All(char.IsDigit))
                throw new ArgumentException("RT harus 2 digit angka.");

            if (rw.Length != 2 || !rw.All(char.IsDigit))
                throw new ArgumentException("RW harus 2 digit angka.");
        }
    }
}
