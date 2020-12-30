using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //Member Variables
        public string name;
        public int health;
        public int powerLvl;
        public Weapon weapon;

        
        public Robot(string name, weapon) 
        {  
         //Constructor
            this.name = name;
            health = 125;
            powerLvl = 25;
            weapon = new Weapon();
            
        }
        
        public void Attack(Dinosaur dino) 
        {
            dino.health -= weapon.attackPower;
        }










    }
}
