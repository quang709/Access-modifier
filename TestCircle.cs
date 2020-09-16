using System;

namespace Access_modifier
{
    class TestCircle
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine(circle.GetColor());
            Console.WriteLine(circle.GetRadius());
        }
    }
}
