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
            VirtualPet myCat = new VirtualPet("Danger", 0, 0, 0, 0, false, 0, 100);

            int selectedOption;

            do
            {
                //Console.Clear();    
                myCat.CheckForSickness();
                myCat.CheckForDeath();

                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Water the pet");
                Console.WriteLine("3. Take it to to use the bathroom");
                Console.WriteLine("4. Search for medicine!");
                Console.WriteLine("5. Play");
                Console.WriteLine("6. Go on an Adventure!");
                Console.WriteLine("7. Quit");

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
                        Console.WriteLine("You have disembarked from your master! What great freedom lies before your adventerous littel paws! With the future lying in wait, where will you let your little, fury destiny take you?");
                        Console.WriteLine(" 1.Flee to the forest with your beastial brethren!\n 2. There is a town nearby, a full human hive! Truly, not all humans can be as bad as your prior master! \n 3. There is a wizard's tower to the South, you could take that human, and make the mighty fellow bow to your even mightier will! /n");
                        int classDecision = int.Parse(Console.ReadLine());
                        switch (classDecision)
                        {
                            case 1:
                                Console.WriteLine("While your awful human was uncaging you to let you 'play', you savagely bit his hamfisted paw! Your act of bravery won you a moment of freedom. You leap from his palm and kick wildly as you free fall to the floor.");

                                break;
                            case 2:
                                Console.WriteLine();

                                break;
                            case 3:
                                Console.WriteLine();

                                break;
                            default:

                                break;
                        }

                        break;

                    case 7:

                        Console.WriteLine("Thank you for playing.");
                        break;

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }

            } while (selectedOption != 7);

            //switch (classDecision)
            //{
            //    case 1:

            //        break;
            //    case 2:

            //        break;
            //    case 3:

            //        break;
            //    default:

            //        break;
            //}
        }
    }
}
