using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSocialMediaPlatform
{
    internal interface IUserService
    {
        void AddTweet(User user);
        void Retweet();
        void Delete();
        void Update();

    }
}
