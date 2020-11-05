using Factory.Enum;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Shapes
{
    public class CEllipse : CShape
    {
        public CPoint Center { get; }
        public double HorizontalRadius { get; }
        public double VerticalRadius { get; }
        public CEllipse(CPoint center, double horizontalRadius, double verticalRadius, EColor color)
            : base(color)
        {
            Center = center;
            HorizontalRadius = horizontalRadius;
            VerticalRadius = verticalRadius;
        }
        public override void Draw(ICanvas canvas)
        {
            canvas.Color = Color;
            canvas.DrawEllipse(Center, HorizontalRadius * 2, VerticalRadius * 2);
        }
    }
}
