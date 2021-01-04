using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //Member Variables
        public Fleet fleet;
        public Herd herd;
        
        //Constructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }
        
        //Member Method
        public void Battle()
        {
            
            while (fleet.robotFleet.Count > 0 && herd.dinosaurHerd.Count > 0)
            {
                if (herd.dinosaurHerd[0].health <= 0) //Dino's at index 0 health reaches 0
                {
                    //Remove Dino from list
                    herd.dinosaurHerd.RemoveAt(0);
                } 
                if (herd.dinosaurHerd[0].health <=0) //Robot at index 0 health reaches 0
                   
                    //Remove Robot from list
                   fleet.robotFleet.RemoveAt(0);
            }
            if (fleet.robotFleet.Count > 0)
            {
                Console.WriteLine("Nature has once again shown it's force!");
            }
            else
            {
                Console.WriteLine("It seems the machine prevails!");
            }

        }

        
        //Dino attacks Robot 
        public void MakeDinoAttack(Dinosaur dinosaur)
        {
           
            Console.WriteLine($"Dinosaur {dinosaur.type} is ready to stomp!");
            herd.dinosaurHerd[0].Attack(fleet.robotFleet[0]);
        }

        
        //Robot attacks Dinosaur
        public void MakeRoboAttack(Robot robot)
        {
            //Gathers Robot name and displays attack message.
            Console.WriteLine($"Robo {robot.name} is ready to terminate!");
            fleet.robotFleet[0].Attack(herd.dinosaurHerd[0]);
        }
        //Member Method
        public void ShowOpponents()
        {
            Console.WriteLine("Please pick an opponent to battle:");

            //Loops through the fleet of Robots, when zero, will add a Robot to the count.
            for (int i = 0; i < fleet.robotFleet.Count; i++)
            {
                Console.WriteLine($"{i} {fleet.robotFleet[i].name}");
            }

            //Loops through the herd of Dinos, when at zero index, adds dino to the count.
            for (int i = 0; i < herd.dinosaurHerd.Count; i++)
                Console.WriteLine($"{i} {herd.dinosaurHerd[i].type}");
        }
        
    }
}

           
        

               
        
    
