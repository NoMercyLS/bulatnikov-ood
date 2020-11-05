using Factory.Enum;
using Factory.Interfaces;

namespace Factory.Shapes
{
    public class CRectangle : CShape
    {
        public CPoint LeftTop { get; }
        public CPoint RightBottom { get; }
        public CRectangle(CPoint leftTop, CPoint rightBottom, EColor color)
            : base(color)
        {
            LeftTop = leftTop;
            RightBottom = rightBottom;
        }
        public override void Draw(ICanvas canvas)
        {
            var rightTop = new CPoint(RightBottom.X, LeftTop.Y);
            var leftBottom = new CPoint(LeftTop.X, RightBottom.Y);

            canvas.Color = Color;
            canvas.DrawLine(LeftTop, rightTop);
            canvas.DrawLine(rightTop, RightBottom);
            canvas.DrawLine(RightBottom, leftBottom);
            canvas.DrawLine(leftBottom, LeftTop);
        }
    }
}
