using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiPet
{
    class VirtualPet
    {
//Fields
        private string petName;
        private bool hunger; 
        private bool tired;
        private bool bored;
        private bool thirst;
        private bool userChoice;

        public int tick;
//Constructors
        public VirtualPet(string petName)
        {
            this.petName = Name;
        }

        public VirtualPet()
        {          
            hunger = false;
            tired = true;
            bored = false;
            thirst = true;
        } 

// Properties
        public string Name
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public bool Feed
        {
            get { return this.hunger; }
            set
            {
                if (hunger == true)
                {
                    Console.WriteLine("I'm Hungry");
                }
                else
                {
                    Console.WriteLine("I'm not hungry");                
                }
                this.hunger = value;
            }
        }
        public bool Fatigue
        {
            get { return this.tired; }
            set { this.tired = value; }
        }

        public bool Boredom
        {
            get { return this.bored; }
            set { this.bored = value; }
        }

        public bool Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public bool UserChoice
        {
            get { return this.userChoice; }
            set { this.userChoice = value; }
        }

// Methods
        public void PetInfo()
        {
            Console.WriteLine(this.petName);
        }
        public void Status()
        {            
            if (this.hunger == true)
                Console.WriteLine("I'm Hungry");
            else
                Console.WriteLine("I'm not hungry");

            if(this.tired == true)
                Console.WriteLine("I'm Tired");
            else
                Console.WriteLine("I'm not tired!");

            if(this.bored == true)
                Console.WriteLine("I'm bored!");
            else
                Console.WriteLine("I'm not Bored");

            if(this.thirst == true)
                Console.WriteLine("I'm thirsty!");
            else
                Console.WriteLine("I'm not thirsty");
        }

        public void GiveFood()
        {
            //bool hunger = true;// how  too set bool to true
            if (hunger == true) // do i have to declare userchoice somewhere? Where do I put this.hunger?
            {
                Console.WriteLine("This tasts great!");
                this.hunger = false;
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("I'm not hungry");
                System.Threading.Thread.Sleep(2000);
            }            

        }
        public bool Play()
        {
            
            if (bored == true)
            {
                Console.WriteLine("This is soo Fun!");
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("I'm not bored, Leave me alone");
                System.Threading.Thread.Sleep(2000);
            }
            return this.bored;
        }

        public bool PutToSleep()
        {
            
            if (tired == true)
            {
                Console.WriteLine("I'm going to sleep now. See you after I wake up");
                System.Threading.Thread.Sleep(2000); //menu
            }
            else
            {
                Console.WriteLine("I'm not tired yet!");
                System.Threading.Thread.Sleep(2000);
                
            }
            return this.bored;
        }

        public bool GiveWater()
        {
            
            if (thirst == true)
            {
                Console.WriteLine("Mmm, that's refreshing");
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("No thank you, I'm not thirsty");
                System.Threading.Thread.Sleep(2000);
            }
            return this.thirst;
        }

         public void Tick()
        {
            Random rng = new Random();
            tick = rng.Next(0, 3);
            if (tick == 0)
            {
                hunger = true;
                bored = true;
                tired = false;
                thirst = false;
            }
            else if (tick == 1)
            {
                hunger = false;
                bored = false;
                tired = true;
                thirst = true;
            }
            else 
            {
                hunger = true;
                bored = false;
                tired = true;
                thirst = false;         
            }

        }

        }
    }





