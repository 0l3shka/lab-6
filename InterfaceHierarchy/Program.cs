using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    public class BitmapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        public void DrawInBoundingBox(int top,int left,int bottom,int right)
        {
            Console.WriteLine("Drawing in a box...");
        }
        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside down!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Simple Interface Hierarchy ******");
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150); 
            myBitmap.DrawUpsideDown();

            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();

            Console.ReadLine();
        }
    }
}
