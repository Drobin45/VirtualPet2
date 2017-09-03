using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet2._0
{
    class VirtualPet
    {

        //Fields
        private string name;
        private int hunger;
        private int thirst;
        private int waste;
        private int boredom;
        private bool sickness;
        private int tiredness;
        private int hp;
        private bool armor;
        private bool adventure;


        //Constructors
        public VirtualPet()
        {
            //Default
        }

        public VirtualPet(string name, int hunger, int sick, int boredem)
        {
            this.name = name;
        }

        public VirtualPet(string name, int hunger, int thirst, int waste, int boredom, bool sickness, int tiredness, int hp, bool armor, bool adventure)
        {
            this.name = name;
            this.hunger = hunger;
            this.waste = waste;
            this.thirst = thirst;
            this.sickness = sickness;
            this.boredom = boredom;
            this.tiredness = tiredness;
            this.hp = hp;
            this.armor = armor;
            this.adventure = adventure;

        }

        //Methods

            //Basic pre-Game stat effectors

        public void HungerIncrease()
        {

            this.hunger = hunger + 3;
        }


        public void HungerDecrease()
        {

            this.hunger = hunger - 5;
        }
        //-------------------------------------------
        public void ThirstIncrease()
        {
            this.thirst++;
        }

        public void ThirstDecrease()
        {
            this.thirst = thirst - 7;
        }
        //-------------------------------------------
        public void WasteIncrease()
        {
            this.waste++;
        }
        public void EmptyWaste()
        {
            this.waste = 0;
        }
        //-------------------------------------------
        
        public void BoredomeIncrease()
        {
            this.boredom++;
        }
        public void Play()
        {
            this.boredom = 0;
        }
        //-------------------------------------------
        public void TirednessIncrease()
        {
            this.tiredness = tiredness + 5;
        }
        //-------------------------------------------
        public void ContractSicknessRoll()
        {
            Random sickRoll = new Random();
            int sick = sickRoll.Next(0, 11);

            if (sick == 1)
            {
                Console.WriteLine("Your poor little pet has fallen ill!");
                this.sickness = true;
            }
        }

        public void SearchForMedicine()
        {
            Random medicineRoll = new Random();
            int medicine = medicineRoll.Next(0, 11);

            if (medicine <= 6)
            {
                Console.WriteLine("Your poor little pet is finally cured!");
                this.sickness = false;
            }
            else
            {
                Console.WriteLine("You seach, but have no luck");
            }
        }

        public void CheckForSickness()
        {
            if (sickness == true)
            {
                SicknessDamage();
            }
            else
            {
                Console.WriteLine("Your pet is still healthy!");
            }
        }

        public void SicknessDamage()
        {
            this.hp = hp - 10;
            Console.WriteLine("Your pet is whithering with sickness! it loses 10 hp!");
        }

         public void CheckWaste()
        {
            if (waste == 15)
            {
                Console.WriteLine("Your pet has violently soiled itself, and you belongings... It loses 25 hp");
                this.hp = hp - 25;
            }
        }
        //-------------------------------------------COMBAT MECHANICS-----------------------------------

        //Receiving Damage
        public void TakeMinorDamage()
        {
            if (armor == true)
            {
                hp--;
            }
            else
            {
                this.hp = hp - 5;
            }
        }

        public void TakeModerateDamage()
        {
            if (armor == true)
            {
                this.hp = hp - 10;
            }
            else
            {
                this.hp = hp - 20;
            }
        }

        public void TakeSevereDamage()
        {
            if (armor == true)
            {
                this.hp = hp - 25;
            }
            else
            {
                this.hp = hp - 35;
            }
        }

        //-------------------------------------------DEATHCHECK----------------------------------
        public void CheckForDeath()
        {

            if (this.hunger == 15)
            {
                Console.WriteLine("Your cute animal has perished at your cruel, whithering hands...");
                Console.WriteLine("Any last words?");
                string words = Console.ReadLine();
                Environment.Exit(0);
            }
            else if (this.thirst == 15)
            {
                Console.WriteLine("Your cute animal has perished at your cruel, whithering hands...");
                Console.WriteLine("Any last words?");
                string words = Console.ReadLine();
                Environment.Exit(0);
            }
            else if (this.hp == 0)
            {
                Console.WriteLine("Your cute animal has perished at your cruel, whithering hands...");
                Console.WriteLine("Any last words?");
                string words = Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                MyPetStatus();
            }
        }
//-------------------------------------------------------------------------------------------------------------

        public void AdventureCheck()
        {
            if (this.boredom == 10)
            {
                Console.WriteLine("\n Mighty kitten, you have grown bored of captivity, and now must find an escape from your wretched \"owner\". How will you escape?");
                Console.WriteLine("\n 1. I will maw his awful palm, and run while he panics! \n  \n 2. I will wait for him to sleep then slink out into the night. \n \n 3. I will bend his environment to my will, and create a trap that will incapacitate him long enough for me to leave!");
                int escapePlan = int.Parse(Console.ReadLine());
                switch (escapePlan)
                {
                    case 1:
                        Console.WriteLine("While your awful human was uncaging you to let you 'play', you savagely bit his hamfisted paw!\n Your act of bravery won you a moment of freedom. You leap from his palm and kick wildly as you free fall to the floor.");
                        Console.WriteLine("He rushes after you, but he is too clumbsy, or you are just too agile. You leap out of a nearby open window. \n Wind washes over your fir as you escape, you taste your freedom, though you were slightly hurt from your earlier fall.");
                        Console.WriteLine("You have taken 10 damage");
                        this.hp = hp - 10;
                        break;

                    case 2:
                        Console.WriteLine("The terrible human slumbers deeply, as you slip outside as quiet as, well, a kitten.");
                        Console.WriteLine("The night is dark, and humid enough to drink. Where will you go with your new freedom?");
                        break;
                    case 3:

                        Console.WriteLine("Your human has the fatal flaw of allowing his dishes to stack in an irresponsibly precarious position on his sink. \n He also doesn's dry the floor after a shower, leaving the floor slippery. An opportune environment for banboozlement. \n Which part of the environment will you use against your foolish captor?");
                        Console.WriteLine(" 1. I will tip over the dishes, and while they are distracted make my escape! \n 2. I will rush him when he is most vulnerable; when he is slippery and without fir!");

                        int dishesOrBathroom = int.Parse(Console.ReadLine());
                        switch (dishesOrBathroom)
                        {
                            case 1:
                                Console.WriteLine("Luckily, your soon-to-be former master has a dinner party.\n When the guests file in, and the chaos of a human gathering begins to swell, you dash to knock over the dishes! \n They crash and clatter onto the floor, a dozen sets of eyes are on the broken remnants of your escape\n as you plunge through a door recently left ajar by a guest. Freedom is yours!");

                                break;
                            case 2:
                                Console.WriteLine("While getting ready for a dinner party, your soon-to-be former master unfirs himself and showers. \n When he opens the door, you know the time is right! You pounce across his feet, scratching them and makin him flail and fall in abject terror! \n In the chaos he steps on your tail savagely (you take minor damage). \n You flee through the home, and cast yourself out the nearest open window! Freedom is yours!");
                                this.hp = hp - 10;
                                break;
                            default:
                                Console.WriteLine("Please enter an appropriate command, mighty kitten! ");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Please enter an appropriate command, mighty kitten! ");
                        break;
                }
                Console.WriteLine("You are now free little terror! The night is dark, and humid enough to drink. \n You drink it in with your newfound sense of freedom. What glory awaits you in your new liberty heavy existence. \n Choose wisely, and enter the world a new, liberated cat!");
                Environment.Exit(0);

                //Console.WriteLine("The night is dark, and humid enough to drink. Where will you go with your new freedom?");
                //int freedom = int.Parse(Console.ReadLine());
                //switch (freedom)
                //{

                //}

                //Console.WriteLine("You have disembarked from your master! What great freedom lies before your adventerous littel paws! With the future lying in wait, where will you let your little, fury destiny take you?");
                //Console.WriteLine(" 1.Flee to the forest with your beastial brethren!\n 2. There is a town nearby, a full human hive! Truly, not all humans can be as bad as your prior master! \n 3. There is a wizard's tower to the South, you could take that human, and make the mighty fellow bow to your even mightier will! /n");

            }

        }

       
        //--------------------------------------------------


        public void MyPetStatus()
        {
            CheckWaste();
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Waste: " + waste);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Tiredness: " + tiredness);
            Console.WriteLine("Your pet's health is " + hp + "/100");
            //-------------------------------------------     
        }
        }
    }
