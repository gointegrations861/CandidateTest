using System;
using RestSharp;

namespace gointegration
{
    class ApiCall
    {
        private const string BaseUrl = "https://flow.zoho.com/663067151/flow/webhook/incoming";
        private const string ApiKey = "1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1";
        static void Main(string[] args)
        {
            {
                try
                {
                    SendPostRequest();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// This method sends a Post Request to the specified URL with the provided payload.
        /// </summary>
        private static void SendPostRequest()
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("zapikey", ApiKey);

            var payload = new
            {
                github_username = "NevilPatel01",
                short_greeting = "Hello there! Nice to meet you virtually.",
                email = "nevil-dineshkumar.patel@mohawkcollege.ca",
                name = "Nevil Patel",
                random_number = new
                {
                    number = 37,
                    reason = "I choose 37 because I watched a video of Veritasium on Youtube and according to that video, 37 and 73 are the most random number."
                },
                is_test = false
            };

            request.AddJsonBody(payload);

            RestResponse response = client.Execute(request);
            Console.WriteLine(response.StatusCode);
        }
    }
}
