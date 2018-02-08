using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                    return s as IPointy;
            }
            return null;
        }
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces ******\n");

            Shape[] myShapes = {new Hexagon(), new Circle(), new Triangle("Joe"),
            new Circle("JoJo")};

            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The item has {0} points", firstPointyItem.Points);

            for(int i=0;i<myShapes.Length;i++)
            {
                myShapes[i].Draw();
                if (myShapes[i] is IPointy)
                    Console.WriteLine("-> Points: {0}", ((IPointy)myShapes[i]).Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                Console.WriteLine();

                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);

            }

            Console.ReadLine();
        }
    }
}
