using System;
using MensajesPorPantalla;
using EspacioJson;
using Personajes;
using Historial;
using EspacioSeleccionDePersonaje;
using FabricaPersonajes;

namespace EspacioMenuPrincipal
{
    public class MenuPrincipal
    {
        public static async Task MostrarMenu()
        {
            Mensajes. MostrarIntroduccion();
            await MostrarMenuPrincipal();
        }
        private static string archivoPersonajes = "Json/Personajes.json";
        public static async Task<object> MostrarMenuPrincipal()
        {
            while (true)
            {
                Mensajes.MostrarMenuPrincipal();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        await ComenzarJuego();
                        break;
                    case "2":
                        HistorialGanadores.MostrarListado(/*pasar lista de historial*/);
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        await Task.Delay(2000);
                        break;
                    
                }
            }
        }

        private static async Task ComenzarJuego()
        {
            List<Personaje> listaPersonajes = new List<Personaje>();
            if (PersonajesJson.Existe(archivoPersonajes))
            {
               listaPersonajes = PersonajesJson.LeerPersonajes(archivoPersonajes);
                if (listaPersonajes.Count < 0)
                {
                    Console.WriteLine("El archivo de personajes está vacío. Creando nuevos personajes...");
                    listaPersonajes = Fabrica.CreacionPersonajes();
                    PersonajesJson.GuardarPersonajes(listaPersonajes, archivoPersonajes);
                }
               
            }else
            {
                Console.WriteLine("No se encontró el archivo de personajes. Creando nuevo archivo...");
                listaPersonajes = Fabrica.CreacionPersonajes();
                PersonajesJson.GuardarPersonajes(listaPersonajes, archivoPersonajes);
                listaPersonajes = PersonajesJson.LeerPersonajes(archivoPersonajes);
            }


            await SeleccionDePersonaje.SelectorDePersonajes(listaPersonajes);
            await Task.Delay(1000);
        }


    }

}