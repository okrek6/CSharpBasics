using System;

namespace CBasicsConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            const byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const String greeting = "Hello";
            String name = "Karen";
            //Question 1
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
#pragma warning disable CS0162 // Unreachable code detected
                Console.WriteLine("The samples are not equal");
#pragma warning restore CS0162 // Unreachable code detected
            }
            //Question 2
            if (heartRate >= 40 && heartRate < 80)
            {
                Console.WriteLine("Heart Rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart Rate is not Noraml.");
            }
            //Question 3
            if (deposits >= 10000000)
            {
                Console.WriteLine("You are exceedingly wealthy");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }
            //Question 4

            float force = mass * acceleration;

            //Question 5

            Console.WriteLine("Force = {force}");

            //Question 6

            Console.WriteLine($"{distance} is the distance.");

            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off.");
            }

            //Question 7

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            //Question 8

            Console.WriteLine($"{integral} is an integral.");

            //Question 9

            for (int i = 5; i < 11; i++)
            {
                Console.WriteLine($"i = {i}");
            }

            //Question 10

            int age = 0;

            while (age < 6)
            {
                Console.WriteLine($"age = {age}");
                age++;
            }

            Console.WriteLine($"{greeting} + {name}");
        }
    }
}
