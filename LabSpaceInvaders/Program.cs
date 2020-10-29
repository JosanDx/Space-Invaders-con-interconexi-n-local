using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Juego mijuego = new Juego();
            int seleccion = 0;
            while (seleccion != 3)
            {
                seleccion = mijuego.seleccionar(4,1);
                //Borrar pantalla
                //////////////////////////////////////////////
                Console.Clear();
                //////////////////////////////////////////////
                switch (seleccion)
                {
                    case 0:
                        mijuego.crearpartida();
                        break;
                    case 1:
                        mijuego.unirseapartida();
                        break;
                    case 2:
                        mijuego.configurarOpciones();
                        break;
                }
            }
        }
    }
}
