using MyEcoApp_MauiApp.Model.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoApp_MauiApp.Services.Users
{
    public class LoginService
    {
        public async Task LoginUser(string Username, string Password)
        {
            var email = Username;
            var password = Password;

            var ApiUrlPostLocal = "http://localhost:4000/login";
            var ApiUrlPost = "https://myecoapp-deploy.vercel.app/login";

            using var httpClient = new HttpClient();

            var requestBody = new
            {
                email,
                password,
            };

            Debug.WriteLine($"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX {requestBody}");

            try
            {
                Debug.WriteLine("AAAAAAAAAAAAAAAAAAAA");
                Debug.WriteLine("AAAAAAAAAAAAAAAAAAAA");
                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(ApiUrlPostLocal, content);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                Debug.WriteLine($"TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT {responseBody}");
                Console.WriteLine(responseBody);

                // Parse the JSON response and extract the user data
                var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseBody);

                var userData = jsonResponse.data.existingUser;
                Debug.WriteLine($"UUUUUUUUUUUUUUUUUUUU {userData}");

                // Deserialize JSON data into User object
                User user = JsonConvert.DeserializeObject<User>(userData);
                Console.WriteLine($"User ID: {user}");
                Debug.WriteLine($"User ID: {user}");

                // Access user properties
                Console.WriteLine($"User ID: {user.Id}");
                Console.WriteLine($"User Email: {user.Email}");
                Debug.WriteLine($"User Role: {user.Role}");

                // Access profile properties
                Console.WriteLine($"Profile ID: {user.Profile.Id}");
                Debug.WriteLine($"Profile Username: {user.Profile.Username}");
                Console.WriteLine($"Profile Country: {user.Profile.Country}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error TOMMMMMMMMM: {ex.Message}");
            }
        }
    }
}
