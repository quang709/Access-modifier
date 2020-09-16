using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifier
{
    class Circle
    {
        private double Radius = 1;
        private string Color = "red";

        public Circle() { }

        public Circle(double _Radius)
        {
            Radius = _Radius;
        }
        public double GetRadius()
        {
            return Radius;
        }

        public void SetRadius(double _Radius)
        {
            Radius =_Radius;
        }


        public string GetColor()
        {
            return Color;
        }
         public void SetColor(string _Color)
        {
            Color = _Color;
        }
    }
}
