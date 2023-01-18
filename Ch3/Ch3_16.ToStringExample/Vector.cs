﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_16.ToStringExample
{
    public class Vector
    {
        public double X;
        public double Y;
        public double Z;
        public string Name;
        public Vector(string name)
        {
            X = 0;
            Y = 0;
            Z = 0;
            this.Name = name;
        }
        public virtual double Dot(Vector destination)
        {
            return 0;
        }
    }
}