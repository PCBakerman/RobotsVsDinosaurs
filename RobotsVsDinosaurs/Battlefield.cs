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

        public Battlefield()
        {
            //Constructor
            fleet = new Fleet();
            herd = new Herd();
        }
        public void RunGame()
        {

        }
        public void DisplayWelcome()
        {

        }




        public void Battle()
        {
            while(fleet.robots.Count > 0 && herd.dinosaurs.Count > 0)
            {
                if(isDinosTurn == true)
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
                



        }public void MakeDinoAttack(Dinosaur dinosaur)

            Console.WriteLine($"Dinosaur {dinosaur.type} is ready for battle!");
            ShowOpponents()
            int userChoice = Convert.ToInt32(Console.Readline());
            robot.Attack(herd) 
    }   public void MakeRoboAttack(Robot robot)
        public void ShowOpponents()
    {
        Console.WriteLine("Please pick an opponent to battle:");
        for(int i = 0; i < fleet.robots.Count; i++)
        { Console.WriteLine($"{i} {fleet.robots[i].name}); };




    }
}       public void DisplayWinners()    
