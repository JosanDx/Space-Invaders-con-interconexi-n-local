using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabSpaceInvaders
{
    abstract class Nave
    {

        public ConsoleColor Color;
        public Direccion direccion;
        public Posicion posicion;
        public int vida;
        public bala bala;

        public Nave(Posicion posini, Direccion dirini, ConsoleColor colorini, int vidaini)
        {
            posicion = posini;
            direccion = dirini;
            Color = colorini;
            vida = vidaini;
            bala = null;
        }
        public abstract void pintar();

        public void mover()
        {
            switch (direccion)
            {
                case Direccion.Derecha:
                    Console.SetCursorPosition(posicion.x - 1, posicion.y);
                    Console.Write(" ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 2);
                    Console.Write(" ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 3);
                    Console.Write(" ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 5);
                    Console.Write(" ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 6);
                    Console.Write(" ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 7);
                    Console.Write(" ");
                    
                    break;
                case Direccion.Izquierda:
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("                          ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 1);
                    Console.Write("                          ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 2);
                    Console.Write("                          ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 3);
                    Console.Write("                          ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 4);
                    Console.Write("                          ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 5);
                    Console.Write("                          ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 6);
                    Console.Write("                          ");
                    Console.SetCursorPosition(posicion.x - 1, posicion.y + 7);
                    Console.Write("                          ");
                    break;
                case Direccion.Arriba:
                    break;
                case Direccion.Abajo:
                    Console.SetCursorPosition(posicion.x, posicion.y-1);
                    Console.Write("                        ");
                    
                    
                    break;
            }
            pintar();
        }

        public void disparar(List<Nave> Objetivo,Direccion dirDisparo)
        {
            bala = new bala(new Posicion(posicion.x + 10, posicion.y - 1), Objetivo, dirDisparo);
        }

        public abstract void destruir();

        internal void herir()
        {
            ConsoleColor colorreal = Color;
            Color = ConsoleColor.Red;
            pintar();
            Thread.Sleep(100);
            Color = colorreal;
            pintar();
        }
    }
}
