using System.IO;

namespace Library
{
    public class FilePrinter : IPrinter
    {
        // Cambiar Recipe por IPrintable
        public void PrintRecipe(IPrintable printable)
        {
            // Imprimir el texto usando el método de la interfaz
            File.WriteAllText("Recipe.txt", printable.GetTextToPrint());
        }
    }
}