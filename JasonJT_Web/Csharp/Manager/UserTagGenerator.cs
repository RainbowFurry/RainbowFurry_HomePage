using System;

namespace JasonJT_Web.Csharp.Manager
{
    public class UserTagGenerator
    {

        private readonly int[] digets = { 1,2,3,4,5,6,7,8,9,0 };

        public string generateUserTag()
        {

            string userTag = "#";

            Random random = new Random();

            while(userTag.Length < 7)
            {
                userTag += digets[random.Next(9)];
            }

            System.Diagnostics.Debug.WriteLine("UserTag: " + userTag);

            return userTag;
        }

    }
}