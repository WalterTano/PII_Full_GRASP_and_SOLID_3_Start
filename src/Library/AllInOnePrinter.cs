//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class AllInOnePrinter
    {
        /*
        Para esta solución, hicimos uso de más de un patrón de diseño SOLID:
        1. Usamos SRP, para asignarle la responsabilidad única de impresión por plataforma a
        cada clase correspondiente a cada plataforma de impresión (ConsolePrinter y FilePrinter).
        De esta forma, si es necesario cambiar la impresión en alguna de las plataformas, solo
        debemos modificar la clase correspondiente.
        2. Usamos LSP en nuestra implementación de la interfaz IPrinter, de modo que el texto de
        la receta (el resultado) no se verá afectado, sin importar el subtipo de impresora que 
        realice la impresión.
        */
        public void PrintRecipe(Recipe recipe, IPrinter printer)
        {
            printer.Print(recipe.GetTextToPrint());
        }
    }
}