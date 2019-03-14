using System;

namespace stars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //********
            //*******
            //******
            //*****
            //****
            //***
            //**
            //*

            for (int i = 0; i <= 7; i++)
            {
                string stars = new string('*', 8 - i);
                string spaces = new string(' ', i);

                Console.WriteLine($"{stars}{spaces}");
            }

            Console.ReadLine();

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******

            for (int i = 1; i <= 7; i++)
            {
                string stars = new string('*', i);
                Console.WriteLine(stars);
            }

            Console.ReadLine();

            //       *
            //      **
            //     ***
            //    ****
            //   *****
            //  ******

            for (int i = 1; i <= 6; i++)
            {
                string spaces = new string(' ', 6 - i);

                string stars = new string('*', i);

                Console.WriteLine($"{spaces}{stars}");
            }
            Console.ReadLine();
        }
    }
}