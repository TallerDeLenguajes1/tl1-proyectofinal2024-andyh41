using EspacioPelea;
using EspacioPersonajes;
using EspacioHistorial;
using EspacioMenuPrincipal;
using MensajesPorPantalla;

namespace FinJuego
{
    public class FinalDeJuego
    {
        public static async Task Final(Personaje Ganador)
        {
            await Task.Delay(500);

            Mensajes.MostrarMensajeGanador(Ganador);
            await Task.Delay(500);
            Console.WriteLine("Sus estadísticas finales son:");
            Fabrica.MostrarPersonaje(Ganador,ID);
            // Añadir al historial de ganadores
            var Historial = HistorialGanadores.CargarHistorialDesdeArchivo();
            HistorialGanadores.CargarHistorial(Ganador, Historial);
            Historial = HistorialGanadores.CargarHistorialDesdeArchivo();
            
            Console.WriteLine("Presione una tecla para ver el Historial de Ganadores...");
            Console.ReadKey(intercept: true);
            HistorialGanadores.MostrarListado(Historial);
            Console.WriteLine("Presione una tecla para volver al Menu Principal...");
            Console.ReadKey(intercept: true);
           

        }
        
    }
}