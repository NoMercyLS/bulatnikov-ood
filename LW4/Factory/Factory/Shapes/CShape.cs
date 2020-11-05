using Factory.Enum;
using Factory.Interfaces;

namespace Factory.Shapes
{
    public abstract class CShape
    {
        public EColor Color { get; }
        public CShape(EColor color)
        {
            Color = color;
        }
        public abstract void Draw(ICanvas canvas);

    }
}
