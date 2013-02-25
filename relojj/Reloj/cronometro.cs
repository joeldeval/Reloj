using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Reloj
{
    class cronometro
    {
        public void Iniciar()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    for (int k = 0; k < 60; k++)
                    {
                        if (k < 10)
                        {

                            Console.WriteLine("" + i+ ":" + j + ":0" + k);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }else
                        if (j < 10)
                        {

                            Console.WriteLine("" + i + ":0" + j + ":" + k);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }else
                        if (i < 10)
                        {

                            Console.WriteLine("0" + i + ":" + j + ":" + k);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine(i + ":" + j + ":" + k);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }

                    }
                }

            }
        }

    }
}
