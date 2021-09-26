using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public ConsolePrinter(){
        }
        public void Print(string text){
            System.Console.WriteLine(text);
        }
    }
}