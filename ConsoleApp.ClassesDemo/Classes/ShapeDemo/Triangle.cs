namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Triangle : Polygon
    {
        public Triangle(double width, double height) { Width = width; Height = height; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height / 2;
        }
    }
}
