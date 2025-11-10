using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    internal class User
    {
        //Private Fields
        private int userId;
        private string username;
        private string password;
        private string contactinfo;
        private bool isLoggedIn;

        //Public properties
        public int UserId {
            get { return userId; }
            set { userId = value; }
        }
        public string Username {
            get { return username; }
            set { username = value; }
        }
        public string Password {
            get { return password; }
            set { password = value; }
        }
        public string Contactinfo {
            get { return contactinfo; }
            set { contactinfo = value; }
        }
        public bool IsLoggedIn {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        public bool Login(string userName, string password)
        {
            if (userName == userName && Password == password)
            {
                isLoggedIn = true;
                Console.WriteLine("Login Successful!");
            }
            else {
                IsLoggedIn = false;
                Console.WriteLine($"Login failed. Username {username} or password is incorrect");
            }
            return isLoggedIn;
        }
        public void Logout()
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine("User is logged in successfully!");
            }
            else
            {
                Console.WriteLine("User is not logged in!");
            }
        }
        public void ControlDevice(int deviceId, string deviceName, string deviceAction)
        {
            if (!IsLoggedIn)
            {
                Console.WriteLine($"Performing Action {deviceAction} on {deviceName}");
                // Add logic to control smart device
            }
            else
            {
                Console.WriteLine("Please log in to control device!");
            }
        }

        public User(int userId, string username, string password, string contactinfo, bool isLoggedIn)
        {
            this.UserId = userId;
            this.Username = username;
            this.Password = password;
            this.Contactinfo = contactinfo;
            this.IsLoggedIn = isLoggedIn;
            this.UserId = userId;
            this.Username = username;
            this.Password = password;
            this.Contactinfo = contactinfo;
            this.IsLoggedIn = false;
        }
    }
}
