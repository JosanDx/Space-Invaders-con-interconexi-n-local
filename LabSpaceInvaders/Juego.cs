using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LabSpaceInvaders
{
    class Juego
    {
        public int Nivel{ get; set; }
        public int velocidad { get; set; }

        public List<List<Nave>> Enemigos;
        public List<Nave> Jugadores;

        
        public Juego()
        {
            Nivel = 1;
            velocidad = 1;
            Enemigos = new List<List<Nave>>();
            Jugadores = new List<Nave>();
        }

        public string ObtenerIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        }
        public int seleccionar(int numeroOpciones,int opciones)
        {

            pintarmenu();
            pintaropciones(opciones);
            int respuesta = 0;
            ConsoleKey tecla = ConsoleKey.A;
            int x = 108, y = 76;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write("##    ##    ##    ");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" ##    ##    ##   ");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("  ##    ##    ##  ");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("   ##    ##    ## ");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("  ##    ##    ##  ");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" ##    ##    ##   ");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("##    ##    ##    ");

            while (tecla != ConsoleKey.Enter)
            {
                tecla = Console.ReadKey().Key;
                
                switch (tecla)
                {
                    case ConsoleKey.UpArrow:
                        y -= 6;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        respuesta--;
                        if (respuesta < 0)
                        {
                            respuesta = numeroOpciones-1;

                            y = 76 + (10* (numeroOpciones-1));
                            Console.SetCursorPosition(x, y);
                            Console.Write("##    ##    ##    ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ##    ##    ##   ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("  ##    ##    ##  ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("   ##    ##    ## ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("  ##    ##    ##  ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ##    ##    ##   ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("##    ##    ##    ");
                        }
                        else
                        {
                            y -= 16;
                            Console.SetCursorPosition(x, y);
                            Console.Write("##    ##    ##    ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ##    ##    ##   ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("  ##    ##    ##  ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("   ##    ##    ## ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("  ##    ##    ##  ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ##    ##    ##   ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("##    ##    ##    ");
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        y -= 6;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write("                  ");
                        respuesta++;
                        
                        if (respuesta > numeroOpciones-1)
                        {
                            respuesta = 0;
                            

                            y = 76;
                            Console.SetCursorPosition(x, y);
                            Console.Write("##    ##    ##    ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ##    ##    ##   ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("  ##    ##    ##  ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("   ##    ##    ## ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("  ##    ##    ##  ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ##    ##    ##   ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("##    ##    ##    ");
                        }
                        else
                        {
                            y += 4;
                            Console.SetCursorPosition(x, y);
                            Console.Write("##    ##    ##    ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ##    ##    ##   ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("  ##    ##    ##  ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("   ##    ##    ## ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("  ##    ##    ##  ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ##    ##    ##   ");
                            y++;
                            Console.SetCursorPosition(x, y);
                            Console.Write("##    ##    ##    ");
                        }
                        break;
                }
            }
            return respuesta;
        }

        public void crearpartida()
        {
            int seleccion = 0;
            while (seleccion != 2)
            {
                seleccion = seleccionar(3, 2);
                Console.Clear();
                switch (seleccion)
                {
                    case 0:
                        jugar(1);
                        break;
                    case 1:
                        jugar(2);
                        break;
                }
                seleccion = 2;
            }
        }

        public void jugar(int mododejuego)
        {
            //Crear primer enemigo
            Enemigos.Add(new List<Nave>());
            Enemigos[0].Add((new EnemOctopus(new Posicion(10, 5), Direccion.Derecha, ConsoleColor.DarkMagenta, 1 * Nivel)));

            
            switch (mododejuego)
            {
                case 1: //jugar solo
                    {
                        foreach (var enemigo in Enemigos[0])
                        {
                            enemigo.pintar();
                        }
                        Jugadores.Add(new jugador(new Posicion(10, 130), Direccion.Derecha, ConsoleColor.Blue, 3));
                        Jugadores[0].pintar();
                        ConsoleKey tecla = ConsoleKey.A;
                        int conteo = 0, conteo2 = 0, conteo3 = 0;
                        int valor = 0;
                        bool salir = false;
                        if (velocidad == 1)
                        {
                            valor = 2000;
                        }
                        else if (velocidad == 2)
                        {
                            valor = 1000;
                        }
                        else
                        {
                            valor = 100;
                        }

                        List<int> crearnuevobicho = new List<int>();
                        List<bool> pintarbichos = new List<bool>();
                        crearnuevobicho.Add(0);
                        pintarbichos.Add(true);
                        int totalbichos = 4, tipobicho = 0;
                        var rand = new Random();
                        int aleatoriodisparo = rand.Next(30, 100);
                        int valoraleatorio = 0;
                        while (Jugadores[0].vida > 0 && salir == false)
                        {

                            //Eliminar listas vacias
                            var eliminar = Enemigos.Find(l => l.Count() == 0);
                            var eliminarindex = Enemigos.FindIndex(l => l.Count() == 0);
                            if (eliminar != null)
                            {
                                Enemigos.Remove(eliminar);
                                crearnuevobicho.RemoveAt(eliminarindex);
                                pintarbichos.RemoveAt(eliminarindex);
                            }
                            ///////////////////////////////////////

                            //verificar si alguna nave tocó el límite
                            foreach (var listaEnemigos in Enemigos)
                            {
                                foreach (var enemigo in listaEnemigos)
                                {
                                    Nave comp = listaEnemigos.Find(e => enemigo.posicion.y + 10 == e.posicion.y);
                                    if (comp == null)
                                    {
                                        if (enemigo.posicion.y > 100)
                                        {
                                            salir = true;
                                        }
                                    }
                                }
                            }


                            //////////////////////////////////////////
                            conteo++;
                            if (conteo > valor)
                            {
                                //Generar disparo aleatorio
                                valoraleatorio++;
                                if (valoraleatorio == aleatoriodisparo)
                                {
                                    valoraleatorio = 0;
                                    aleatoriodisparo = rand.Next(30, 100);
                                    int aleatoriolista = rand.Next(0, Enemigos.Count());
                                    int aleatorionave = rand.Next(0, Enemigos[aleatoriolista].Count());

                                    if (Enemigos[aleatoriolista][aleatorionave].bala == null)
                                    {
                                        Enemigos[aleatoriolista][aleatorionave].disparar(Jugadores, Direccion.Abajo);
                                    }



                                }
                                ///////////////////////////////////
                                conteo = 0;
                                foreach (var listaEnemigos in Enemigos)
                                {
                                    foreach (var enemigo in listaEnemigos)
                                    {
                                        switch (enemigo.direccion)
                                        {
                                            case Direccion.Derecha:
                                                enemigo.posicion.x++;

                                                break;
                                            case Direccion.Izquierda:
                                                enemigo.posicion.x--;
                                                break;
                                            case Direccion.Abajo:
                                                enemigo.posicion.y++;
                                                enemigo.mover();
                                                if (listaEnemigos[listaEnemigos.Count() - 1].posicion.x == 10)
                                                {
                                                    enemigo.direccion = Direccion.Derecha;
                                                }
                                                else
                                                {
                                                    enemigo.direccion = Direccion.Izquierda;
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }

                                int cantbichos = 0;
                                foreach (var listaenemigos in Enemigos)
                                {
                                    if (pintarbichos[cantbichos] == true)
                                    {
                                        if (listaenemigos.Count() < totalbichos)
                                        {
                                            crearnuevobicho[cantbichos]++;
                                            if (crearnuevobicho[cantbichos] == 30)
                                            {
                                                crearnuevobicho[cantbichos] = 0;
                                                switch (tipobicho)
                                                {
                                                    case 0:
                                                        listaenemigos.Add(new EnemOctopus(new Posicion(10, 5), Direccion.Derecha, ConsoleColor.DarkMagenta, 1 * Nivel));
                                                        break;
                                                    case 1:
                                                        listaenemigos.Add(new EnemCrab(new Posicion(11, 5), Direccion.Derecha, ConsoleColor.Cyan, 2 * Nivel));
                                                        break;
                                                    case 2:
                                                        listaenemigos.Add(new EnemSquid(new Posicion(14, 5), Direccion.Derecha, ConsoleColor.Green, 3 * Nivel));
                                                        break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            pintarbichos[cantbichos] = false;
                                        }

                                    }

                                    cantbichos++;
                                }



                                foreach (var listaenemigos in Enemigos)
                                {
                                    if (listaenemigos[0].posicion.x > 370)
                                    {
                                        foreach (var enemigo in listaenemigos)
                                        {
                                            enemigo.posicion.x--;
                                            enemigo.direccion = Direccion.Abajo;
                                        }

                                    }
                                    else if (listaenemigos[listaenemigos.Count() - 1].posicion.x < 10)
                                    {
                                        foreach (var enemigo in listaenemigos)
                                        {
                                            enemigo.posicion.x++;
                                            enemigo.direccion = Direccion.Abajo;
                                        }
                                    }
                                    else
                                    {
                                        foreach (var enemigo in listaenemigos)
                                        {
                                            enemigo.mover();
                                        }
                                    }

                                }



                            }

                            if (Enemigos[Enemigos.Count() - 1][0].posicion.x == 370 || Enemigos[Enemigos.Count() - 1].Count() == 0)
                            {
                                tipobicho++;
                                if (tipobicho >= 3)
                                {
                                    tipobicho = 0;
                                }
                                Enemigos.Add(new List<Nave>());
                                crearnuevobicho.Add(0);
                                pintarbichos.Add(true);
                                switch (tipobicho)
                                {
                                    case 0:
                                        Enemigos[Enemigos.Count() - 1].Add(new EnemOctopus(new Posicion(10, 5), Direccion.Derecha, ConsoleColor.DarkMagenta, 1 * Nivel));
                                        break;
                                    case 1:
                                        Enemigos[Enemigos.Count() - 1].Add(new EnemCrab(new Posicion(11, 5), Direccion.Derecha, ConsoleColor.Cyan, 2 * Nivel));
                                        break;
                                    case 2:
                                        Enemigos[Enemigos.Count() - 1].Add(new EnemSquid(new Posicion(14, 5), Direccion.Derecha, ConsoleColor.Green, 3 * Nivel));
                                        break;
                                }

                            }

                            if (Console.KeyAvailable == true)
                            {
                                tecla = Console.ReadKey().Key;
                                switch (tecla)
                                {
                                    case ConsoleKey.UpArrow: //disparar
                                        if (Jugadores[0].bala == null)
                                        {
                                            Jugadores[0].disparar(Enemigos, Direccion.Arriba);
                                        }
                                        break;
                                    case ConsoleKey.LeftArrow:
                                        Jugadores[0].posicion.x--;
                                        Jugadores[0].direccion = Direccion.Izquierda;
                                        if (Jugadores[0].posicion.x < 10)
                                        {
                                            Jugadores[0].posicion.x = 10;
                                        }
                                        Jugadores[0].mover();
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Jugadores[0].posicion.x++;
                                        Jugadores[0].direccion = Direccion.Derecha;
                                        if (Jugadores[0].posicion.x > 360)
                                        {
                                            Jugadores[0].posicion.x = 360;
                                        }
                                        Jugadores[0].mover();
                                        break;
                                }

                            }
                            else
                            {
                                tecla = ConsoleKey.A;
                            }

                            if (Jugadores[0].bala != null)
                            {
                                conteo2++;
                                if (conteo2 > 100)
                                {
                                    conteo2 = 0;
                                    Jugadores[0].bala.mover();
                                    Posicion impacto = Jugadores[0].bala.verificarImpacto();
                                    if (impacto != null)
                                    {
                                        Jugadores[0].bala.destruir();
                                        Jugadores[0].bala = null;

                                        foreach (var lista in Enemigos)
                                        {
                                            int resultado = lista.FindIndex(x => x.posicion.x == impacto.x && x.posicion.y == impacto.y);

                                            if (resultado != -1)
                                            {
                                                lista[resultado].vida--;
                                                if (lista[resultado].vida > 0)
                                                {
                                                    lista[resultado].herir();

                                                }
                                                else
                                                {
                                                    if (lista[resultado].bala != null)
                                                    {
                                                        lista[resultado].bala.destruir();
                                                        lista[resultado].bala = null;
                                                    }
                                                    lista[resultado].destruir();
                                                    lista.Remove(lista[resultado]);
                                                }
                                                break;

                                            }
                                        }

                                    }
                                }

                            }

                            foreach (var lista in Enemigos)
                            {
                                foreach (var enemigo in lista)
                                {
                                    if (enemigo.bala != null)
                                    {
                                        conteo3++;
                                        if (conteo3 > 600)
                                        {
                                            conteo3 = 0;
                                            enemigo.bala.mover();
                                            Posicion impacto = enemigo.bala.verificarImpacto();
                                            if (impacto != null)
                                            {
                                                enemigo.bala.destruir();
                                                enemigo.bala = null;


                                                int resultado = Jugadores.FindIndex(x => x.posicion.x == impacto.x && x.posicion.y == impacto.y);

                                                if (resultado != -1)
                                                {
                                                    Jugadores[resultado].vida--;
                                                    if (Jugadores[resultado].vida > 0)
                                                    {
                                                        Jugadores[resultado].herir();

                                                    }
                                                    else
                                                    {
                                                        Jugadores[resultado].destruir();
                                                        Jugadores.Remove(lista[resultado]);
                                                    }
                                                    break;

                                                }


                                            }
                                        }
                                    }
                                }
                            }

                        }
                        Console.Clear();
                        //perdiste
                        break;
                    }
                case 2:  //jugar interconexion
                    {


                        pintarmenu();
                        pintaropciones(4);

                        //Sockets
                        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        IPEndPoint Ip = new IPEndPoint(IPAddress.Any, 1234);
                        server.Bind(Ip);
                        server.Listen(1);
                        Socket cliente = server.Accept();
                        /////////////////////////////////////////////
                        Console.Clear();


                        foreach (var enemigo in Enemigos[0])
                        {
                            enemigo.pintar();
                        }
                        Jugadores.Add(new jugador(new Posicion(10, 130), Direccion.Derecha, ConsoleColor.Blue, 3));
                        Jugadores.Add(new jugador(new Posicion(350, 130), Direccion.Derecha, ConsoleColor.Green, 3));
                        Jugadores[0].pintar();
                        Jugadores[1].pintar();
                        ConsoleKey tecla = ConsoleKey.A;
                        int conteo = 0, conteo2 = 0, conteo3 = 0,conteo4 = 0;
                        int valor = 0;
                        bool salir = false;
                        if (velocidad == 1)
                        {
                            valor = 2000;
                        }
                        else if (velocidad == 2)
                        {
                            valor = 1000;
                        }
                        else
                        {
                            valor = 100;
                        }

                        List<int> crearnuevobicho = new List<int>();
                        List<bool> pintarbichos = new List<bool>();
                        crearnuevobicho.Add(0);
                        pintarbichos.Add(true);
                        int totalbichos = 4, tipobicho = 0;
                        var rand = new Random();
                        int aleatoriodisparo = rand.Next(30, 100);
                        int valoraleatorio = 0;
                        byte[] textoEnviar = null;
                        while ((Jugadores[0].vida > 0 || Jugadores[1].vida > 0) && salir == false)
                        {

                            //Enviar info al cliente
                            string dato = "";
                            foreach (var lista in Enemigos)
                            {
                                foreach (var enemigo in lista)
                                {
                                    switch (enemigo.Color)
                                    {
                                        case ConsoleColor.Green:
                                            dato += "Squid";
                                            break;
                                        case ConsoleColor.Cyan:
                                            dato += "Crab";
                                            break;
                                        case ConsoleColor.DarkMagenta:
                                            dato += "Octopus";
                                            break;
                                    }
                                    dato += "-";
                                    dato += enemigo.posicion.x.ToString() + "-" + 
                                            enemigo.posicion.y.ToString() + "-" +
                                            enemigo.vida.ToString();
                                    if (enemigo.bala == null)
                                    {
                                        dato += "-null";
                                    }
                                    else
                                    {
                                        dato += "-" + enemigo.bala.posicion.x.ToString() + "_" +
                                                      enemigo.bala.posicion.y.ToString();
                                    }

                                    dato += ",";

                                }
                            }
                            dato += ";";
                            
                            if (Jugadores[0].vida > 0)
                            {
                                dato += Jugadores[0].posicion.x.ToString() + "-" +
                                        Jugadores[0].vida.ToString() + "-";
                                if (Jugadores[0].bala != null)
                                {
                                    dato += Jugadores[0].bala.posicion.x.ToString() + "_" +
                                           Jugadores[0].bala.posicion.y.ToString();
                                }
                                else
                                {
                                    dato += "null";
                                }

                            }
                            else
                            {
                                dato += "null";
                            }

                            dato += ";";
                            if (Jugadores[1].vida > 0)
                            {
                                dato += Jugadores[1].posicion.x.ToString() + "-" +
                                        Jugadores[1].vida.ToString() + "-";
                                if (Jugadores[1].bala != null)
                                {
                                    dato += Jugadores[1].bala.posicion.x.ToString() + "_" +
                                           Jugadores[1].bala.posicion.y.ToString();
                                }
                                else
                                {
                                    dato += "null";
                                }

                            }
                            else
                            {
                                dato += "null";
                            }
                            dato += ";";

                            textoEnviar = Encoding.Default.GetBytes(dato);
                            cliente.Send(textoEnviar, 0, textoEnviar.Length, 0);
                            textoEnviar = null;


                            //Mover bichito 2
                            byte[] clienteRec = new byte[50000];
                            int a = cliente.Receive(clienteRec, 0, clienteRec.Length, 0);

                            string datorcb = Encoding.Default.GetString(clienteRec, 0, a);
                            if (Jugadores[1].vida > 0)
                            {
                                switch (datorcb)
                                {
                                    case "arriba": //disparar
                                        if (Jugadores[1].bala == null)
                                        {
                                            Jugadores[1].disparar(Enemigos, Direccion.Arriba);
                                        }
                                        break;
                                    case "izquierda":
                                        Jugadores[1].posicion.x--;
                                        Jugadores[1].direccion = Direccion.Izquierda;
                                        if (Jugadores[1].posicion.x < 10)
                                        {
                                            Jugadores[1].posicion.x = 10;
                                        }
                                        Jugadores[1].mover();
                                        break;
                                    case "derecha":
                                        Jugadores[1].posicion.x++;
                                        Jugadores[1].direccion = Direccion.Derecha;
                                        if (Jugadores[1].posicion.x > 360)
                                        {
                                            Jugadores[1].posicion.x = 360;
                                        }
                                        Jugadores[1].mover();
                                        break;
                                }
                            }


                            ///////////////////////////////////////////////////

                            //Eliminar listas vacias
                            var eliminar = Enemigos.Find(l => l.Count() == 0);
                            var eliminarindex = Enemigos.FindIndex(l => l.Count() == 0);
                            if (eliminar != null)
                            {
                                Enemigos.Remove(eliminar);
                                crearnuevobicho.RemoveAt(eliminarindex);
                                pintarbichos.RemoveAt(eliminarindex);
                            }
                            ///////////////////////////////////////

                            //verificar si alguna nave tocó el límite
                            foreach (var listaEnemigos in Enemigos)
                            {
                                foreach (var enemigo in listaEnemigos)
                                {
                                    Nave comp = listaEnemigos.Find(e => enemigo.posicion.y + 10 == e.posicion.y);
                                    if (comp == null)
                                    {
                                        if (enemigo.posicion.y > 100)
                                        {
                                            salir = true;
                                        }
                                    }
                                }
                            }


                            //////////////////////////////////////////
                            conteo++;
                            if (conteo > valor)
                            {
                                //Generar disparo aleatorio
                                valoraleatorio++;
                                if (valoraleatorio == aleatoriodisparo)
                                {
                                    valoraleatorio = 0;
                                    aleatoriodisparo = rand.Next(30, 100);
                                    int aleatoriolista = rand.Next(0, Enemigos.Count());
                                    int aleatorionave = rand.Next(0, Enemigos[aleatoriolista].Count());

                                    if (Enemigos[aleatoriolista][aleatorionave].bala == null)
                                    {
                                        Enemigos[aleatoriolista][aleatorionave].disparar(Jugadores, Direccion.Abajo);
                                    }



                                }
                                ///////////////////////////////////
                                conteo = 0;
                                foreach (var listaEnemigos in Enemigos)
                                {
                                    foreach (var enemigo in listaEnemigos)
                                    {
                                        switch (enemigo.direccion)
                                        {
                                            case Direccion.Derecha:
                                                enemigo.posicion.x++;

                                                break;
                                            case Direccion.Izquierda:
                                                enemigo.posicion.x--;
                                                break;
                                            case Direccion.Abajo:
                                                enemigo.posicion.y++;
                                                enemigo.mover();
                                                if (listaEnemigos[listaEnemigos.Count() - 1].posicion.x == 10)
                                                {
                                                    enemigo.direccion = Direccion.Derecha;
                                                }
                                                else
                                                {
                                                    enemigo.direccion = Direccion.Izquierda;
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }

                                int cantbichos = 0;
                                foreach (var listaenemigos in Enemigos)
                                {
                                    if (pintarbichos[cantbichos] == true)
                                    {
                                        if (listaenemigos.Count() < totalbichos)
                                        {
                                            crearnuevobicho[cantbichos]++;
                                            if (crearnuevobicho[cantbichos] == 30)
                                            {
                                                crearnuevobicho[cantbichos] = 0;
                                                switch (tipobicho)
                                                {
                                                    case 0:
                                                        listaenemigos.Add(new EnemOctopus(new Posicion(10, 5), Direccion.Derecha, ConsoleColor.DarkMagenta, 1 * Nivel));
                                                        break;
                                                    case 1:
                                                        listaenemigos.Add(new EnemCrab(new Posicion(11, 5), Direccion.Derecha, ConsoleColor.Cyan, 2 * Nivel));
                                                        break;
                                                    case 2:
                                                        listaenemigos.Add(new EnemSquid(new Posicion(14, 5), Direccion.Derecha, ConsoleColor.Green, 3 * Nivel));
                                                        break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            pintarbichos[cantbichos] = false;
                                        }

                                    }

                                    cantbichos++;
                                }



                                foreach (var listaenemigos in Enemigos)
                                {
                                    if (listaenemigos[0].posicion.x > 370)
                                    {
                                        foreach (var enemigo in listaenemigos)
                                        {
                                            enemigo.posicion.x--;
                                            enemigo.direccion = Direccion.Abajo;
                                        }

                                    }
                                    else if (listaenemigos[listaenemigos.Count() - 1].posicion.x < 10)
                                    {
                                        foreach (var enemigo in listaenemigos)
                                        {
                                            enemigo.posicion.x++;
                                            enemigo.direccion = Direccion.Abajo;
                                        }
                                    }
                                    else
                                    {
                                        foreach (var enemigo in listaenemigos)
                                        {
                                            enemigo.mover();
                                        }
                                    }

                                }



                            }

                            if (Enemigos[Enemigos.Count() - 1][0].posicion.x == 370 || Enemigos[Enemigos.Count() - 1].Count() == 0)
                            {
                                tipobicho++;
                                if (tipobicho >= 3)
                                {
                                    tipobicho = 0;
                                }
                                Enemigos.Add(new List<Nave>());
                                crearnuevobicho.Add(0);
                                pintarbichos.Add(true);
                                switch (tipobicho)
                                {
                                    case 0:
                                        Enemigos[Enemigos.Count() - 1].Add(new EnemOctopus(new Posicion(10, 5), Direccion.Derecha, ConsoleColor.DarkMagenta, 1 * Nivel));
                                        break;
                                    case 1:
                                        Enemigos[Enemigos.Count() - 1].Add(new EnemCrab(new Posicion(11, 5), Direccion.Derecha, ConsoleColor.Cyan, 2 * Nivel));
                                        break;
                                    case 2:
                                        Enemigos[Enemigos.Count() - 1].Add(new EnemSquid(new Posicion(14, 5), Direccion.Derecha, ConsoleColor.Green, 3 * Nivel));
                                        break;
                                }

                            }

                            
                            if (Console.KeyAvailable == true)
                            {
                                tecla = Console.ReadKey().Key;
                                if (Jugadores[0].vida > 0)
                                {
                                    switch (tecla)
                                    {
                                        case ConsoleKey.UpArrow: //disparar
                                            if (Jugadores[0].bala == null)
                                            {
                                                Jugadores[0].disparar(Enemigos, Direccion.Arriba);
                                            }
                                            break;
                                        case ConsoleKey.LeftArrow:
                                            Jugadores[0].posicion.x--;
                                            Jugadores[0].direccion = Direccion.Izquierda;
                                            if (Jugadores[0].posicion.x < 10)
                                            {
                                                Jugadores[0].posicion.x = 10;
                                            }
                                            Jugadores[0].mover();
                                            break;
                                        case ConsoleKey.RightArrow:
                                            Jugadores[0].posicion.x++;
                                            Jugadores[0].direccion = Direccion.Derecha;
                                            if (Jugadores[0].posicion.x > 360)
                                            {
                                                Jugadores[0].posicion.x = 360;
                                            }
                                            Jugadores[0].mover();
                                            break;
                                    }
                                }
                                    

                            }
                            else
                            {
                                tecla = ConsoleKey.A;
                            }
                            
                            

                            if (Jugadores[0].bala != null)
                            {
                                conteo2++;
                                if (conteo2 > 100)
                                {
                                    conteo2 = 0;
                                    Jugadores[0].bala.mover();
                                    Posicion impacto = Jugadores[0].bala.verificarImpacto();
                                    if (impacto != null)
                                    {
                                        Jugadores[0].bala.destruir();
                                        Jugadores[0].bala = null;

                                        foreach (var lista in Enemigos)
                                        {
                                            int resultado = lista.FindIndex(x => x.posicion.x == impacto.x && x.posicion.y == impacto.y);

                                            if (resultado != -1)
                                            {
                                                lista[resultado].vida--;
                                                if (lista[resultado].vida > 0)
                                                {
                                                    lista[resultado].herir();

                                                }
                                                else
                                                {
                                                    if (lista[resultado].bala != null)
                                                    {
                                                        lista[resultado].bala.destruir();
                                                        lista[resultado].bala = null;
                                                    }
                                                    lista[resultado].destruir();
                                                    lista.Remove(lista[resultado]);
                                                }
                                                break;

                                            }
                                        }

                                    }
                                }

                            }

                            if (Jugadores[1].bala != null)
                            {
                                conteo4++;
                                if (conteo4 > 100)
                                {
                                    conteo4 = 0;
                                    Jugadores[1].bala.mover();
                                    Posicion impacto = Jugadores[1].bala.verificarImpacto();
                                    if (impacto != null)
                                    {
                                        Jugadores[1].bala.destruir();
                                        Jugadores[1].bala = null;

                                        foreach (var lista in Enemigos)
                                        {
                                            int resultado = lista.FindIndex(x => x.posicion.x == impacto.x && x.posicion.y == impacto.y);

                                            if (resultado != -1)
                                            {
                                                lista[resultado].vida--;
                                                if (lista[resultado].vida > 0)
                                                {
                                                    lista[resultado].herir();

                                                }
                                                else
                                                {
                                                    if (lista[resultado].bala != null)
                                                    {
                                                        lista[resultado].bala.destruir();
                                                        lista[resultado].bala = null;
                                                    }
                                                    lista[resultado].destruir();
                                                    lista.Remove(lista[resultado]);
                                                }
                                                break;

                                            }
                                        }

                                    }
                                }

                            }

                            foreach (var lista in Enemigos)
                            {
                                foreach (var enemigo in lista)
                                {
                                    if (enemigo.bala != null)
                                    {
                                        conteo3++;
                                        if (conteo3 > 600)
                                        {
                                            conteo3 = 0;
                                            enemigo.bala.mover();
                                            Posicion impacto = enemigo.bala.verificarImpacto();
                                            if (impacto != null)
                                            {
                                                enemigo.bala.destruir();
                                                enemigo.bala = null;


                                                int resultado = Jugadores.FindIndex(x => x.posicion.x == impacto.x && x.posicion.y == impacto.y);

                                                if (resultado != -1)
                                                {
                                                    Jugadores[resultado].vida--;
                                                    if (Jugadores[resultado].vida > 0)
                                                    {
                                                        Jugadores[resultado].herir();

                                                    }
                                                    else
                                                    {
                                                        Jugadores[resultado].destruir();
                                                    }
                                                    break;

                                                }


                                            }
                                        }
                                    }
                                }
                            }

                        }
                        Console.Clear();
                        //perdiste



                        break;
                    }
                case 3:  //unirse a partida

                    pintarmenu();
                    pintaropciones(5);
                    int x2 = 130;
                    int y = 75;
                    y+=10;

                    
                    string ip = "";

                    ConsoleKey tecladigito = ConsoleKey.A;
                    while (tecladigito != ConsoleKey.Enter)
                    {
                        tecladigito = Console.ReadKey().Key;
                        char letra;
                        switch (tecladigito)
                        {
                            case ConsoleKey.NumPad0:
                                letra = '0';
                                pintarnumero(new Posicion(x2, y), 0);
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.NumPad1:
                                letra = '1';
                                pintarnumero(new Posicion(x2, y), 1);
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.NumPad2:
                                pintarnumero(new Posicion(x2, y), 2);
                                letra = '2';
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.NumPad3:
                                pintarnumero(new Posicion(x2, y), 3);
                                letra = '3';
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.NumPad4:
                                pintarnumero(new Posicion(x2, y), 4);
                                letra = '4';
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.NumPad5:

                                pintarnumero(new Posicion(x2, y), 5);
                                letra = '5';
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.NumPad6:
                                pintarnumero(new Posicion(x2, y), 6);
                                letra = '6';
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.NumPad7:
                                pintarnumero(new Posicion(x2, y), 7);
                                letra = '7';
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.NumPad8:
                                pintarnumero(new Posicion(x2, y), 8);
                                letra = '8';
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.NumPad9:
                                pintarnumero(new Posicion(x2, y), 9);
                                letra = '9';
                                ip += letra;
                                x2 += 10;
                                break;
                            case ConsoleKey.Decimal:
                                pintarnumero(new Posicion(x2, y), 10);
                                letra = '.';
                                ip += letra;
                                x2 += 10;
                                break;
                        }
                    }
                    Console.Clear();

                    ////////////////////////////////
                    Socket Cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ipserver = new IPEndPoint(IPAddress.Parse(ip), 1234);
                    Cliente.Connect(ipserver);
                    int muertos = 0;
                    byte[] ByRec = null;

                    List<Nave> Naves = new List<Nave>();
                    int contador = 0;
                    while (muertos < 2)
                    {
                        ByRec = new byte[50000];
                        int a = Cliente.Receive(ByRec, 0, ByRec.Length, 0);

                        string datorcb = Encoding.Default.GetString(ByRec, 0, a);
                        ConsoleKey tecla = ConsoleKey.A;

                        byte[] textoenviar;
                        string datoenviar = "";
                        if (Console.KeyAvailable == true)
                        {
                            tecla = Console.ReadKey().Key;
                            switch (tecla)
                            {
                                case ConsoleKey.UpArrow: //disparar
                                    datoenviar = "arriba";
                                    break;
                                case ConsoleKey.LeftArrow:
                                    datoenviar = "izquierda";
                                    break;
                                case ConsoleKey.RightArrow:
                                    datoenviar = "derecha";
                                    break;
                            }
                            textoenviar = Encoding.Default.GetBytes(datoenviar);
                            Cliente.Send(textoenviar, 0, textoenviar.Length, 0);


                        }
                        else
                        {
                            tecla = ConsoleKey.A;
                            datoenviar = "quieto";
                            textoenviar = Encoding.Default.GetBytes(datoenviar);
                            Cliente.Send(textoenviar, 0, textoenviar.Length, 0);
                        }

                        contador++;
                        if (contador == 20)
                        {
                            var datosseparados = datorcb.Split(';');
                            int i;
                            for (i = 0; i < datosseparados.Length; i++)
                            {
                                if (datosseparados[i].StartsWith("Octopus") || datosseparados[i].StartsWith("Crab") || datosseparados[i].StartsWith("Squid"))
                                {
                                    break;
                                }

                            }
                            var textonaves = datosseparados[i].Split(',');
                            for (int j = 0; j < textonaves.Length - 1; j++)
                            {
                                var textoelemento = textonaves[j].Split('-');
                                switch (textoelemento[0])
                                {
                                    case "Octopus":
                                        Naves.Add(new EnemOctopus(new Posicion(Convert.ToInt32(textoelemento[1]), Convert.ToInt32(textoelemento[2])), Direccion.Derecha, ConsoleColor.DarkMagenta, Convert.ToInt32(textoelemento[3])));
                                        break;
                                    case "Crab":
                                        Naves.Add(new EnemCrab(new Posicion(Convert.ToInt32(textoelemento[1]), Convert.ToInt32(textoelemento[2])), Direccion.Derecha, ConsoleColor.Cyan, Convert.ToInt32(textoelemento[3])));
                                        break;
                                    case "Squid":
                                        Naves.Add(new EnemSquid(new Posicion(Convert.ToInt32(textoelemento[1]), Convert.ToInt32(textoelemento[2])), Direccion.Derecha, ConsoleColor.Green, Convert.ToInt32(textoelemento[3])));
                                        break;
                                }
                                if (textoelemento[4] != "null")
                                {
                                    var posbala = textoelemento[4].Split('_');
                                    Naves[Naves.Count() - 1].bala = new bala(new Posicion(Convert.ToInt32(posbala[0]), Convert.ToInt32(posbala[1])), new List<Nave>(), Direccion.Abajo);
                                }
                            }

                            
                            if (datosseparados[i + 1] == "null")
                            {
                                muertos++;
                            }
                            else
                            {
                                var textojug1 = datosseparados[i + 1].Split('-');
                                Naves.Add(new jugador(new Posicion(Convert.ToInt32(textojug1[0]), 130), Direccion.Derecha, ConsoleColor.Blue, Convert.ToInt32(textojug1[1])));
                                if (textojug1[2] != "null")
                                {
                                    var posbala = textojug1[2].Split('_');
                                    Naves[Naves.Count() - 1].bala = new bala(new Posicion(Convert.ToInt32(posbala[0]), Convert.ToInt32(posbala[1])), new List<Nave>(), Direccion.Arriba);
                                }
                            }

                            
                            if (datosseparados[i + 2] == "null")
                            {
                                muertos++;
                            }
                            else
                            {
                                var textojug2 = datosseparados[i + 2].Split('-');
                                Naves.Add(new jugador(new Posicion(Convert.ToInt32(textojug2[0]), 130), Direccion.Derecha, ConsoleColor.Green, Convert.ToInt32(textojug2[1])));
                                if (textojug2[2] != "null")
                                {
                                    var posbala = textojug2[2].Split('_');
                                    Naves[Naves.Count() - 1].bala = new bala(new Posicion(Convert.ToInt32(posbala[0]), Convert.ToInt32(posbala[1])), new List<Nave>(), Direccion.Arriba);
                                }
                            }



                            foreach (var navecita in Naves)
                            {
                                navecita.pintar();
                                if (navecita.bala != null)
                                {
                                    navecita.bala.pintar();
                                }
                            }
                        }
                        else if(contador > 400)
                        {
                            contador = 0;
                            foreach (var navecita in Naves)
                            {
                                navecita.destruir();
                                if (navecita.bala != null)
                                {
                                    navecita.bala.destruir();
                                }
                            }
                            Naves.Clear();
                        }
                        



                        datorcb = "";
                        ByRec = null;


                    }
                    Console.Clear();
                    break;
            }
        }

        public void configurarOpciones()
        {
            int seleccion = 0;
            while (seleccion != 2)
            {
                seleccion = seleccionar(3, 3);
                Console.Clear();
                switch (seleccion)
                {
                    case 0:
                        Nivel++;
                        if (Nivel > 3)
                        {
                            Nivel = 1;
                        }
                        break;
                    case 1:
                        velocidad++;
                        if (velocidad > 3)
                        {
                            velocidad = 1;
                        }
                        break;
                }
            }
        }

        public void unirseapartida()
        {
            jugar(3);
        }

        public void pintarmenu()
        {
            //Estrellas
            ////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.White;
            var rand = new Random();
            for (int i = 0; i < 500; i++)
            {

                int posx = rand.Next(0, 400);
                int posy = rand.Next(0, 150);
                Console.SetCursorPosition(posx, posy);
                Console.Write("*");
            }
            new EnemOctopus(new Posicion(180, 30), Direccion.Derecha, ConsoleColor.DarkMagenta, 1).pintar();
            new EnemCrab(new Posicion(150, 30), Direccion.Derecha, ConsoleColor.Cyan, 1).pintar();
            new EnemSquid(new Posicion(212, 30), Direccion.Derecha, ConsoleColor.Green, 1).pintar();

            new jugador(new Posicion(180, 130), Direccion.Derecha, ConsoleColor.Blue, 1).pintar();


            
            //Letras
            //////////////////////////////////////////////////////////////////

            int x = 142, y = 40;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.Write("    ssssssssss   ppppp   ppppppppp     aaaaaaaaaaaaa       cccccccccccccccc    eeeeeeeeeeee");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("  ss::::::::::s  p::::ppp:::::::::p    a::::::::::::a    cc:::::::::::::::c  ee::::::::::::ee");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("ss:::::::::::::s p:::::::::::::::::p   aaaaaaaaa:::::a  c:::::::::::::::::c e::::::eeeee:::::ee");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("s::::::ssss:::::spp::::::ppppp::::::p           a::::a c:::::::cccccc:::::ce::::::e     e:::::e");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" s:::::s  ssssss  p:::::p     p:::::p    aaaaaaa:::::a c::::::c     ccccccce:::::::eeeee::::::e");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("   s::::::s       p:::::p     p:::::p  aa::::::::::::a c:::::c             e:::::::::::::::::e");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("      s::::::s    p:::::p     p:::::p a::::aaaa::::::a c:::::c             e::::::eeeeeeeeeee");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("ssssss   s:::::s  p:::::p    p::::::pa::::a    a:::::a c::::::c     ccccccce:::::::e");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("s:::::ssss::::::s p:::::ppppp:::::::pa::::a    a:::::a c:::::::cccccc:::::ce::::::::e");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("s::::::::::::::s  p::::::::::::::::p a:::::aaaa::::::a  c:::::::::::::::::c e::::::::eeeeeeee");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" s:::::::::::ss   p::::::::::::::pp   a::::::::::aa:::a  cc:::::::::::::::c  ee:::::::::::::e");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("  sssssssssss     p::::::pppppppp      aaaaaaaaaa  aaaa    cccccccccccccccc    eeeeeeeeeeeeee");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("                  p:::::p");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("                  p:::::p");

            x = 116;
            y = 54;
            Console.SetCursorPosition(x, y);
            Console.Write("                                           p:::::::p                             dddddddd");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("  iiii                                     p:::::::p                             d::::::d");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" i::::i                                    p:::::::p                             d::::::d");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("  iiii                                     ppppppppp                             d::::::d");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("                                                                                 d:::::d");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("iiiiiii nnnn  nnnnnnnn    vvvvvvv           vvvvvvv  aaaaaaaaaaaaa       ddddddddd:::::d     eeeeeeeeeeee    rrrrr   rrrrrrrrr       ssssssssss");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("i:::::i n:::nn::::::::nn   v:::::v         v:::::v   a::::::::::::a    dd::::::::::::::d   ee::::::::::::ee  r::::rrr:::::::::r    ss::::::::::s");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" i::::i n::::::::::::::nn   v:::::v       v:::::v    aaaaaaaaa:::::a  d::::::::::::::::d  e::::::eeeee:::::eer:::::::::::::::::r ss:::::::::::::s");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" i::::i nn:::::::::::::::n   v:::::v     v:::::v              a::::a d:::::::ddddd:::::d e::::::e     e:::::err::::::rrrrr::::::rs::::::ssss:::::s");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" i::::i   n:::::nnnn:::::n    v:::::v   v:::::v        aaaaaaa:::::a d::::::d    d:::::d e:::::::eeeee::::::e r:::::r     r:::::r s:::::s  ssssss");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" i::::i   n::::n    n::::n     v:::::v v:::::v       aa::::::::::::a d:::::d     d:::::d e:::::::::::::::::e  r:::::r     rrrrrrr   s::::::s");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" i::::i   n::::n    n::::n      v:::::v:::::v       a::::aaaa::::::a d:::::d     d:::::d e::::::eeeeeeeeeee   r:::::r                  s::::::s");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(" i::::i   n::::n    n::::n       v:::::::::v       a::::a    a:::::a d:::::d     d:::::d e:::::::e            r:::::r            ssssss   s:::::s");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("i::::::i  n::::n    n::::n        v:::::::v        a::::a    a:::::a d::::::ddddd::::::dde::::::::e           r:::::r            s:::::ssss::::::s");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("i::::::i  n::::n    n::::n         v:::::v         a:::::aaaa::::::a  d:::::::::::::::::d e::::::::eeeeeeee   r:::::r            s::::::::::::::s");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("i::::::i  n::::n    n::::n          v:::v           a::::::::::aa:::a  d:::::::::ddd::::d  ee:::::::::::::e   r:::::r             s:::::::::::ss");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("iiiiiiii  nnnnnn    nnnnnn           vvv             aaaaaaaaaa  aaaa   ddddddddd   ddddd    eeeeeeeeeeeeee   rrrrrrr              sssssssssss   ");
            //////////////////////////////////////////////////////////////////
        }

        private void pintaropciones(int opciones)
        {
            //Cada valor pintará el número de opciones que se requieran
            //1: Opciones menú principal
            //2: Opciones de crear partida
            //3: Opciones de configuración
            //4: Opciones de servidor
            //5: Opciones de unirse a partida
            int x = 130;
            int y = 75;
            switch (opciones)
            {
                case 1:
                    y++;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ######  ########  ########    ###    ########     ########     ###    ########  ######## #### ########     ###");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ##     ## ##         ## ##   ##     ##    ##     ##   ## ##   ##     ##    ##     ##  ##     ##   ## ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##     ## ##        ##   ##  ##     ##    ##     ##  ##   ##  ##     ##    ##     ##  ##     ##  ##   ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ########  ######   ##     ## ########     ########  ##     ## ########     ##     ##  ##     ## ##     ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##   ##   ##       ######### ##   ##      ##        ######### ##   ##      ##     ##  ##     ## #########");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ##    ##  ##       ##     ## ##    ##     ##        ##     ## ##    ##     ##     ##  ##     ## ##     ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ######  ##     ## ######## ##     ## ##     ##    ##        ##     ## ##     ##    ##    #### ########  ##     ## ");
                    y++;
                    y++;
                    y++;
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ##    ## #### ########   ######  ########       ###       ##     ## ##    ##    ###       ########     ###    ########  ######## #### ########     ###    ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ###   ##  ##  ##     ## ##    ## ##            ## ##      ##     ## ###   ##   ## ##      ##     ##   ## ##   ##     ##    ##     ##  ##     ##   ## ##   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ####  ##  ##  ##     ## ##       ##           ##   ##     ##     ## ####  ##  ##   ##     ##     ##  ##   ##  ##     ##    ##     ##  ##     ##  ##   ##  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ## ## ##  ##  ########   ######  ######      ##     ##    ##     ## ## ## ## ##     ##    ########  ##     ## ########     ##     ##  ##     ## ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ##  ####  ##  ##   ##         ## ##          #########    ##     ## ##  #### #########    ##        ######### ##   ##      ##     ##  ##     ## ######### ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ##   ###  ##  ##    ##  ##    ## ##          ##     ##    ##     ## ##   ### ##     ##    ##        ##     ## ##    ##     ##     ##  ##     ## ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" #######  ##    ## #### ##     ##  ######  ########    ##     ##     #######  ##    ## ##     ##    ##        ##     ## ##     ##    ##    #### ########  ##     ## ");
                    y++;
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("                                                                                                      ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("                                                                                                     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ######   #######  ##    ## ######## ####  ######   ##     ## ########     ###     ######  ####  #######  ##    ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ##     ## ###   ## ##        ##  ##    ##  ##     ## ##     ##   ## ##   ##    ##  ##  ##     ## ###   ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##     ## ####  ## ##        ##  ##        ##     ## ##     ##  ##   ##  ##        ##  ##     ## ####  ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##     ## ## ## ## ######    ##  ##   #### ##     ## ########  ##     ## ##        ##  ##     ## ## ## ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##     ## ##  #### ##        ##  ##    ##  ##     ## ##   ##   ######### ##        ##  ##     ## ##  #### ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ##     ## ##   ### ##        ##  ##    ##  ##     ## ##    ##  ##     ## ##    ##  ##  ##     ## ##   ### ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ######   #######  ##    ## ##       ####  ######    #######  ##     ## ##     ##  ######  ####  #######  ##    ## ");
                    y++;
                    y++;
                    y++;
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ######     ###    ##       #### ########  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ##   ## ##   ##        ##  ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##        ##   ##  ##        ##  ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ######  ##     ## ##        ##  ########  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("      ## ######### ##        ##  ##   ##   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ##     ## ##        ##  ##    ##  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ######  ##     ## ######## #### ##     ## ");
                    //////////////////////////////////////////////////////////////////
                    break;
                case 2:
                    
                    y++;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x, y);
                    Console.Write("      ## ##     ##  ######      ###    ########      ######   #######  ##        #######");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("      ## ##     ## ##    ##    ## ##   ##     ##    ##    ## ##     ## ##       ##     ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("      ## ##     ## ##         ##   ##  ##     ##    ##       ##     ## ##       ##     ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("      ## ##     ## ##   #### ##     ## ########      ######  ##     ## ##       ##     ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ##     ## ##    ##  ######### ##   ##            ## ##     ## ##       ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ##     ## ##    ##  ##     ## ##    ##     ##    ## ##     ## ##       ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ######   #######   ######   ##     ## ##     ##     ######   #######  ########  #######  ");
                    y++; 
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("                                                                                                                                                       ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("                                                                                                                                                      ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("      ## ##     ##  ######      ###    ########     #### ##    ## ######## ######## ########   ######   #######  ##    ## ######## ##     ## ####  #######  ##    ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("      ## ##     ## ##    ##    ## ##   ##     ##     ##  ###   ##    ##    ##       ##     ## ##    ## ##     ## ###   ## ##        ##   ##   ##  ##     ## ###   ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("      ## ##     ## ##         ##   ##  ##     ##     ##  ####  ##    ##    ##       ##     ## ##       ##     ## ####  ## ##         ## ##    ##  ##     ## ####  ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("      ## ##     ## ##   #### ##     ## ########      ##  ## ## ##    ##    ######   ########  ##       ##     ## ## ## ## ######      ###     ##  ##     ## ## ## ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ##     ## ##    ##  ######### ##   ##       ##  ##  ####    ##    ##       ##   ##   ##       ##     ## ##  #### ##         ## ##    ##  ##     ## ##  #### ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ##     ## ##    ##  ##     ## ##    ##      ##  ##   ###    ##    ##       ##    ##  ##    ## ##     ## ##   ### ##        ##   ##   ##  ##     ## ##   ### ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ######   #######   ######   ##     ## ##     ##    #### ##    ##    ##    ######## ##     ##  ######   #######  ##    ## ######## ##     ## ####  #######  ##    ## ");
                    y++;
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("                                   ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("                                  ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("   ###    ######## ########     ###     ######  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ## ##      ##    ##     ##   ## ##   ##    ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ##   ##     ##    ##     ##  ##   ##  ##       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ##    ##    ########  ##     ##  ######  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("#########    ##    ##   ##   #########       ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ##    ##    ##    ##  ##     ## ##    ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ##    ##    ##     ## ##     ##  ######  ");

                    break;

                case 3:
                    y++;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## #### ##     ## ######## ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("###   ##  ##  ##     ## ##       ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("####  ##  ##  ##     ## ##       ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("## ## ##  ##  ##     ## ######   ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##  ####  ##   ##   ##  ##       ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##   ###  ##    ## ##   ##       ##");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##    ## ####    ###    ######## ########");
                    y++;
                    y++;
                    y++;
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ######## ##        #######   ######  #### ########     ###    ########  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ##       ##       ##     ## ##    ##  ##  ##     ##   ## ##   ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ##       ##       ##     ## ##        ##  ##     ##  ##   ##  ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ## ######   ##       ##     ## ##        ##  ##     ## ##     ## ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ##   ##  ##       ##       ##     ## ##        ##  ##     ## ######### ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ## ##   ##       ##       ##     ## ##    ##  ##  ##     ## ##     ## ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("   ###    ######## ########  #######   ######  #### ########  ##     ## ########  ");
                    y++;
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("                                   ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("                                  ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("   ###    ######## ########     ###     ######  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ## ##      ##    ##     ##   ## ##   ##    ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ##   ##     ##    ##     ##  ##   ##  ##       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ##    ##    ########  ##     ##  ######  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("#########    ##    ##   ##   #########       ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ##    ##    ##    ##  ##     ## ##    ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##     ##    ##    ##     ## ##     ##  ######  ");

                    pintarnumero(new Posicion(300, 75), Nivel);
                    pintarnumero(new Posicion(300, 85), velocidad);

                    break;
                case 4:
                    y++;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x, y);
                    Console.Write("########  ######  ########  ######## ########     ###    ##    ## ########   #######      ######  ##       #### ######## ##    ## ######## ######## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##    ## ##     ## ##       ##     ##   ## ##   ###   ## ##     ## ##     ##    ##    ## ##        ##  ##       ###   ##    ##    ##       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##       ##     ## ##       ##     ##  ##   ##  ####  ## ##     ## ##     ##    ##       ##        ##  ##       ####  ##    ##    ##       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("######    ######  ########  ######   ########  ##     ## ## ## ## ##     ## ##     ##    ##       ##        ##  ######   ## ## ##    ##    ######   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##             ## ##        ##       ##   ##   ######### ##  #### ##     ## ##     ##    ##       ##        ##  ##       ##  ####    ##    ##       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##    ## ##        ##       ##    ##  ##     ## ##   ### ##     ## ##     ##    ##    ## ##        ##  ##       ##   ###    ##    ##       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("########  ######  ##        ######## ##     ## ##     ## ##    ## ########   #######      ######  ######## #### ######## ##    ##    ##    ######## ");
                    y++;
                    y++;
                    y++;
                    y++;

                    string ip = ObtenerIp();




                    foreach (var digito in ip)
                    {
                        if (digito == '.')
                        {
                            pintarnumero(new Posicion(x, y), 10);
                        }
                        else
                        {
                            int digi = Convert.ToInt32(digito);
                            pintarnumero(new Posicion(x, y), digi - 48);
                        }
                        x += 10;
                    }
                    break;
                case 5:
                    y++;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x, y);
                    Console.Write("########  ######   ######  ########  #### ########     ###       ########  #### ########  ########  ######   ######  ####  #######  ##    ##    #### ########  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##    ## ##    ## ##     ##  ##  ##     ##   ## ##      ##     ##  ##  ##     ## ##       ##    ## ##    ##  ##  ##     ## ###   ##     ##  ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##       ##       ##     ##  ##  ##     ##  ##   ##     ##     ##  ##  ##     ## ##       ##       ##        ##  ##     ## ####  ##     ##  ##     ## ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("######    ######  ##       ########   ##  ########  ##     ##    ##     ##  ##  ########  ######   ##       ##        ##  ##     ## ## ## ##     ##  ########  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##             ## ##       ##   ##    ##  ##     ## #########    ##     ##  ##  ##   ##   ##       ##       ##        ##  ##     ## ##  ####     ##  ##        ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("##       ##    ## ##    ## ##    ##   ##  ##     ## ##     ##    ##     ##  ##  ##    ##  ##       ##    ## ##    ##  ##  ##     ## ##   ###     ##  ##        ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.Write("########  ######   ######  ##     ## #### ########  ##     ##    ########  #### ##     ## ########  ######   ######  ####  #######  ##    ##    #### ##        ");
                    break;
            }
        }

        public void pintarnumero(Posicion posicion, int numero)
        {
            Console.SetCursorPosition(posicion.x, posicion.y);
            switch (numero)
            {
                case 0:
                    Console.Write("  #####");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" ##   ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" ##   ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("  #####");
                    break;
                case 1:
                    Console.Write("  ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("####");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("  ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("  ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("  ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("  ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("######");
                    break;
                case 2:
                    Console.Write(" ####### ");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("       ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" #######");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("#########");
                    break;
                case 3:
                    Console.Write(" ####### ");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("       ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" #######");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("       ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" #######");
                    break;
                case 4:
                    Console.Write("##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##    ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##    ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##    ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("#########");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("      ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("      ##");
                    break;
                case 5:
                    Console.Write("########");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("#######");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("      ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##    ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" ######");
                    break;
                case 6:
                    Console.Write(" #######");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("########");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" #######");
                    break;
                case 7:
                    Console.Write("########");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##    ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("    ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("   ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("  ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("  ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("  ##");
                    break;
                case 8:
                    Console.Write(" #######");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" #######");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" #######");
                    break;
                case 9:
                    Console.Write(" #######");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" #######");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("       ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("##     ##");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write(" #######");
                    break;
                case 10: // imprime el punto
                    Console.Write("");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("###");
                    posicion.y++;
                    Console.SetCursorPosition(posicion.x, posicion.y);
                    Console.Write("###");
                    break;
            }
        }
    }
}
