﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsolationTasks
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width) 
        {
            this.Length = length;
            this.Width = width;
        }

        public double areaRectangle() 
        {
            return this.Length * this.Width;
        }
    }
}
