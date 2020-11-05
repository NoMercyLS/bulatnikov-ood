using Factory;
using Factory.Enum;
using Factory.Interfaces;
using System;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Visualization
{
    public class CCanvas : ICanvas
    {
        public Factory.Enum.EColor Color { get; set; }
        private readonly System.Windows.Controls.Canvas _canvas;
        public CCanvas(System.Windows.Controls.Canvas canvas)
        {
            _canvas = canvas;
        }
        public void DrawLine(Factory.Shapes.CPoint from, Factory.Shapes.CPoint to)
        {
            var line = new Line
            {
                X1 = from.X,
                Y1 = from.Y,
                X2 = to.X,
                Y2 = to.Y,
                Stroke = ToColor()
            };
            _canvas.Children.Add(line);
        }
        public void DrawEllipse(Factory.Shapes.CPoint center, double w, double h)
        {
            var ellipse = new Ellipse
            {
                Width = w,
                Height = h,
                Stroke = ToColor()
            };
            System.Windows.Controls.Canvas.SetLeft(ellipse, center.X - w / 2);
            System.Windows.Controls.Canvas.SetTop(ellipse, center.Y - h / 2);
            _canvas.Children.Add(ellipse);
        }
        private SolidColorBrush ToColor()
        {
            return Color switch
            {
                EColor.Green => Brushes.Green,
                EColor.Red => Brushes.Red,
                EColor.Blue => Brushes.Blue,
                EColor.Yellow => Brushes.Yellow,
                EColor.Pink => Brushes.Pink,
                EColor.Black => Brushes.Black,
                _ => throw new Exception("Incorrect color. You can choose color from [green, red, blue, yellow, pink, black]")
            };
        }
    }
}
