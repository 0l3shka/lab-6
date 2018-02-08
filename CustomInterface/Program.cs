using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces ******\n");

            Shape[] myShapes = {new Hexagon(), new Circle(), new Triangle("Joe"),
            new Circle("JoJo")};

            for(int i=0;i<myShapes.Length;i++)
            {
                myShapes[i].Draw();
                if (myShapes[i] is IPointy)
                    Console.WriteLine("-> Points: {0}", ((IPointy)myShapes[i]).Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
