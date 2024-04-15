using System;
using RestSharp;
using Newtonsoft.Json;

namespace gointegration
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new RestClientOptions("https://flow.zoho.com/663067151/flow/webhook/incoming?zapikey=1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1&isdebug=false")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://flow.zoho.com/663067151/flow/webhook/incoming?zapikey=1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1&isdebug=false", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("zapikey", "1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1");
            request.AddJsonBody(new
            {
                github_username = "jaypatel125",
                short_greeting = "Hello, Thank you for this opportunity.",
                email = "jay-kishorbhai.patel@mohawkcollege.ca",
                name = "Jay Patel",
                random_number = new
                {
                    number = 111, 
                    reason = "I chose the number 111 because it holds significant symbolism as a manifestation figure."
                },
                is_test = false
            });
            

            RestResponse response = client.Execute(request);
            Console.WriteLine(response.StatusCode);







        }


    }
}