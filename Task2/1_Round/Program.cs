﻿using System;

namespace _1_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            new Round().Input_Round();
            Console.ReadKey();
        }

        public class Round
        {
            public Round Center_X;
            public Round Center_Y;
            public Round Radius;

            public double Length_of_Round(double r) => 3.14 * 2 * r;

            public double Square_of_Round(double r) => 3.14 * r * r;

            public Round(int x, int y, int r)
            {
                this.Center_X = x;
                this.Center_Y = y;
                this.Radius = r;
            }

            public void Input_Round()
            {
                Console.WriteLine("Enter center of round");
                Console.Write("x = ");
                var x = new Round().Center_X = Convert.ToInt32(Console.ReadLine());

                Console.Write("y = ");
                var y = new Round().Center_Y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter radius of round");
                Console.Write("r = ");
                var r = new Round().Radius = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Center(" + x + ", " + y + ")" + " radius: " + r);
                Console.WriteLine("Length of round = " + new Round().Length_of_Round(r) +
                                  " Square of Round = " + new Round().Square_of_Round(r));
                Console.WriteLine(r.GetType());
            }
        }

    }
}