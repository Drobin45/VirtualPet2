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


        //Constructors
        public VirtualPet()
        {
            //Default
        }

        public VirtualPet(string name, int hunger, int sick, int boredem)
        {
            this.name = name;
        }

        public VirtualPet(string name, int hunger, int thirst, int waste, int boredom, bool sickness, int tiredness, int hp)
        {
            this.name = name;
            this.hunger = hunger;
            this.waste = waste;
            this.thirst = thirst;
            this.sickness = sickness;
            this.boredom = boredom;
            this.tiredness = tiredness;
            this.hp = hp;

        }

        //Methods

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
        public void Sickness()
        {
            this.sickness = true;
            Console.WriteLine("Oh no, your pet has contracted a rare illness!");
        }

        public void Cured()
        {
            this.sickness = false;
            Console.WriteLine("Your pet is cured!");
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

        //-------------------------------------------
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
        //-------------------------------------------
        public void CheckWaste()
        {
            if (waste == 15)
            {
                Console.WriteLine("Your pet has violently soiled itself, and you belongings... It loses 25 hp");
                this.hp = hp - 25;
            }
        }


        //-------------------------------------------



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
