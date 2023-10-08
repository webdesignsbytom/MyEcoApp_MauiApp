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

            try
            {
                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(ApiUrlPostLocal, content);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);

                // Parse the JSON response and extract the user data
                var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseBody);

                var userData = jsonResponse.data.existingUser;
                var tokenData = jsonResponse.data.token;

                Debug.WriteLine($"UUUUUUUUUUUUUUUUUUUU {userData}");

                User loggedInUser = new((string) userData.id, (string) userData.email, (string) userData.role,(string) userData.profile.username);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging in: {ex.Message}");
            }
        }
    }
}
