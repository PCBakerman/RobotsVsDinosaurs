using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    
    class Herd
    {
        //Member Variables
        public List<Dinosaur> dinosaurHerd;

        //Constructor
        public Herd()
        {
            dinosaurHerd = new List<Dinosaur>();
            Dinosaur oneDino = new Dinosaur("Colossosaurus");
            Dinosaur twoDino = new Dinosaur("Kledadanon");
            Dinosaur threeDino = new Dinosaur("Gnaroucious-Rex"); 
        }
    }
}
