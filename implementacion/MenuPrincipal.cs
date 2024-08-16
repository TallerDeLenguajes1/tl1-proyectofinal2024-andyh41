using System;
using MensajesPorPantalla;
using EspacioJson;
using EspacioPersonajes;
using Historial;
using EspacioSeleccionDePersonaje;

namespace EspacioMenuPrincipal
{
    public class MenuPrincipal
    {
        public static async Task MostrarMenu()
        {
            await MostrarMenuPrincipal();
        }
        private static string archivoPersonajes = "Json/Personajes.json";
        private static async Task MostrarMenuPrincipal()
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
                        global::System.Object mostrarListado = HistorialGanadores.MostrarListado;
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