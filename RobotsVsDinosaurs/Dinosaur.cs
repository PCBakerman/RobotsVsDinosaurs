using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        //Member Variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //Constructor
        public Dinosaur(string type)
        {
            this.type = type;
            health = 120;
            energy = 96;
            attackPower = 10;
        }
        public void Attack(Robot robotBattle)
        {
            robotBattle.health -= attackPower;
        }
    }
}
