using Personajes;
using FabricaDePersonajes;
using Json;
using Historial;
namespace MensajesPorPantalla
{
    public static class Mensajes
    {
        public static void MostrarIntroduccion()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            AsciiArt.Titulo();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("Eres una mascota en una casa llena de animalitos.");
            Console.WriteLine("El humano se fue y dejo descuidado un pollo sobre la mesa.");
            Console.WriteLine("La pelea por el pollo comenzo y solo uno sera el ganador.");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(intercept: true);
        }


        public static void MostrarMensajeGanador(Personaje ganador)
        {
            Console.Clear();
            Console.WriteLine("=================================================================================================================================");
            Console.WriteLine("                      ¡GANADOR!                      ");
            Console.WriteLine("=================================================================================================================================");
            Console.WriteLine($" ¡{ganador.Nombre.ToUpper()} Gano la pelea por el pollito. ¡Felicidades! y que lo disfrutes");    ");
            Console.WriteLine("=================================================================================================================================");
            Console.WriteLine();
           
        }

          

       

        public static void MostrarMenuPrincipal()
        {
            Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("       MENÚ PRINCIPAL");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Empezar el Juego");
                Console.WriteLine("2. Ver Historial de Ganadores");
                Console.WriteLine("3. Salir");
                Console.WriteLine("=======================================");
                Console.Write("Seleccione una opción (1-3): ");
        }
        public static void MostrarMensajeRonda(int ronda)
        {
            Console.WriteLine("=========================================================================================================");
            Console.WriteLine($"                           RONDA {ronda}");
            Console.WriteLine("=========================================================================================================");
        }

        public static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine("========================================================================================================");
            Console.WriteLine($"                {mensaje}");
            Console.WriteLine("========================================================================================================");
        }
        
        
    }
    

  }