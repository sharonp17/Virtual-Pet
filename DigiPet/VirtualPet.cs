using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiPet
{
    class VirtualPet
    {
//fields
        private string petName;
        private string color;
        private int petAge;
        private bool hunger; //should these be float? set to 0-5?
        private bool tired;
        private bool bored;
        private bool thirst;

//Constructors
        public VirtualPet(string petName, string color, int petAge)
        {
            this.petName = Name;
            this.color = Color;
            this.petAge = petAge;

            
        }
        public VirtualPet(bool hunger, bool tired, bool bored, bool thirst)
        {
            this.hunger = hunger;
            this.tired = tired;
            this.bored = bored;
            this.thirst = thirst;
        }

        public VirtualPet()
        {

        }
// Properties
        public string Name
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
           
        }

        public int PetAge
        {
            get { return this.petAge; }
            set { this.petAge = value; }
           
        }
//
        public void PetInfo()
        {
            Console.WriteLine(this.petName);
            Console.WriteLine(this.color);
            Console.WriteLine(this.petAge);
        }

        public void CurrentState()
        {
            //Console.WriteLine("Hunger" +);
            //Console.WriteLine("Fatigue" +);
            //Console.WriteLine("Boredome" +);
            //Console.WriteLine("Thirst" +);
        }
    }
}


