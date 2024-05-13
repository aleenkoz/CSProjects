using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a MadLibs set up that will prompt the user to enter inputs and complete the story.
            Author: ME! (Aleen Muhammad)
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Welcome to the Changable story where you will decide the...evreything about it! MadLibs has started!");

            // Give the Mad Lib a title:
            Console.WriteLine("Name your story, any name you want, and make it fun! ");
            string title = Console.ReadLine();

            // Define user input and variables:
            Console.WriteLine("Your Story needs a good main Charcter! Name her/him: ");
            string MC = Console.ReadLine();
            Console.WriteLine("Let's add a sprinkle of emotion to this story, give us three adjectives that would describe nouns (hint: they can be colors, feelings, textures): ");
            string adj1 = Console.ReadLine();
            string adj2 = Console.ReadLine();
            string adj3 = Console.ReadLine();
            Console.WriteLine("Some more sprinkles, we need a verb from you (hint: anything that describes an action): ");
            string verb = Console.ReadLine();
            Console.WriteLine("The more the merier, give us two nouns (hint: they can be names of people, places, or things): ");
            string noun1 = Console.ReadLine();
            string noun2 = Console.ReadLine();
            Console.WriteLine("Let's add the element of weird, why don't you give us one animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine("a type of food: ");
            string food = Console.ReadLine();
            Console.WriteLine("A type of fruit: ");
            string fruit = Console.ReadLine();
            Console.WriteLine("Name a Superhero: ");
            string superhero = Console.ReadLine();
            Console.WriteLine("A country: ");
            string country = Console.ReadLine();
            Console.WriteLine("A dessert: ");
            string dessert = Console.ReadLine();
            Console.WriteLine("And lastly a year: ");
            string year = Console.ReadLine();



            // The template for the story:

            string story = $"This morning {MC} woke up feeling {adj1.ToLower()}. 'It is going to be a {adj2.ToLower()} day!' Outside, a bunch of {animal.ToLower()}s were protesting to keep {food.ToLower()} in stores. They began to {verb.ToLower()} to the rhythm of the {noun1.ToLower()}, which made all the {fruit.ToLower()}s very {adj3.ToLower()}. Concerned, {MC} texted {superhero}, who flew {MC} to {country} and dropped {MC} in a puddle of frozen {dessert.ToLower()}. {MC} woke up in the year {year}, in a world where {noun2.ToLower()}s ruled the world.";


            // Print the story:
            Console.WriteLine("Ready to read your chaotic story? Here we go!");
            Console.WriteLine(title);
            Console.WriteLine(story);

        }
    }
}
