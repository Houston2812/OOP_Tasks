using System;

namespace task5;

class Task5Main{
    

    static public void Main(string[] args)
    {
        CarFacade carFacade = new CarFacade();

        string model = "";
    
        while(true)
        {
            Console.WriteLine("Choose a model:");
            Console.WriteLine("\t[*]Mitsubishi Eclipse");
            Console.WriteLine("\t[*]Toyota Celica");
            Console.WriteLine("\t[*]Asura RSX\n");
            Console.Write("Model: ");
            model = Console.ReadLine();

            bool result = carFacade.CreateCar(model.Trim());
            if (!result)
            {
                Console.WriteLine("Wrong name. Please enter correct car name.\n");
            } else
            {
                break;
            }
        }

        while(true)
        {
            Console.WriteLine("\nChoose a vinyl:");
            Console.WriteLine("\t[*]Lightning");
            Console.WriteLine("\t[*]Tribal");
            Console.WriteLine("\t[*]Fire\n");

            Console.WriteLine("To get final result enter:");
            Console.WriteLine("\t[*]Get Style\n");

            Console.Write("Style: ");
            string vinyl = Console.ReadLine().Trim();
            if (vinyl != "Get Style")
            {
                bool result = carFacade.AddVinyl(vinyl);
                if (!result)
                    Console.WriteLine("Error! Enter correct style!\n");
                else
                    Console.WriteLine("Style applied successfully!\n");
            }
            else 
            {
                carFacade.GetStyle();
                break;
            }
        }
        

    }
}