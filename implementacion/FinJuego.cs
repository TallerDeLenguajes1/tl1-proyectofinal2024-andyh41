using EspacioPelea;
using Personajes;
using Historial;
using EspacioMenuPrincipal;
using MensajesPorPantalla;
using FabricaPersonajes;

namespace FinJuego
{
    public class FinalDeJuego
    {
        public static async Task Final(bool resultado, Personaje Ganador)
        {
            await Task.Delay(500);
            if (true)
            {
                Mensajes.MostrarMensajeGanador(Ganador);
                await Task.Delay(500);
                Console.WriteLine("Sus estadísticas finales son:");
                Fabrica.MostrarPersonaje(Ganador,id);
                // Añadir al historial de ganadores
                var Historial = HistorialGanadores.CargarHistorialDesdeArchivo();
                HistorialGanadores.CargarHistorial(Ganador, Historial);
                Historial = HistorialGanadores.CargarHistorialDesdeArchivo();
                
                Console.WriteLine("Presione una tecla para ver el Historial de Ganadores...");
                Console.ReadKey(intercept: true);
                HistorialGanadores.MostrarListado(Historial);
            }else
            {
                
            }

            Console.WriteLine("Presione una tecla para volver al Menu Principal...");
            Console.ReadKey(intercept: true);
           

        }
        
    }
}