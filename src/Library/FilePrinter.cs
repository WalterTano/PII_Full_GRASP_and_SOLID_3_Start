using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public FilePrinter(){
        }
        public void Print(string text){
            File.WriteAllText("Recipe.txt", text);
        }
    }
}