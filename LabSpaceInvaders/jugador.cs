using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSpaceInvaders
{
    class jugador : Nave
    {
        public jugador(Posicion posini, Direccion dirini, ConsoleColor colorini, int vidaini) : base(posini, dirini, colorini, vidaini)
        {
            posicion = posini;
            direccion = dirini;
            Color = colorini;
            vida = vidaini;
        }
        public override void pintar()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(posicion.x, posicion.y);
            Console.Write("           ██");
            Console.SetCursorPosition(posicion.x, posicion.y + 1);
            Console.Write("           ██");
            Console.SetCursorPosition(posicion.x, posicion.y + 2);
            Console.Write("      ████████████");
            Console.SetCursorPosition(posicion.x, posicion.y + 3);
            Console.Write("    ████████████████");
            Console.SetCursorPosition(posicion.x, posicion.y + 4);
            Console.Write("  ██  ██  ████  ██  ██");
            Console.SetCursorPosition(posicion.x, posicion.y + 5);
            Console.Write("████████████████████████");
            Console.SetCursorPosition(posicion.x, posicion.y + 6);
            Console.Write("    ████  ████  ████");
            Console.SetCursorPosition(posicion.x, posicion.y + 7);
            Console.Write("     ██          ██");
        }
        public override void destruir()
        {
            Console.SetCursorPosition(posicion.x, posicion.y);
            Console.Write("             ");
            Console.SetCursorPosition(posicion.x, posicion.y + 1);
            Console.Write("             ");
            Console.SetCursorPosition(posicion.x, posicion.y + 2);
            Console.Write("                  ");
            Console.SetCursorPosition(posicion.x, posicion.y + 3);
            Console.Write("                    ");
            Console.SetCursorPosition(posicion.x, posicion.y + 4);
            Console.Write("                      ");
            Console.SetCursorPosition(posicion.x, posicion.y + 5);
            Console.Write("                         ");
            Console.SetCursorPosition(posicion.x, posicion.y + 6);
            Console.Write("                    ");
            Console.SetCursorPosition(posicion.x, posicion.y + 7);
            Console.Write("                   ");
        }
    }
}
