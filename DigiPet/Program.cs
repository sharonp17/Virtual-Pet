using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiPet
{
    class Program
    {
        static void Main(string[] args)
        {
// Virtual Pet is a digital interaction program that allows you to engage with the program in 4 ways.

            VirtualPet martian = new VirtualPet();
            int userChoice;

            Console.WriteLine(" \a  \t Welcome to your Virtual Martian Pet!");
            Console.WriteLine();
            Console.WriteLine("Congratulations! You're now the owner of marvelous Martian Panda!");
            Console.WriteLine();
            Console.WriteLine(" Let's begin by giving your pet a Name!");
            string userPetName = Console.ReadLine();
            Console.WriteLine();
            martian.Name = userPetName;

//After you have named your pet, you are prompted with an updated menue that shows the current status of your digital pet in the 4
//established categories of (Hunger, Fatigue, Boredome and Thirst). These values are established in bool so the status will only ever
//show the status in true/ false scenarios. i.g. hungry/not hungry, tired/ not tired. etc. The program is wrapped in a do-while loop 
//to keep return the menu after each user entry. 
            do
            {
                martian.Tick();
                Console.WriteLine("What would you like to do with " + userPetName + "?");
                Console.WriteLine();

                Console.WriteLine("Current Status");
                Console.WriteLine("Hunger = {0} ", martian.Hunger);
                Console.WriteLine("Fatigue = {0} ", martian.Fatigue);
                Console.WriteLine("Boredome = {0} ", martian.Boredom);
                Console.WriteLine("Thirst = {0} ", martian.Thirst);
                Console.WriteLine();
//depending on whether or not the current status of the pet is true or false the user entry will have different effects. for example,
//if the pet IS hungry and the user feeds the pet, the pet will accept the food. If the pet is NOT hungry the pet will tell the user
//that they are not hungry.

                Console.WriteLine("Type 1 : Feed \nType 2 : Put to bed \nType 3 : To Play with \nType 4 : to give water \n Press 5 to quit");
                userChoice = int.Parse(Console.ReadLine());
                {
                    int[] currentStatus = new int[5];

                    currentStatus[0] = 1;
                    currentStatus[1] = 2;
                    currentStatus[2] = 3;
                    currentStatus[3] = 4;

                    foreach (int choice in currentStatus)
                    {

                        if (userChoice == 1)
                        {
                            martian.Hungry();
                            break;
                        }

                        else if (userChoice == 2)
                        {
                            martian.Tired();
                            break;
                        }
                        else if (userChoice == 3)
                        {
                            martian.Bored();
                            break;
                        }
                        else if (userChoice == 4)
                        {
                            martian.Thirsty();
                            break;
                        }
                        else if (userChoice == 5)
                        {
                            Console.WriteLine("See you later!");
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                    }
                }

//After each entry the interaction will clear from the screen and a new menu/updated status will show.
                Console.Clear();

            }
            while (userChoice != 5);
        }
    }
}