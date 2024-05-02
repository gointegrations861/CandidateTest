using System;

namespace CandidateTest
{
    public class Post
    {
        public string github_username { get; set; }
        public string short_greeting { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public RandomNumber random_number { get; set; }
        public bool is_test { get; set; }

        public Post()
        {
            github_username = "";
            short_greeting = "";
            email = "";
            name = "";
            random_number = new RandomNumber();
            is_test = false;
        }
    }

    public class RandomNumber
    {
        public int number { get; set; }
        public string reason { get; set; }

        public RandomNumber()
        {
            number = 0;
            reason = "";
        }
    }
}
