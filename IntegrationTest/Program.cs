using System;
using RestSharp;
using System.Text.Json;

namespace IntegrationTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the URL and create a RestClient instance
            var url = "https://flow.zoho.com/663067151/flow/webhook/incoming?zapikey=1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1&isdebug=false";
            var client = new RestClient(url);

            // Create a new RestRequest with method POST
            var request = new RestRequest(Method.Post);

            // Add header for content type
            request.AddHeader("Content-Type", "application/json");

            // Create the JSON payload
            var payload = new
            {
                github_username = "rebaccamin5",
                short_greeting = "Thank you for giving me this chance to test my ability",
                email = "minrebacca@gmail.com",
                name = "Rebacca Min",
                random_number = new
                {
                    number = new Random().Next(10, 1000), // Ensure this meets the test's requirement each time
                    reason = "The random number is generated for testing purposes"
                },
                is_test = true
            };

            // Serialize the payload to JSON
            string jsonPayload = JsonSerializer.Serialize(payload);

            // Add JSON body to the request
            request.AddJsonBody(jsonPayload);

            try
            {
                // Execute the request and get the response
                var response = client.Execute(request);

                // Print response details for debugging
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Headers: ");
                foreach (var header in response.Headers)
                {
                    Console.WriteLine($"{header.Name}: {header.Value}");
                }
                Console.WriteLine("Response Content: " + response.Content);

                // Check if the response is successful
                if (!response.IsSuccessful)
                {
                    Console.WriteLine("Error occurred: " + response.ErrorMessage);
                    Console.WriteLine("Status code: " + response.StatusCode);
                    Console.WriteLine("Content: " + response.Content);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}