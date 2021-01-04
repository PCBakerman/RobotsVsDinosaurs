using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Weapon

    {   //MemberVariables 
        public string type;
        public int attackPower;

        //Constructor
        public Weapon(string type)
        {
            this.type = type;
            Random random = new Random();
            attackPower = random.Next(1, 10);

        }
        public int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string GetUserInput(string output)
        {
            Console.WriteLine(output);
            return Console.ReadLine();
        }
    }
}
