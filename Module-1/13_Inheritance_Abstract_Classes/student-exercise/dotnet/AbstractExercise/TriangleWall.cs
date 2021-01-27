using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class TriangleWall : Wall
    {
        public int Base { get; }
        public int Height { get; }

        public TriangleWall(string name, string color, int @base, int height) : base(name, color)
        {
            this.Base = @base;
            this.Height = height;
        }
        public override int GetArea()
        {
            return (this.Base * this.Height) / 2;
        }

        public override string ToString()
        {
            return $"{Name} ({Base}x{Height}) triangle";
        }


    }
  
}
