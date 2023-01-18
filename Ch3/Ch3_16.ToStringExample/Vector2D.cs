﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_16.ToStringExample
{
    public class Vector2D :Vector
    {

        public Vector2D(string name) : base(name) { }

        public override string ToString()
        {
            return this.Name + "=(" + X + "," + Y + ")";
        }

        public override double Dot(Vector destination)
        {
            return X * destination.X + Y * destination.Y;
        }
    }
}
