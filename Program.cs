using System;
using System.Collections.Generic;
using System.Linq;

// What we have done:
// Array list structures ie, List, Stack
// Class, predefined items that properties, methods and ctor
// Object???! JSON, (key, value)

namespace Dictionary
{
    class Program
    {


        public static System.Collections.Generic.Dictionary<string, int> GetWordCount(string body)
        {
            // I want to loop through every word in body
            // count the distinct words
            var wordCount = new System.Collections.Generic.Dictionary<string, int>();
            var text = body.Split(' ');

            foreach (var word in text)
            {
                Console.WriteLine(word);
                var key = word.Replace('.', ' ').Replace(',', ' ').Trim();


                // the key has to be unique, I have to check if that key already exists, 
                //if it already exists, then i need to increment the count by`1
                if (wordCount.ContainsKey(key))
                {
                    wordCount[key]++;
                }
                else
                {
                    wordCount.Add(key, 1);
                }
            }

            return wordCount;
        }

        static void Main(string[] args)
        {
            // A dictionary is the key value data structure that allows us to store and look data using a key some sort

            var myDictionary = new System.Collections.Generic.Dictionary<int, string>();

            myDictionary.Add(5, "hello world");
            myDictionary.Add(1, "something else");

            // foreach (var item in myDictionary)
            // {
            //     Console.WriteLine(item.Key);
            //     Console.WriteLine(item.Value);
            // }

            foreach (var item in myDictionary.Keys) { }

            foreach (var item in myDictionary.Values)
            {

            }


            // Console.WriteLine(myDictionary[5]);

            myDictionary.Remove(5);


            var lipson = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean gravida, lectus et fringilla mattis, nunc augue tincidunt turpis, eu finibus massa lacus sed quam. Nullam a velit nunc. Morbi malesuada massa ac leo fringilla, euismod dapibus purus cursus. Aliquam eu nulla id nibh vehicula lobortis a ac nulla. Curabitur eu cursus ex, at sagittis neque. Nullam sollicitudin ipsum a bibendum porttitor. Sed commodo lacinia eleifend. Aliquam quam metus, pharetra nec tempus at, dignissim non tellus. Suspendisse mi lacus, gravida placerat mauris scelerisque, accumsan cursus risus. Donec eu pretium ante, sit amet rhoncus tortor. Fusce vehicula ante nec dignissim faucibus. Nullam dapibus tellus ut orci auctor consequat. Proin id hendrerit ex, in tempus metus. Etiam condimentum eros nec lacinia imperdiet. Donec in leo risus.

Nullam finibus est leo, dignissim ultricies dolor pretium non. Maecenas sit amet sem leo. Etiam ullamcorper imperdiet ornare. Mauris vulputate malesuada purus id ullamcorper. Quisque a consectetur justo. Nam lobortis ullamcorper elit eget rhoncus. Maecenas lacinia vitae metus sed imperdiet.

Suspendisse vel massa at enim maximus fermentum. Integer in lectus lorem. Fusce et blandit risus. Phasellus sagittis, diam eu dictum blandit, lectus dui sodales dui, nec hendrerit ligula lorem eget velit. Curabitur at tortor sed quam tincidunt rutrum. Phasellus posuere tempus turpis suscipit sollicitudin. Duis fermentum sapien in ullamcorper fermentum. Etiam egestas libero metus, eu vulputate diam blandit vel. Pellentesque feugiat orci dictum, aliquam mauris iaculis, pellentesque nibh. Etiam et tortor mollis, condimentum sem ut, tempus nibh. Nam venenatis erat at tellus mattis ornare. Aenean euismod neque et ultricies commodo. Vivamus blandit ante libero, ac eleifend eros laoreet vitae.

Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla condimentum finibus lacinia. Nunc cursus laoreet libero a tincidunt. Nam viverra ac diam ac pharetra. Curabitur tristique turpis vulputate ligula venenatis pharetra. Suspendisse id pulvinar arcu. Integer vel eros pellentesque, sollicitudin nulla pretium, ullamcorper odio. Proin rutrum, metus ac tempus vestibulum, neque massa pulvinar magna, at sagittis justo lectus a risus. Mauris vitae augue non enim porttitor accumsan. Suspendisse massa ligula, cursus et turpis at, pharetra sollicitudin dolor. Phasellus gravida mi id odio tincidunt bibendum.

In gravida mi vel mattis consequat. Sed nulla metus, blandit in porta sed, fermentum at mi. Vestibulum sagittis tempus egestas. Aenean eget diam tellus. Phasellus rhoncus lectus leo, quis cursus metus euismod rhoncus. Nunc enim lectus, sollicitudin sed diam imperdiet, vestibulum tempus arcu. Proin faucibus ex id nisl condimentum vestibulum. Aenean risus enim, elementum in tempor eu, molestie quis tortor. Morbi auctor malesuada fringilla.";


            var count = GetWordCount(lipson).OrderBy(o => o.Value);
            foreach (var word in count)
            {
                Console.WriteLine($"{word.Key} has {word.Value} occurances");                
            }

        }
    }
}
