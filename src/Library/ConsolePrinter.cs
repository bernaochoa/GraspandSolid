using System;

namespace Library
{
    public class ConsolePrinter : IPrinter
    {
        // Ahora recibe un IPrintable en lugar de Recipe
        public void PrintRecipe(IPrintable printable)
        {
            Console.WriteLine(printable.GetTextToPrint());
        }
    }
}