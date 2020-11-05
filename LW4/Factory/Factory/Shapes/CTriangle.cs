using Factory.Enum;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Shapes
{
    public class CTriangle : CShape
    {
        public CPoint Vertex1 { get; }
        public CPoint Vertex2 { get; }
        public CPoint Vertex3 { get; }

        public CTriangle(CPoint vertex1, CPoint vertex2, CPoint vertex3, EColor color)
            : base(color)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.Color = Color;
            canvas.DrawLine(Vertex1, Vertex2);
            canvas.DrawLine(Vertex2, Vertex3);
            canvas.DrawLine(Vertex3, Vertex1);
        }
    }
}
