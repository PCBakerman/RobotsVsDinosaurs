using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    public static class Assist
    {
        public static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}

