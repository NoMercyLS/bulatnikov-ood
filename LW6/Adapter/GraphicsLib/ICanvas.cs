using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GraphicsLib
{
    public interface ICanvas
    {
        void SetColor(uint rgbColor);
        void MoveTo(int x, int y);
        void LineTo(int x, int y);
    }
}
