using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public sealed class CajeroAuto
    {

        public int opc { get; set; }
        public int Pesos { get; set; }

        public int contador { get; set; } = 0;

        

        private CajeroAuto()
        {
           
        
        }
        public void Menu()
        {
            Console.Write("*****************\n");
            Console.WriteLine("[1]Modo Dispensacion\n[2]Retirar Dinero\n[3]Salir");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Dispensacion();
                    break;
                case 2:
                    Retirar();
                    break;
                case 3:
                    Salir();
                    break;
                default:
                    Console.WriteLine("Incorrecto intente otra vez");
                    Menu();
                    Console.ReadKey();
                    break;


            }
        }
        public void Dispensacion()
        {
            Console.Write("**************\n");
            Console.WriteLine("[1]200\n[2]1000\n[3]100\n[4]Modo Eficiente\n[5]Volver\n");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1: Console.WriteLine("Acaba de recibir 200 pesos");
                    break;
                case 2: Console.WriteLine("Acaba de recibir 1000 pesos");
                    break;
                case 3: Console.WriteLine("Acaba de recibir 100 pesos");
                    break;
                case 4: Console.WriteLine();
                    break;
                default: Console.WriteLine("Intentar de nuevo");
                    Dispensacion();
                    break;
                        
            }
        }
        public void Salir()
        {
            Environment.Exit(0);
        }
        public void Retirar()
        {
            Console.Write("***********\n");
            Console.WriteLine("Cuanto desea retirar");
            Pesos = Convert.ToInt32(Console.ReadLine());
            if (contador == 1)
            {
               Console.WriteLine("El cajero le dio 1 papeletas de " + Pesos);
            }
        }
    }
}
