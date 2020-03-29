using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;

namespace PulsacionesUI_
{
    class Program
    {
        public static void Main(string[] args)
        {
            Persona persona = new Persona();
            PersonaService personaService = new PersonaService();

            Console.WriteLine("Ingrese su identificación");
            persona.Identificacion = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            persona.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su sexo M|F");
            persona.Sexo = Convert.ToChar(Console.ReadLine().ToUpper());

            personaService.CalcularPulsacion(persona);
            Console.WriteLine($"La pulsación es: {persona.Pulsacion}");
            personaService.Guardar(persona);

            Console.Clear();

            personaService.Leer();
            

            Console.ReadKey();
        }
    }
}
