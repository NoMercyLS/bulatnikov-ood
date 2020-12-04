using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adapter.ModernGraphicsLib
{
    public class ModernGraphicsRenderer
    {
        private readonly TextWriter _textWriter;
        private bool _drawingStatus;

        public ModernGraphicsRenderer(TextWriter textWriter)
        {
            _textWriter = textWriter;
        }

        public void BeginDraw()
        {
            if (_drawingStatus)
            {
                throw new Exception("Already drawing!");
            }
            _textWriter.WriteLine("<draw>");
            _drawingStatus = true;
        }

        public void EndDraw()
        {
            if (!_drawingStatus)
            {
                throw new Exception("Not drawing already");
            }
            _textWriter.WriteLine("</draw>");
            _drawingStatus = false;
        }

        public void DrawLine(Point start, Point end, RGBAColor color)
        {
            if (!_drawingStatus)
            {
                throw new Exception("Drawing allowed only when drawing started. Use BeginDraw()");
            }
            _textWriter.WriteLine($"  <line fromX={start.X} fromY={start.Y} toX={end.X} toY={end.Y}>");
            _textWriter.WriteLine($"    <color r={color.R} g={color.G} b={color.B} a={color.A}/>");
            _textWriter.WriteLine("  </line>");
        }
    }
}
