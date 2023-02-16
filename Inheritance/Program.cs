using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var penguin = new Bird();
            penguin.CanGrow = true;
            penguin.CanMove = true;
            penguin.NeedsToEat = true;
            penguin.NeedsRespiration = true;
            penguin.PreferredFood = "fish and krill";
            penguin.MainFeatherColor = "black and white";
            penguin.AverageNumEggsLaid = 1;
            penguin.HasWings= true;

            var garterSnake = new Reptile()
            {
            CanMove = true,
            CanGrow = true,
            NeedsToEat = true,
            NeedsRespiration = true,
            PreferredFood = "insects",
            HasForkedTongue = true,
            IsColdBlooded = true,
            NumberOfLegs = 0,
            };

            Console.WriteLine(penguin.AnimalFacts()); 
            Console.WriteLine("Would you rather learn about a penguin or a garter snake? Please type the animal name.");
            var answer = Console.ReadLine();
            while (answer != "penguin" && answer != "garter snake")
            {
                Console.WriteLine("Please only type the animal name, penguin or garter snake!");
                answer = Console.ReadLine();
            } 
            if (answer == "penguin")
            {
                Console.WriteLine("I like penguins too! Here are some facts about them!");
                Console.WriteLine($"penguins have wings = {penguin.HasWings}");
                Console.WriteLine($"penguins favorite food = {penguin.PreferredFood}");
                Console.WriteLine($"penguins average number of eggs laid = {penguin.AverageNumEggsLaid}");
                Console.WriteLine($"penguins feather color = {penguin.MainFeatherColor}");
                Console.WriteLine($"penguins need to breathe even though they can go underwater for a long time = {true}");
            }
            else if(answer == "garter snake")
            {
                Console.WriteLine("I like garter snakes too! Here are some facts about them:");
                Console.WriteLine($"garter snakes have forked tongues = {garterSnake.HasForkedTongue}");
                Console.WriteLine($"garter snakes favorite food is = {garterSnake.PreferredFood}");
                Console.WriteLine($"garter snakes are cold blooded = {garterSnake.IsColdBlooded}");
                Console.WriteLine($"garter snakes have {garterSnake.NumberOfLegs} legs.");
            }




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
