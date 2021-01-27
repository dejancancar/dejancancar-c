﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public interface IDrawable
    {
        int X { get; set; }
        int Y { get; set; }
        void Draw();
    }
}
