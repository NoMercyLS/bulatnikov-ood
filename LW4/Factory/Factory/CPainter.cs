using Factory.Interfaces;

namespace Factory
{
    public class CPainter
    {
        public void DrawPicture(CPictureDraft draft, ICanvas canvas)
        {
            for (int i = 0; i < draft.GetShapesCount(); i++)
            {
                var shape = draft.GetShapeByIndex(i);
                shape.Draw(canvas);
            }
        }
    }
}
