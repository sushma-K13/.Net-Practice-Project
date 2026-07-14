using Basic_DotNet_Concepts.Solid_Principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Basic_Concepts.Solid_Principles.Shapes
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }

    //Notice that Square DOES NOT inherit Rectangle.
    //This fixes the classic LSP violation.
    public class Square : IShape
    {
        public double Side { get; set; }

        public double CalculateArea()
        {
            return Side * Side;
        }
    }
}
