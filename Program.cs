using System;

namespace YesOk
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Are you looking for a car? Y/N");
                Console.Write("Input yes or no: ");
                string myInput = Console.ReadLine();
                if (myInput.ToLower() == "y" || myInput.ToLower() == "yes")
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Find a vehicle in the garage by adding a parameter.");
                    Console.WriteLine("Press 1. To find with a registration number.");
                    Console.WriteLine("Press 2. To find all with colour.");
                    Console.WriteLine("Press 3. To find all with a specified number of wheels.");
                    Console.WriteLine("Press 4. To find all with a minimum number of passengers.");
                    Console.WriteLine("Press 5. To find all with cabriolet");
                    Console.WriteLine("Press 0. Exit the finding!");

                    int myInt = int.Parse(Console.ReadLine());

                    switch (myInt)
                    {
                        case 1:
                            Console.WriteLine("Input the <registration number> of your vehicle that you are looking after");
                            Console.WriteLine("Example of how a registration number could look: abc-123");
                            Console.Write("Input reg number: ");
                            string regNum = Console.ReadLine();
                            //Call the search method

                            break;
                        case 2:
                            Console.WriteLine("Input the <colour> of your vehicle that you are looking after");
                            Console.WriteLine("Example on a colour: white");
                            Console.Write("Input colour: ");
                            string myColour = Console.ReadLine();
                            //Call the search method

                            break;
                        case 3:
                            Console.WriteLine("Input the amount of <wheels> your vehicle that you are looking for have");
                            Console.WriteLine("Example on how to input amount of wheels: 4");
                            Console.Write("Input wheels: ");
                            int wheelNum = int.Parse(Console.ReadLine());
                            //Call the search method

                            break;
                        case 4:
                            Console.WriteLine("Input the minimum amount of passangers that you are looking for in your vehicle");
                            Console.WriteLine("Example on how to input min amount of passangers: 4");
                            Console.Write("Input passangers: ");
                            int minNumPas = int.Parse(Console.ReadLine());
                            //Call the search method

                            break;
                        case 5:
                            Console.WriteLine("Are you looking for a car with a cabriolet Y/N?");
                            Console.Write("Input yes or no: ");
                            string cabriolet = Console.ReadLine();
                            //Call the search method

                            break;
                        default:
                            Console.WriteLine("Just add the close method, easy");
                            //Call the close method

                            break;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("bye bye");
            Console.WriteLine("some changes");
        }
    }
}
