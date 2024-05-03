using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(double width, double length) { Width = width; Length = length; }
        public double Length { get; set; }
        public override double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return Length * 2 + Width * 2;
        }

        public override string GetShapeName()
        {
            return "Rectangle";
        }
    }
}
