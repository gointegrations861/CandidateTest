﻿using System;
using RestSharp;

namespace CandidateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 1001);
            Console.WriteLine(randomNumber);

            string url = "https://flow.zoho.com/663067151/flow/webhook/incoming?zapikey=1001.72d0b18a4316a1acc8f0de7fa7dbdf74.4f792bf21ebf81a4d04112d94177a2a1&isdebug=false";
            var client = new RestClient(url);
            var request = new RestRequest();

            var body = new Post
            {
                github_username = "Hoanghuyen2k3",
                short_greeting = "Thank you for the opportunity and I am looking forward to discussing more",
                email = "khanhhuyenx20@gmail.com",
                name = "Thi Huyen Hoang",
                random_number = new RandomNumber
                {
                    number = randomNumber,
                    reason = "This is a random number generated by the Random function."
                },
                is_test = false
            };

            request.AddJsonBody(body);
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(body));

            var response = client.Post(request);
            if (response != null)
            {
                Console.WriteLine(response.StatusCode.ToString() + "      " + response.Content.ToString());
            }
            else
            {
                Console.WriteLine("The response object is null.");
            }

            Console.Read();
        }
    }
}
