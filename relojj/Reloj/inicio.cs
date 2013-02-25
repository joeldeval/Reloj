using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Reloj
{
    class inicio
    {
        public void MuestraMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Reloj");
            Console.WriteLine("2. Cronometro");


        }

        public void LeerEntrada(){
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                reloj Reloj = new reloj();
                Reloj.iniciar();
            }
            else
            {
                cronometro Cronometro = new cronometro();
                Cronometro.Iniciar();
            }
        }

        static void Main(string[] args)
        {
            inicio Inicio = new inicio();
            Inicio.MuestraMenu();
            Inicio.LeerEntrada();
        }
    }
}
