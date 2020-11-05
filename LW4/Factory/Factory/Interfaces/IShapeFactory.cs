using Factory.Shapes;

namespace Factory.Interfaces
{
    public interface IShapeFactory
    {
        CShape CreateShape(string description);
    }
}
