using System;

namespace JuegoDelCalamar
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- 1. CONSTANTES ----------
            const string NOMBRE_JUEGO = "EL JUEGO DEL CALAMAR";
            const int TOTAL_CUPOS = 3;
            const int EDAD_MINIMA = 18;
            const double PREMIO_TOTAL = 45600000000;
            const string PRUEBA_1 = "Luz roja, luz verde";
            const string PRUEBA_2 = "Dalgona";
            const string PRUEBA_3 = "Tira y afloja";
            const string ESTADO_VIVO = "SOBREVIVE";
            const string ESTADO_FUERA = "ELIMINADO";

            // ---------- 2. VARIABLES ----------
            string jugador1;
            string jugador2;
            string jugador3;
            string jugadorElegido = "";
            string estadoFinal = "";
            string pruebaElegida = "";
            string clasificacion = "";

            int numeroJugador = 0;
            int puntaje = 0;
            int opcionJugador;
            int opcionPrueba;
            int decision;
            int edad;

            // ---------- 3. PORTADA ----------
            Console.WriteLine("==================================================");
            Console.WriteLine("   " + NOMBRE_JUEGO);
            Console.WriteLine("   UNICEN - Programacion II");
            Console.WriteLine("==================================================");
            Console.WriteLine("Premio acumulado : " + PREMIO_TOTAL + " wones");
            Console.WriteLine("Cupos habilitados: " + TOTAL_CUPOS);
            Console.WriteLine("Edad minima      : " + EDAD_MINIMA + " anios");

            // ---------- 4. REGISTRO DE LOS 3 JUGADORES ----------
            Console.WriteLine();
            Console.WriteLine("--- REGISTRO DE JUGADORES ---");

            Console.Write("Nombre del jugador 1: ");
            jugador1 = Console.ReadLine();

            Console.Write("Nombre del jugador 2: ");
            jugador2 = Console.ReadLine();

            Console.Write("Nombre del jugador 3: ");
            jugador3 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Jugadores inscritos:");
            Console.WriteLine("  001 - " + jugador1);
            Console.WriteLine("  002 - " + jugador2);
            Console.WriteLine("  003 - " + jugador3);

            // ---------- 5. PRIMERA DECISION ----------
            Console.WriteLine();
            Console.WriteLine("--- SELECCION DE JUGADOR ---");
            Console.WriteLine("1) " + jugador1);
            Console.WriteLine("2) " + jugador2);
            Console.WriteLine("3) " + jugador3);

            Console.Write("Que jugador entra a la arena (1-3): ");
            opcionJugador = int.Parse(Console.ReadLine());

            if (opcionJugador == 1)
            {
                jugadorElegido = jugador1;
                numeroJugador = 1;
            }
            else if (opcionJugador == 2)
            {
                jugadorElegido = jugador2;
                numeroJugador = 2;
            }
            else if (opcionJugador == 3)
            {
                jugadorElegido = jugador3;
                numeroJugador = 3;
            }
            else
            {
                jugadorElegido = "SIN JUGADOR";
                numeroJugador = 0;
                estadoFinal = ESTADO_FUERA;
            }

            // ---------- 6. CONTROL DE EDAD ----------
            if (numeroJugador != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Jugador seleccionado: 00" + numeroJugador +
                                  " - " + jugadorElegido);

                Console.Write("Ingrese la edad de " + jugadorElegido + ": ");
                edad = int.Parse(Console.ReadLine());

                if (edad < EDAD_MINIMA)
                {
                    Console.WriteLine("ACCESO DENEGADO. " +
                                      jugadorElegido + " es menor de edad.");
                    estadoFinal = ESTADO_FUERA;
                }
                else
                {
                    Console.WriteLine("ACCESO PERMITIDO. " +
                                      jugadorElegido + " puede competir.");

                    puntaje = puntaje + 20;

                    // ---------- 7. SELECCION DE PRUEBA ----------
                    Console.WriteLine();
                    Console.WriteLine("--- SELECCION DE PRUEBA ---");
                    Console.WriteLine("1) " + PRUEBA_1);
                    Console.WriteLine("2) " + PRUEBA_2);
                    Console.WriteLine("3) " + PRUEBA_3);

                    Console.Write("Elija la prueba (1-3): ");
                    opcionPrueba = int.Parse(Console.ReadLine());

                    if (opcionPrueba == 1)
                    {
                        pruebaElegida = PRUEBA_1;

                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_1);
                        Console.WriteLine("Que hace cuando la muneca gira?");
                        Console.WriteLine("1) Seguir corriendo");
                        Console.WriteLine("2) Quedarse inmovil");
                        Console.WriteLine("3) Esconderse detras de otro");

                        Console.Write("Decision: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            Console.WriteLine("El jugador siguio corriendo.");
                            estadoFinal = ESTADO_FUERA;
                        }
                        else if (decision == 2)
                        {
                            Console.WriteLine("El jugador se quedo inmovil y sobrevive.");
                            puntaje = puntaje + 70;
                            estadoFinal = ESTADO_VIVO;
                        }
                        else if (decision == 3)
                        {
                            Console.WriteLine("El jugador se escondio y sobrevive.");
                            puntaje = puntaje + 40;
                            estadoFinal = ESTADO_VIVO;
                        }
                        else
                        {
                            Console.WriteLine("Respuesta invalida.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else if (opcionPrueba == 2)
                    {
                        pruebaElegida = PRUEBA_2;

                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_2);
                        Console.WriteLine("Elija la figura de la galleta:");
                        Console.WriteLine("1) Triangulo   (facil)");
                        Console.WriteLine("2) Estrella    (medio)");
                        Console.WriteLine("3) Sombrilla   (dificil)");

                        Console.Write("Figura elegida por " + jugadorElegido + ": ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            Console.WriteLine("El triangulo es una figura facil.");
                            puntaje = puntaje + 50;
                            estadoFinal = ESTADO_VIVO;
                        }
                        else if (decision == 2)
                        {
                            Console.WriteLine("La estrella requiere mas cuidado.");

                            // IF ANIDADO
                            Console.Write("Lame la galleta? (1 = si / 2 = no): ");
                            int decisionEstrella = int.Parse(Console.ReadLine());

                            if (decisionEstrella == 1)
                            {
                                Console.WriteLine("La galleta se ablanda y " +
                                                  jugadorElegido + " lo logra.");
                                puntaje = puntaje + 65;
                                estadoFinal = ESTADO_VIVO;
                            }
                            else
                            {
                                Console.WriteLine("No lame la galleta.");
                                estadoFinal = ESTADO_FUERA;
                            }
                        }
                        else if (decision == 3)
                        {
                            Console.WriteLine("La sombrilla es la figura mas dificil del juego.");

                            // IF ANIDADO
                            Console.Write("Usa la aguja calentada con el encendedor? " +
                                          "(1 = si / 2 = no): ");
                            int decisionSombrilla = int.Parse(Console.ReadLine());

                            if (decisionSombrilla == 1)
                            {
                                Console.WriteLine("La aguja caliente corta el azucar. " +
                                                  jugadorElegido + " lo logra!");
                                puntaje = puntaje + 80;
                                estadoFinal = ESTADO_VIVO;
                            }
                            else
                            {
                                Console.WriteLine("La galleta se rompe.");
                                estadoFinal = ESTADO_FUERA;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Figura inexistente.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else if (opcionPrueba == 3)
                    {
                        pruebaElegida = PRUEBA_3;

                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_3);
                        Console.WriteLine("Que estrategia usa?");
                        Console.WriteLine("1) Jalar con toda la fuerza");
                        Console.WriteLine("2) Inclinarse hacia atras");
                        Console.WriteLine("3) Soltar la cuerda");

                        Console.Write("Decision: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            Console.WriteLine("La estrategia no funciona.");
                            estadoFinal = ESTADO_FUERA;
                        }
                        else if (decision == 2)
                        {
                            Console.WriteLine("La estrategia funciona. " +
                                              jugadorElegido + " sobrevive.");
                            puntaje = puntaje + 75;
                            estadoFinal = ESTADO_VIVO;
                        }
                        else if (decision == 3)
                        {
                            Console.WriteLine("El jugador solto la cuerda.");
                            estadoFinal = ESTADO_FUERA;
                        }
                        else
                        {
                            Console.WriteLine("Sin estrategia.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else
                    {
                        pruebaElegida = "SIN PRUEBA";
                        Console.WriteLine("Esa prueba no existe.");
                        estadoFinal = ESTADO_FUERA;
                    }
                }
            }

            // ---------- 8. CLASIFICACION POR PUNTAJE ----------
            if (puntaje >= 90)
            {
                clasificacion = "FINALISTA";
            }
            else if (puntaje >= 60)
            {
                clasificacion = "AVANZA A LA SIGUIENTE RONDA";
            }
            else if (puntaje >= 30)
            {
                clasificacion = "PASA CON OBSERVACIONES";
            }
            else
            {
                clasificacion = "FUERA DE COMPETENCIA";
            }

            // ---------- 9. REPORTE FINAL ----------
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("   REPORTE FINAL - " + NOMBRE_JUEGO);
            Console.WriteLine("==================================================");
            Console.WriteLine("Jugador       : " + jugadorElegido);

            if (numeroJugador == 0)
            {
                Console.WriteLine("Numero        : 000");
            }
            else
            {
                Console.WriteLine("Numero        : 00" + numeroJugador);
            }

            Console.WriteLine("Prueba        : " + pruebaElegida);
            Console.WriteLine("Estado        : " + estadoFinal);
            Console.WriteLine("Puntaje       : " + puntaje + " / 100");
            Console.WriteLine("Clasificacion : " + clasificacion);

            if (estadoFinal == ESTADO_VIVO)
            {
                Console.WriteLine("Premio en juego: " + PREMIO_TOTAL + " wones");
            }

            Console.WriteLine("==================================================");

            Console.ReadKey();
        }
    }
}