using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoApp_MauiApp.Model.User
{
    public class User
    {
        public string ID { get; set; }  
        public string Email { get; set; }  
        public string Role { get; set; } 
        
        public Profile Profile = new Profile();

        public User(string id, string email, string role, string username)
        {
            ID = id;
            Email = email;
            Role = role;
            Profile.Username = username;
        }
    }

    public class Profile
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public List<object> Hobbies { get; set; }
        public List<object> Pets { get; set; }
        public List<object> Organisations { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string ProfileImage { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
