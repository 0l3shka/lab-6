using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceNameClash
{
    class Octagon: IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to Form...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to Memory...");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to a Printer...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            Octagon oct = new Octagon();

            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            ((IDrawToPrinter)oct).Draw();

            if (oct is IDrawToMemory)
                ((IDrawToMemory)oct).Draw();

            Console.ReadLine();

        }
    }
}
