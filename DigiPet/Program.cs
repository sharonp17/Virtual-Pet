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
            VirtualPet martian = new VirtualPet();
            int userChoice;

            Console.WriteLine(" \a  \t Welcome to your Virtual Martian Pet!");
            Console.WriteLine();
            Console.WriteLine("Congratulations! You're now the owner of marvelous Martian Panda!");
            Console.WriteLine();
            Console.WriteLine("Let's begin by giving your pet a Name!");
            string userPetName = Console.ReadLine();
            Console.WriteLine();
            martian.Name = userPetName;

            //Console.WriteLine(martian.Name);
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


                Console.Clear();

            }
            while (userChoice != 5);
        }
    }
}