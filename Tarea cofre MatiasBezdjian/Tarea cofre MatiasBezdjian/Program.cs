using System;

namespace Tarea_cofre_MatiasBezdjian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CofreMadera cofre = new CofreMadera();

            int oroDado = cofre.Abrir();
            Console.WriteLine("Encontraste " + oroDado + " de oro.");
        }
    }

    class CofreMadera
    {
        public int Oro = 75;
        public bool abierto = false;

        public int Abrir()
        {
            if (abierto == false)
            {
                abierto = true;
                return Oro;
            }
            else
            {
                return 0;
            }
        }
    }
}
