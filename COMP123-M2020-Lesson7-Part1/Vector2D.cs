using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson7_Part1
{
    class Vector2D
    {
        public float x, y;

        public Vector2D(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + this.x + "," + this.y+")";
        }
    }
}
