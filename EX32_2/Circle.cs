using System;
using System.Collections.Generic;
using System.Text;

namespace EX32
{
    class Circle : Surface
    {
        readonly public float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float GetSurface()
        {
            return radius * radius * MathF.PI;
        }
        public override float GetCircumference()
        {
            return radius * 2 * MathF.PI;
        }
        public override void GetBounds(out float vertical, out float horizontal)
        {
            vertical = radius * 2;
            horizontal = radius * 2;
        }

    }
}