using RestSharp;
using System.IO;

namespace GoIntegrationsTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Specify the URL to send the POST request.
            string url = "https://flow.zoho.com/663067151/flow/webhook/incoming?zapikey=1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1&isdebug=false\r\n";

            // Create RestClient instance.
            var client = new RestClient("https://flow.zoho.com/663067151/flow/webhook/incoming?zapikey=1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1&isdebug=false\r\n");

            // Relative path to the JSON file.
            string jsonPayload = @"
            {
                    ""github_username"": ""JrobMo"",
                    ""short_greeting"": ""Salutations & Thanks for the opportunity!"",
                    ""email"": ""createwithjr@outlook.com"",
                    ""name"" : ""Jacob Robbins"",
                    ""random_number"": {
                    ""number"": 33.23,
                    ""reason"": ""I've come up with a 32.33~... repeating of course, percentage... chance of survival.""
                    },
                    ""is_test"": true
            }";

            // Add JSON file content as request body.
            var request = new RestRequest(url, Method.Post)
            .AddJsonBody(jsonPayload, forceSerialize: true);

            // Execute the request and capture the response.
            RestResponse response = client.Execute(request);

            //Graceful Error handling for Test case.
            if (response.IsSuccessful)
            {
                Console.WriteLine("Request was successful.");

                // Output the response content.
                Console.WriteLine("Response content:");
                Console.WriteLine(response.Content);
            }
            else
            {
                //Output response Status and Error code upon failure (graceful error handling).
                Console.WriteLine("Request failed with status code: " + response.StatusCode);
                Console.WriteLine("Error message: " + response.ErrorMessage);
            }
            Console.ReadLine();
        }
    }
}
         