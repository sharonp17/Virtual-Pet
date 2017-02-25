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

            Console.WriteLine(" Welcome to your Virtual Martian Pet!" );
            Console.WriteLine();
            Console.WriteLine("Congratulations! You're now the owner of marvelous Martian Panda");
            Console.WriteLine();
            Console.WriteLine(" Let's begin by giving your pet a Name!");
            string userPetName = Console.ReadLine();
            Console.WriteLine();
            martian.Name = userPetName;

            //Console.WriteLine(martian.Name);

            Console.WriteLine(@"Now you can choose their color from one of the following ""Rainbow"", ""Invisible"" or "" Black and White"" ");

            string[] color = { "Rainbow", "Invisible", "Black and White" };
            string martianColor = Console.ReadLine();

            if (martianColor == color)
            {

            }



        }
    }
}
