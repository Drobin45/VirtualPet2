using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet myCat = new VirtualPet("Danger", 0, 0, 0, 0, false, 0, 100, false, false);

            int selectedOption;

            // Entire Virtual Pet commandlist is within a do-while loop.

            do
            {
                //Console.Clear();    
                myCat.CheckForSickness();
                myCat.CheckForDeath();
                myCat.AdventureCheck();

                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Water the pet");
                Console.WriteLine("3. Take it to to use the bathroom");
                Console.WriteLine("4. Search for medicine!");
                Console.WriteLine("5. Play");
                Console.WriteLine("6. Quit");                

                selectedOption = int.Parse(Console.ReadLine());               

                switch (selectedOption)
                {
                    case 1:

                        myCat.HungerDecrease();
                        myCat.ThirstIncrease();
                        myCat.BoredomeIncrease();
                        myCat.WasteIncrease();
                        myCat.WasteIncrease();
                        myCat.ContractSicknessRoll();

                        Console.WriteLine("Thank you for feeding the pet");
                        break;

                    case 2:
                        myCat.ThirstDecrease();
                        myCat.HungerIncrease();
                        myCat.BoredomeIncrease();
                        myCat.WasteIncrease();
                        myCat.ContractSicknessRoll();

                        Console.WriteLine("You FINALLY watered your pet! Don't forget, this dumb, little beast depends on you for survival!");
                        break;

                    case 3:
                        myCat.EmptyWaste();
                        myCat.ThirstIncrease();
                        myCat.HungerIncrease();
                        myCat.BoredomeIncrease();
                        myCat.ContractSicknessRoll();
                        Console.WriteLine("Your animal has relieved herself! Don't forget, everybody poops!");
                        break;

                    case 4:
                        myCat.SearchForMedicine();
                        myCat.ThirstIncrease();
                        myCat.HungerIncrease();
                        myCat.WasteIncrease();
                        myCat.BoredomeIncrease();
                        break;

                    case 5:
                        myCat.Play();
                        myCat.ThirstIncrease();
                        myCat.HungerIncrease();
                        myCat.WasteIncrease();
                        myCat.ContractSicknessRoll();
                        Console.WriteLine("You frolic in the meadow with your beloved animal companion: what joy!");
                        break;                       

                    case 6:

                        Console.WriteLine("Thank you for playing.");
                        Environment.Exit(0);
                        break;

                    case 7:
                        {
                            Console.Clear();
                            break;
                        }

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }

            } while (selectedOption != 7);   

           

        }
    }
}
