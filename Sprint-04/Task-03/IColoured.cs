using System;

namespace Task_03
{
    public enum ColourEnum
    {
        Red, 
        Green, 
        Blue
    }
    public interface IColoured
    {
        public ColourEnum Colour { get => ColourEnum.Red; }
    }
    public interface IDocument
    {

        static string defaultText = "Lorem ipsum";

        public int Pages { get => 0; set => Pages = value; }

        public string Name { get; set; }

        public void AddPages(int incrementPages)
        {
            this.Pages += incrementPages;
        }

        public void Rename(string Name) 
        {
            this.Name = Name;
        }
    }

    public class ColouredDocument : IDocument, IColoured
    {
        public ColouredDocument(ColourEnum colourEnum) 
        {
            this.colour = colourEnum;
        }

        public ColouredDocument() { }

        private ColourEnum colour;
        public ColourEnum Colour { get => this.colour; }

        public string Name { get; set; }

        public int Pages { get; set; }
    }

    public class Example
    {
        public static void Do() 
        {
            IDocument doc1 = new ColouredDocument();
            doc1.Name = "Document1";
            Console.WriteLine(doc1.Name);
            doc1.Rename("Document2");
            Console.WriteLine(doc1.Name);
        }
    }
}
