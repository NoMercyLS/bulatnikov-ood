using Factory.Enum;
using Factory.Interfaces;
using Factory.Shapes;
using System;
using System.ComponentModel;

namespace Factory
{
    public class CShapeFactory : IShapeFactory
    {
        public CShape CreateShape(string description)
        {
            var args = description.Split();
            return (args[0].ToLower()) switch
            {
                "rectangle" => CreateRectangle(args),
                "triangle" => CreateTriangle(args),
                "ellipse" => CreateEllipse(args),
                "regularpolygon" => CreateRegularPolygon(args),
                _ => throw new ArgumentException($"Failed to create shape with name {args[0]}.")
            };
        }

        private CShape CreateRegularPolygon(string[] args)
        {
            if (args.Length == 6)
            {
                EColor color = ToColor(args[1]);
                CPoint center = new CPoint(Convert.ToDouble(args[2]), Convert.ToDouble(args[3]));
                double radius = Convert.ToDouble(args[4]);
                int vertexCount = Convert.ToInt32(args[5]);
                return new CRegularPolygon(center, radius, vertexCount, color);
            }
            throw new ArgumentException("Failed to create a regular polygon.\nUsage: RegularPolygon <color> <center> <radius> <vertex count>\n");
        }
        private CShape CreateRectangle(string[] args)
        {
            if (args.Length==6)
            {
                EColor color = ToColor(args[1]);
                CPoint leftTop = new CPoint(Convert.ToDouble(args[2]), Convert.ToDouble(args[3]));
                CPoint rightBottom = new CPoint(Convert.ToDouble(args[4]), Convert.ToDouble(args[5]));
                return new CRectangle(leftTop, rightBottom, color);
            }
            throw new ArgumentException("Failed to create a rectangle.\nUsage: Rectangle <color> <left top> <right bottom>\n");
        }
        private CShape CreateTriangle(string[] args)
        {
            if (args.Length == 8)
            {
                EColor color = ToColor(args[1]);
                CPoint vertex1 = new CPoint(Convert.ToDouble(args[2]), Convert.ToDouble(args[3]));
                CPoint vertex2 = new CPoint(Convert.ToDouble(args[4]), Convert.ToDouble(args[5]));
                CPoint vertex3 = new CPoint(Convert.ToDouble(args[6]), Convert.ToDouble(args[7]));

                return new CTriangle(vertex1, vertex2, vertex3, color);
            }
            throw new ArgumentException("Failed to create a triangle.\nUsage: Triangle <color> <vertex1> <vertex2> <vertex3>");
        }
        private CShape CreateEllipse(string[] args)
        {
            if (args.Length == 6)
            {
                EColor color = ToColor(args[1]);
                CPoint center = new CPoint(Convert.ToDouble(args[2]), Convert.ToDouble(args[3]));
                double horizontalRadius = Convert.ToDouble(args[4]);
                double verticalRadius = Convert.ToDouble(args[5]);

                return new CEllipse(center, horizontalRadius, verticalRadius, color);
            }
            throw new ArgumentException("Failed to create an ellipse.\nUsage: Ellipse <color> <center> <horisontalRadius> <verticalRadius>");
        }
        private EColor ToColor(string arg)
        {
            return arg.ToLower() switch
            {
                "green" => EColor.Green,
                "red" => EColor.Red,
                "blue" => EColor.Blue,
                "yellow" => EColor.Yellow,
                "pink" => EColor.Pink,
                "black" => EColor.Black,
                _ => throw new InvalidEnumArgumentException("Incorrect color. You can choose color from [green, red, blue, yellow, pink, black]"),
            };
        }
    }
}
