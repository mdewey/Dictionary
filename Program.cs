using System;
using System.Collections.Generic;


// What we have done:
// Array list structures ie, List, Stack
// Class, predefined items that properties, methods and ctor
// Object???! JSON, (key, value)

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // A dictionary is the key value data structure that allows us to store and look data using a key some sort

            var myDictionary = new System.Collections.Generic.Dictionary<int,string>();

            myDictionary.Add(5 ,"hello world");
            myDictionary.Add(1, "something else");

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);                
            }

            foreach(var item in myDictionary.Keys){}

            foreach (var item in myDictionary.Values)
            {
                
            }


            Console.WriteLine(myDictionary[5]);

            myDictionary.Remove(5);


            Console.WriteLine("Hello World!");
        }
    }
}
