using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSocialMediaPlatform
{
    internal class UserManager : IUserService
    {
        public void AddTweet(User user)
        {
            Console.WriteLine("Added Tweet");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted Tweet");
        }

        public void Retweet()
        {
            Console.WriteLine("Retweet !");
        }

        public void Update()
        {
            Console.WriteLine("Update Tweet");
        }
    }
}
