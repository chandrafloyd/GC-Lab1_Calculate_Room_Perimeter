using System;

namespace Lab1_Calculate_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            //Intro
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            Console.WriteLine();

            //bool ExitKey = false;
          
            
            {

                //INPUT - Get values

               
                double Width, Length, Height;

                Console.WriteLine("Enter length:");
                Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter width:");
                Width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter height:");
                Height = double.Parse(Console.ReadLine());

                //PROCESSING - Formulas for area and perimeter

                double Area = Length * Width;
                double Perimeter = Length + Length + Width + Width;
                double Volume = Length * Width * Height;

                //OUTPUT 
                Console.WriteLine("");
                Console.WriteLine("Area: " + Area);
                Console.WriteLine("Perimeter: " + Perimeter);
                Console.WriteLine("Volume: " + Volume);

                //REPEAT
                Console.WriteLine("Calculate another room? (Y/N)");
                string ExitKey = Console.ReadLine();

                if (ExitKey == "N")  //if ExitKey=="Y", loop back to the top
                {
                    Console.WriteLine("Goodbye!");
                    System.Threading.Thread.Sleep(1000);
                }
                while (ExitKey == "Y") ;
            }

            
        }
    }
}
