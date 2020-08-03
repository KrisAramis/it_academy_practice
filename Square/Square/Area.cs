using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Square
{
    public class Ishape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public virtual double GetArea()
        {
            return side1 * side2;
        }
    }

   public class Area : Ishape
    {
        public float Side { get; set; }
        public override double GetArea()
        {
            return this.Side * this.Side;
        }
    }

    class Circle : Ishape
    {
        internal int rad { get; set; }
        public override double GetArea()
        {
            return this.rad * this.rad * Math.PI;
        }
    }

    class Triangle : Ishape
    {
        float height { get; set; }
        float baseside { get; set; }
        public override double GetArea()
        {
            return 1 / 2 * this.height * this.baseside;
        }
    }
}

