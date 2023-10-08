using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace MyEcoApp_MauiApp.Services.Users
{
    public class RegisterService
    {
        public async Task RegisterNewMember(string Username, string Email, string FirstName, string LastName)
        {
            var username = Username;
            var email = Email;
            var firstName = FirstName;
            var lastName = LastName;
            var agreedToTerms = true;
            var agreedToNewsletter = true;

            var ApiUrlPostLocal = "http://localhost:4000/users/register";
            var ApiUrlPost = "https://myecoapp-deploy.vercel.app/users/register";

            using var httpClient = new HttpClient();

            var requestBody = new
            {
                username,
                email,
                firstName,
                lastName,
                agreedToTerms,
                agreedToNewsletter,
            };

            try
            {
                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(ApiUrlPostLocal, content);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                Debug.WriteLine(responseBody);
                Console.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
