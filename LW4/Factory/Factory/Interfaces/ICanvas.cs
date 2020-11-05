using Factory.Enum;
using Factory.Shapes;

namespace Factory.Interfaces
{
    public interface ICanvas
    {
        EColor Color { get; set; }
        void DrawLine(CPoint from, CPoint to);
        void DrawEllipse(CPoint center, double w, double h);

    }
}
