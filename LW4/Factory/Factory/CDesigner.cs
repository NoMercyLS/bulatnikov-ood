using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Factory
{
    public class CDesigner
    {
        private readonly IShapeFactory _factory;
        public CDesigner(IShapeFactory factory)
        {
            _factory = factory;
        }
        public CPictureDraft CreateDraft(TextReader inputData)
        {
            CPictureDraft draft = new CPictureDraft();
            string line;
            while ((line = inputData.ReadLine()) != null && line != "exit")
            {
                try
                {
                    draft.AddShape(_factory.CreateShape(line));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }
            return draft;
        }
    }
}
