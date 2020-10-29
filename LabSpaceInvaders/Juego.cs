using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSpaceInvaders
{
    class Juego
    {
        public int Nivel{ get; set; }
        public int velocidad { get; set; }

        public List<Nave> Enemigos;
        public List<Nave> Jugadores;

        public Juego()
        {
            Nivel = 1;
            velocidad = 1;
            Enemigos = new List<Nave>();
            Jugadores = new List<Nave>();
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

            for (int i = 0; i < 6; i++)
            {
                Enemigos.Add(new EnemSquid(new Posicion(14 + (30 * i), 5), Direccion.Derecha, ConsoleColor.Green, 3 * Nivel));
                Enemigos.Add(new EnemCrab(new Posicion(11 + (30 * i), 15), Direccion.Derecha, ConsoleColor.Cyan, 2 * Nivel));
                Enemigos.Add(new EnemOctopus(new Posicion(10 + (30 * i), 25), Direccion.Derecha, ConsoleColor.DarkMagenta, 1 * Nivel));
            }
            switch (mododejuego)
            {
                case 1: //jugar solo
                    foreach (var enemigo in Enemigos)
                    {
                        enemigo.pintar();
                    }
                    Jugadores.Add(new jugador(new Posicion(10, 130), Direccion.Derecha, ConsoleColor.Blue, 3));
                    Jugadores[0].pintar();
                    ConsoleKey tecla = ConsoleKey.A;
                    int conteo = 0, conteo2 = 0;
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
                    while (Jugadores[0].vida > 0 && Enemigos.Count() > 0 && salir == false)
                    {
                        //verificar si alguna nave tocó el límite
                        foreach (var enemigo in Enemigos)
                        {
                            Nave comp = Enemigos.Find(e => enemigo.posicion.y + 10 == e.posicion.y);
                            if (comp == null)
                            {
                                if (enemigo.posicion.y > 100)
                                {
                                    salir = true;
                                }
                            }
                        }
                        
                        //////////////////////////////////////////
                        conteo++;
                        if (conteo > valor)
                        {
                            conteo = 0;
                            foreach (var enemigo in Enemigos)
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
                                        if (Enemigos[0].posicion.x == 10)
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

                            if (Enemigos[Enemigos.Count() - 1].posicion.x > 370)
                            {
                                foreach (var enemigo in Enemigos)
                                {
                                    enemigo.posicion.x--;
                                    enemigo.direccion = Direccion.Abajo;
                                }

                            }
                            else if (Enemigos[0].posicion.x < 10)
                            {
                                foreach (var enemigo in Enemigos)
                                {
                                    enemigo.posicion.x++;
                                    enemigo.direccion = Direccion.Abajo;
                                }
                            }
                            else
                            {
                                foreach (var enemigo in Enemigos)
                                {
                                    enemigo.mover();
                                }
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
                            if (conteo2 > 500)
                            {
                                conteo2 = 0;
                                Jugadores[0].bala.mover();
                                Posicion impacto = Jugadores[0].bala.verificarImpacto();
                                if (impacto != null)
                                {
                                    Jugadores[0].bala.destruir();
                                    Jugadores[0].bala = null;
                                    int resultado = Enemigos.FindIndex(x => x.posicion.x == impacto.x && x.posicion.y == impacto.y);
                                    
                                    if (resultado != -1)
                                    {
                                        Enemigos[resultado].vida--;
                                        if (Enemigos[resultado].vida > 0)
                                        {
                                            Enemigos[resultado].herir();
                                            
                                        }
                                        else
                                        {
                                            Enemigos[resultado].destruir();
                                            Enemigos.Remove(Enemigos[resultado]);
                                        }
                                        
                                    }
                                }
                            }
                            
                        }

                        if (Enemigos.Count() == 1)
                        {
                            valor = 100;
                        }
                    }
                    Console.Clear();
                    if (Enemigos.Count() == 0)
                    {
                        //ganaste
                    }
                    else
                    {
                        //perdiste
                    }
                    break;
                case 2:  //jugar interconexion
                    Console.ReadKey();
                    break;
                case 3:  //unirse a partida
                    Console.ReadKey();
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
            new EnemOctopus(new Posicion(180, 30), Direccion.Derecha, ConsoleColor.DarkMagenta, 1).pintar();
            new EnemCrab(new Posicion(150, 30), Direccion.Derecha, ConsoleColor.Cyan, 1).pintar();
            new EnemSquid(new Posicion(212, 30), Direccion.Derecha, ConsoleColor.Green, 1).pintar();

            new jugador(new Posicion(180, 130), Direccion.Derecha, ConsoleColor.Blue, 1).pintar();


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
