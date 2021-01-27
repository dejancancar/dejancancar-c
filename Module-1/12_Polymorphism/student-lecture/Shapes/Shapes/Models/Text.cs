using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Text : IDrawable
    {
        public string Label { get; set; }
        public ConsoleColor Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Text(int x, int y, ConsoleColor color, string label)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
            this.Label = label;
        }

        public void Draw()
        {
            Console.CursorLeft = (int)(X * Console.WindowWidth / 100.0);
            Console.CursorTop = (int)(Y * Console.WindowHeight / 100.0);
            //set the color
            Console.ForegroundColor = Color;

            //write the text on the screen
            Console.WriteLine(Label);

            //reset the screen color
            Console.ResetColor();
        }


        public override string ToString()
        {
            return $"At ({X}, {Y}), a {Color} Label, with a value {Label}";

        }
    }

}
