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
        public void RunGame()
        {

        }
        //Member Method
        public void DisplayWelcome()
        {

        }
        //Member Method
        public void Battle()
        {
            while (fleet.robotFleet.Count > 0 && herd.dinosaurHerd.Count > 0)
            {
                if (isDinosTurn == true)
                {
                    MakeDinoAttack();
                    isDinosTurn = false;
                }
                else
                {
                    MakeRoboAttack();
                    isDinosTurns = true;
                }
            }
        }
        //Member Method
        //Dino attacks Robot 
        public void MakeDinoAttack(Dinosaur dinosaur)
        { 
            Console.WriteLine($"Dinosaur {dinosaur.type} is ready to stomp!");
            
            ShowOpponents()
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Robot.Attack(dinosaur)
        }
        //Member Method
        //Robot attacks Dinosaur
        public void MakeRoboAttack(Robot robot)
        {

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
        }
    }
}

           
        

               
        
    
