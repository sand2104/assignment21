﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace assignment21

{
    internal class Program
    {

        static List<string> fruitsList = new List<string>()
        {
            "Apple", "Banana", "Orange", "Pineapple", "Blueberry", "Green Apple", "Grapes", "Strawberry", "Watermelon", "Mango"

        };

        static List<string> daysOfWeek = new List<string>()
        {
            "Sunday", "Monday","Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
        };

        static List<string> monthsOfYear = new List<string>()
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };

        static Dictionary<string, string> wordMeanings = new Dictionary<string, string>()
        {
            { "Anonymous", "Whose name is not known or made public"},
            { "Obsession", "The state in which you can only think about one person or thing so that you cannot think of anything else\r\n"},
            { "Radiant", "Showing great happiness\r\n"},
            {"Gesture","A movement of the hand, head, etc. that expresses something\r\n" },
            {"Zenith","The highest point that the sun or moon reaches in the sky, directly above you\r\n" }

        };

        static void DisplayDays()
        {
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine("Day :" + day);
                Thread.Sleep(2000);

            }
        }

        static void DisplayMonths()
        {
            foreach (string month in monthsOfYear)
            {
                Console.WriteLine("Month: " + month);
                Thread.Sleep(2000);
            }
        }

        static void DisplayFruits()
        {
            foreach (var fruit in fruitsList)
            {
                Console.WriteLine("Fruits: " + fruit);
                Thread.Sleep(1000);
            }
        }

        static void DisplayWordsAndMeanings()
        {
            foreach (var word in wordMeanings)
            {
                Console.WriteLine($"Words: {word.Key} - Meaning: {word.Value}");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to Learning------\n");

            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsThread = new Thread(DisplayFruits);
            Thread wordsThread = new Thread(DisplayWordsAndMeanings);

            daysThread.Start();
            daysThread.Join();

            Thread.Sleep(5000);

            monthsThread.Start();
            monthsThread.Join();

            fruitsThread.Start();
            wordsThread.Start();

            fruitsThread.Join();
            wordsThread.Join();

            Console.ReadKey();

        }
    }
}