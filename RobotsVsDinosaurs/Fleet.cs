using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{

    class Fleet
    {  
        //Member Variables
        public List<Robot> robotFleet;
        
        
        //Constructor
        public Fleet()
        {

            robotFleet = new List<Robot>();
            Robot numberOneRobot = new Robot("Glorbtron", "Gum balls");
            Robot numberTwoRobot = new Robot("Lamaritone", "Cheese Wizz");
            Robot numberThreeRobot = new Robot("Brundlrip", "Flies");

            for (int i = 0; i < 3; i++);
            
        }
        

    }
}
