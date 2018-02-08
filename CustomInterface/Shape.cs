using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {
        public Shape(string name="NoName")
        { PetName = name; }

        public string PetName { get; set; }

        public abstract void Draw();
        
    }

    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }

    class Hexagon : Shape, IPointy,IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Gexagon", PetName);
        }

        public byte Points
        {
            get { return 6; }
        }

        public void Draw3D()
        { Console.WriteLine("Drawing Hexagon in 3D!"); }
    }

    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }

        public byte Points
        {
            get { return 3; }
        }
    }

    class ThreeDCircle: Circle, IDraw3D
    {
        public void Draw3D()
        { Console.WriteLine("Drawing Circle in 3D!"); }
    }

    
    
}
