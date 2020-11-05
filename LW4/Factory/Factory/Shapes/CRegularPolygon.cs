using Factory.Enum;
using Factory.Interfaces;
using System;

namespace Factory.Shapes
{
    public class CRegularPolygon : CShape
    {
        public CPoint Center { get; }
        public double Radius { get; }
        public int VertexCount { get; }
        public CRegularPolygon(CPoint center, double radius, int count, EColor color)
            : base(color)
        {
            Center = center;
            Radius = radius;
            VertexCount = count;
        }
        public override void Draw(ICanvas canvas)
        {
            canvas.Color = Color;
            double angle = 2 * Math.PI / VertexCount;
            var start = new CPoint(Center.X + Radius, Center.Y);
            for (int i = 0; i <= VertexCount; i++)
            {
                var end = new CPoint(Center.X + Radius * Math.Cos(angle * i), Center.Y + Radius * Math.Sin(angle * i));
                canvas.DrawLine(start, end);
                start = end;
            }
        }
    }
}
