//-------------------------------------------------------------------------------
// <copyright file="BaseStep.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Library
{
    // Agreada por OCP
    public abstract class BaseStep
    {
        public BaseStep(int time)
        {
            this.Time = time;
        }

        public int Time { get; set; }

        public abstract double GetStepCost();

        public abstract string GetTextToPrint();
    }
}