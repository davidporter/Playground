﻿using System;
using System.Collections.Generic;
using System.Linq;  // this collection is needed to Sum and average arrays

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = {"apples", "oranges", "bananas"};
            foreach(var item in fruit)
            {
                Console.WriteLine(item);
            }


            string[] names = new string[3];
            names[0] = "Joseph";
            names[1] = "Mary";
            names[2] = "Martha";

            int[] weights = {23, 41, 103, 99, 142};
            int sum = weights.Sum();
            Console.WriteLine(sum);

            double avg = weights.Average();
            Console.WriteLine(avg);

            UseArray(names);

            System.Console.WriteLine("Multi-Dimensional Array: ");

            string[,] sections = new string[3,3];

            sections[0,0] = "top left";
            sections[0,1] = "top center";
            sections[0,2] = "top right";

            sections[1,0] = "middle left";
            sections[1,1] = "middle center";
            sections[1,2] = "middle right";

            sections[2,0] = "bottom left";
            sections[2,1] = "bottom middle";
            sections[2,2] = "bottom right";
        

        for(int i = 0; i < 3; i++ )
        {
            for(int j = 0; j < 3; j++)
            {
                System.Console.Write(sections[i,j] + "\t");
                if ((j+1) % 3 == 0)
                {
                    Console.WriteLine("");
                }
            }
        }

        List<string> fruitList = new List<string>();
        fruitList.Add("ZApple");
        fruitList.Add("Worm");
        fruitList.Add("Snake");
        foreach(var item in fruitList)
        {
            System.Console.WriteLine(item);
        }
        fruitList.Sort();  // sort list
                foreach(var item in fruitList)
        {
            System.Console.WriteLine(item);
        }

    ReportOnFigs(fruitList);

    // Dictionaries
    // usually use a string from the key

    Dictionary<string, double> inventory = new Dictionary<string, double>();
    Dictionary<string, double> salary = new Dictionary<string, double>();

    inventory.Add("Figs", 56);
    inventory.Add("Apples", 23);
    inventory.Add("Oranges", 12);

    // MUST get a list of key values - 
    // use "Keys" property of Dictionary object
    List<> keys = inventory.Keys;

    System.Console.WriteLine("Number of items: " + keys.Count);

    foreach (var key in keys)
    {
        Console.WriteLine(key + ": " + inventory[key]);
    }

    // put my keys in to an array
    string[] keysArray = keys.ToArray();
    // sort my keysArray
    Array.Sort(keysArray);

    foreach(var key in keysArray)
    {
        System.Console.WriteLine(key + ": " + inventory[key]);
    }

    // getting a value from the Dictionay
    // when you are NOT sure if the value exists
    double value;
    // use TryGetValue method of the Dictionay object
    if(inventory.TryGetValue("Figs", out value))
    {
        Console.WriteLine("Figs inventory " + value);
    }
    else
    {
        System.Console.WriteLine("Figs inventory not found");
    }

    }


        static void UseArray(string[] values)
        {
            Console.WriteLine("Values in method: ");
            foreach (var item in values)
            {
                System.Console.WriteLine(item);
            }
        }

// probably would have been better to make more generic 
// by passing in value to compare
        static void ReportOnFigs(List<string> items)
        {
            string figRerport = 
                items.Contains("Fig", StringComparer.OrdinalIgnoreCase) ?
                "Yes there are figs." :
                "No there are no figs";
            Console.WriteLine(figRerport);
        }
    }
}
