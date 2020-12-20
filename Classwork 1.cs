using System;

namespace Classwork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Salim The Wise";
            int age = 24;
            float speed = 25.7f;
            string p1 = "time control";
            string p2 = "invisibility";

            Console.WriteLine("My name is {0}. A few of my abilities include {1} and {2}. My age? Well let's just say I'm {3}. How fast I can run?! What a silly question, but my speed is {4} meters per second... yes... surely that's how fast I can run!", characterName, p1, p2, age, speed);
        }
    }
}