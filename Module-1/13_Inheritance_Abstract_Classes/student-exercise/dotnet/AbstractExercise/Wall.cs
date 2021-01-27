using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public abstract class Wall
    {
        public string Name { get; }
        public string Color { get; }
        //constructor for name and color
        public Wall(string name, string color)
        {
            this.Name = name;
            this.Color = color;

        }
        public abstract int GetArea();
        
           //Subclasses need to implement getarea method to return total Area of wall.
            
        
    }
}
