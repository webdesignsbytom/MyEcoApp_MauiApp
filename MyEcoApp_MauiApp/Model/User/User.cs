using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoApp_MauiApp.Model.User
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime LastLoggedIn { get; set; }
        public bool IsVerified { get; set; }
        public bool AgreedToTerms { get; set; }
        public bool AgreedToNewsletter { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<object> Messages { get; set; }
        public List<object> Notifications { get; set; }
        public Profile Profile { get; set; }
        public object NewsletterMember { get; set; }
    }

    public class Profile
    {
        public string Id { get; set; }
        public string UserId { get; set; }
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
