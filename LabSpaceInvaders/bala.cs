using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSpaceInvaders
{
    class bala
    {
        public Posicion posicion;
        List<Nave> Objetivo;
        Direccion dirDisparo;
        public bala(Posicion posini, List<Nave> Obj, Direccion dirDisp)
        {
            posicion = posini;
            Objetivo = Obj;
            dirDisparo = dirDisp;
        }
        public void mover()
        {
            Console.SetCursorPosition(posicion.x, posicion.y);
            Console.Write(" ");
            if (dirDisparo == Direccion.Arriba)
            {
                posicion.y--;
            }
            else
            {
                posicion.y++;
            }

            pintar();
        }

        public Posicion verificarImpacto()
        {
            Posicion resultado = null;
            if (posicion.y == 1)
            {
                resultado = posicion;
            }
            Nave naveresult = Objetivo.Find(e => (posicion.x >= e.posicion.x && posicion.x < e.posicion.x + 26) && (posicion.y >= e.posicion.y && posicion.y < e.posicion.y + 7));
            if (naveresult != null)
            {
                resultado = naveresult.posicion;
            }
            return resultado;
        }

        public void pintar()
        {
            Console.SetCursorPosition(posicion.x, posicion.y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
        }

        internal void destruir()
        {
            Console.SetCursorPosition(posicion.x, posicion.y);
            Console.Write(" ");
        }
    }
}
