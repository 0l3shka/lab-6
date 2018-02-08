using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    interface IDrawable
    {
        void Draw();
    }
    interface IPrintable
    {
        void Print();
        void Draw();
    }

    interface IShape : IDrawable,IPrintable
    {
        int GetNumberOfSides();
    }


    class Rectangle : IShape
    {
        public int GetNumberOfSides()
        { return 4; }

        public void Draw()
        { Console.WriteLine("Drawing..."); }

        public void Print()
        { Console.WriteLine("Printing..."); }
    }

    class Square : IShape
    {
        void IPrintable.Draw()
        { Console.WriteLine("Square to printer"); }

        void IDrawable.Draw()
        { Console.WriteLine("Square to screen"); }

        public void Print()
        {
            Console.WriteLine("Printing Square...");
        }

        public int GetNumberOfSides()
        { return 4; }
    }

    class Triangle : IShape
    {
        void IPrintable.Draw()
        { Console.WriteLine("Triangle to printer"); }

        void IDrawable.Draw()
        { Console.WriteLine("Triangle to screen"); }

        public void Print()
        {
            Console.WriteLine("Printing Triangle...");
        }

        public int GetNumberOfSides()
        { return 3; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Square s1 = new Square();
            Triangle t1 = new Triangle();

            r1.Draw();
            ((IDrawable)r1).Draw();
            ((IPrintable)r1).Draw();

           ((IDrawable)s1).Draw();
            ((IPrintable)t1).Draw();

              

            Console.ReadLine();
        }
    }
}
