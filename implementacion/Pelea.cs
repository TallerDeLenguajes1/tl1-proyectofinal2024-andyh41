using Historial;
using Personajes;
using Mensajes;
using FinJuego;




namespace EspacioPelea
{
    public class Pelea
    {
        public static Random random = new Random();


        public static async Task InicioCombate(List<Personaje> listaPersonajes, Personaje PersonajeElegido)
        {
            
            //mensaje de inicio de pelea
            int ronda = 0;
            var Ganador = new Personaje();

            await Task.Delay(1000);

            bool resultado = Combate(listaPersonajes, PersonajeElegido, ronda);
            
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(intercept: true);
            Console.Clear();
            await FinalDeJuego.Final(resultado);
            
        }


        private static bool Combate(List<Personaje> listaPersonajes, Personaje PersonajeElegido, int ronda)
        {
            while (listaPersonajes.Count > 0 & PersonajeElegido.Caracteristicas.Salud>0)
            {
                PersonajeElegido.Salud = 100;
                if (ronda == 9) break;
                Mensajes.MostrarMensajeRonda(ronda+1);  

                int IndiceContrincante = random.Next(0, listaPersonajes.Count);
                var Contrincante = listaPersonajes[IndiceContrincante];
                listaPersonajes.Remove(Contrincante);

                Console.WriteLine($"{PersonajeElegido.Dato.Nombre} {PersonajeElegido.Dato.Raza} VS {Contrincante.Dato.Nombre} {Contrincante.Dato.Raza})");
                Console.WriteLine("==============================================================================================================");
                
                Ganador = DinamicaDePelea(PersonajeElegido, Contrincante);

                Console.WriteLine();
                Console.WriteLine(Ganador.Nombre.ToUpper() + " GANA ESTA RONDA!");
                MejorarEstadisticas(Ganador);
                
               
                if (ronda != 8)
                {
                    Console.WriteLine("\nPresione una tecla para jugar la siguiente ronda...");
                    Console.ReadKey(intercept: true);
                }else
                {
                    Task.Delay(500);
                }
                
                

                ronda++;
            }

            if (PersonajeElegido.Salud>0)
            {
                return true;
            }else
            {
                return false;
            }

        }



        private static Personaje DinamicaDePelea(Personaje prota, Personaje contrincante)
        {
            int turno = random.Next(0, 2);
            bool primeraVuelta = true;

            while (prota.Datos.Salud > 0 && contrincante.Datos.Salud > 0)
            {
                if (turno == 1)
                {
                    if (primeraVuelta)
                    {
                        Console.WriteLine($"COMIENZA ATACANDO: {prota.Datos.Nombre}");
                    }
                    if (dados>3)
                    {
                        AtaqueEspecial(prota, contrincante);
                        contrincante.Caracteristicas.Resistencia-=5;
                    }else
                    {
                        Ataque(prota, contrincante);
                    }
                    
                    turno = 0;
                }
                else
                {
                    if (primeraVuelta)
                    {
                        Console.WriteLine($"COMIENZA ATACANDO: {contrincante.Nombre}");
                    }
                    if (dados>3)
                    {
                        AtaqueEspecial(contrincante, prota);
                        prota.Caracteristicas.Resistencia-=2;
                    }else
                    {
                        Ataque(contrincante, prota);
                    }
                    turno = 1;
                }
                primeraVuelta = false;
            }

            return prota.Datos.Salud > 0 ? prota : contrincante;
        }




        private static void Ataque(Personaje ataca, Personaje defiende)
        {
            int daño = Daño(ataca);
            defiende.Caracteristicas.Salud = defiende.Caracteristicas.Salud - daño;
            if (defiende.Caracteristicas.Salud < 0)
            {
                defiende.Caracteristicas.Salud = 0;
            }
            Console.WriteLine($"\n ({ataca.Datos.Nombre}) ataca a ({defiende.Datos.Nombre}) y causa {daño} puntos de daño. ");
            Console.WriteLine($"Salud restante de {defiende.Datos.Nombre}: {defiende.Caracteristicas.Salud}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }

        private static void AtaqueEspecial(Personaje ataca, Personaje defiende)
        {
            int daño = Daño(ataca)+15;
            defiende.Caracteristicas.Salud = defiende.Caracteristicas.Salud - daño;
            if (defiende.Salud < 0)
            {
                defiende.Salud = 0;
            }
            Console.WriteLine($"\n ({ataca.Datos.Nombre}) ataca a ({defiende.Datos.Nombre}) con ({ataca.Datos.PoderEspecial}) y causa {daño} puntos de daño. ");
            Console.WriteLine($"Salud restante de {defiende.Datos.Nombre}: {defiende.Caracteristicas.Salud}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }

        private static int Daño(Personaje personaje)
        {
            double Ataque = personaje.Caracteristicas.Fuerza*2;
            double Efectividad = random.Next(1, 101);
            double Defensa = (personaje.Caracteristicas.Resistencia) * (personaje.Caracteristicas.Velocidad);
            double CteDeAjuste = 500;
            double dañoProvocado = ((Ataque * Efectividad) - Defensa) / CteDeAjuste;
            if (dañoProvocado>100)
            {
                dañoProvocado =random.Next(80,100);
            }
            if (dañoProvocado<0)
            {
                dañoProvocado=0;
            }
            return (int)dañoProvocado;
        }

        private static void MejorarEstadisticas(Personaje personaje)
        {
            personaje.Fuerza += random.Next(1, 3);
            personaje.Caracteristicas.Resistencia += random.Next(1, 3);
            
            Console.WriteLine($"{personaje.Datos.Nombre} ha mejorado sus estadísticas!");
            
        }
    }
}   