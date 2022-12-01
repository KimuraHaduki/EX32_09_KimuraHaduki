using System;
using System.Collections.Generic;
using System.Text;

namespace EX32
{
    class Triangle : Surface
    {
        readonly public float a;
        readonly public float b;
        readonly public float c;

        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override float GetSurface()
        {
            float s = (a + b + c) / 2;
            return MathF.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public override float GetCircumference()
        {
            return a + b + c;
        }
        public override void GetBounds(out float vertical, out float horizontal)
        {
            float bottom = a;
            if (bottom < b)
            {
                bottom = b;
            }
            if (bottom < c)
            {
                bottom = c;
            }
            float height = GetSurface() * 2 / a;
            vertical = height;
            horizontal = bottom;
        }
    }
}
