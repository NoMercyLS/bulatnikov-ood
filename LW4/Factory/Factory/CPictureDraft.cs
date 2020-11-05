using Factory.Shapes;
using System;
using System.Collections.Generic;

namespace Factory
{
    public class CPictureDraft
    {
        private readonly List<CShape> _shapes = new List<CShape>();
        public int GetShapesCount()
        {
            return _shapes.Count;
        }
        public void AddShape(CShape shape)
        {
            _shapes.Add(shape);
        }
        public CShape GetShapeByIndex(int index)
        {
            return (index < 0 || index >= _shapes.Count) ? 
                throw new ArgumentOutOfRangeException("Index is out of range") : _shapes[index];
        }
    }
}
