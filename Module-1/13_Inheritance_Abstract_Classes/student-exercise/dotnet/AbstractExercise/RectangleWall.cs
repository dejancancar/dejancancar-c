using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class RectangleWall : Wall
    {
        //RectangleWall(string Name, string Color) : base(string name, string color)

        public int Length { get; }
        public int Height { get; }

        public RectangleWall(string name, string color, int length, int height) : base (name, color)
        {
            this.Length = length;
            this.Height = height;
        }

        public override int GetArea()
        {
            return this.Length * this.Height;
        }

        public override string ToString()
        {
            return $"{Name} ({Length}x{Height}) rectangle";
        }
    }
}
