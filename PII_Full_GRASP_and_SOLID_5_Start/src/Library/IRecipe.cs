//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

//Creamos la interfaz con el método GetTextToPrint()
namespace Full_GRASP_And_SOLID
{
    public interface IRecipe
    {
        public string GetTextToPrint();
    }
}

//Modifiqué las clases ConsolePrinter y FilePrinter para implementar la interfaz IRecipe y también la interfaz IPrinter.
// Ahora si se cumple el principio de Inversión de dependencias, y el programa es más flexible.