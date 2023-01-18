using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_16.ToStringExample
{
    public class Vector3D : Vector
    {
        public Vector3D(string name) : base(name)
        {
        }
        public override string ToString()
        {
            return this.Name + "=(" + X + "," + Y  +"," + Z +")";
        }

        public override double Dot(Vector destination)
        {
            return X * destination.X + Y * destination.Y + Z *destination.Z;
        }

        protected override Vector Negate()
        {
            Vector v = new Vector(Name);
            v.X = -1 * v.X;
            v.Y = -1 * v.Y;
            v.Z = -1 * v.Z;
            return v;
        }
    }
}

