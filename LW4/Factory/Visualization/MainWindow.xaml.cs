using Factory;
using System;
using System.IO;
using System.Windows;


namespace Visualization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Drawing()
        {
            var factory = new CShapeFactory();
            var designer = new CDesigner(factory);
            var wCanvas = (System.Windows.Controls.Canvas)FindName("canvas");
            var canvas = new CCanvas(wCanvas);
            var painter = new CPainter();

            Console.WriteLine("Enter commands to draw shapes. Enter 'exit' to see the result");
            Console.WriteLine("Usage: RegularPolygon <color> <center> <radius> <vertexCount>");
            Console.WriteLine("Usage: Triangle <color> <vertex1> <vertex2> <vertex3>");
            Console.WriteLine("Usage: Rectangle <color> <leftTop> <rightBottom>");
            Console.WriteLine("Usage: Ellipse <color> <center> <horisontalRadius> <verticalRadius>");
            var draft = designer.CreateDraft(new StreamReader("../../../in.txt"));
            painter.DrawPicture(draft, canvas);
        }
        public MainWindow()
        {
            InitializeComponent();
            Drawing();
        }
    }
}
