using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class PersonaRepository
    {
        private string ruta = "Persona.txt";
        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{persona.Identificacion} ; {persona.Nombre} ; {persona.Edad} ; {persona.Sexo} ; {persona.Pulsacion}");
            escritor.Close();
            file.Close();
        }

        public List<Persona> Leer()
        {
            List<Persona> listaPersonas = new List<Persona>();
            
            TextReader lector;
            lector = new StreamReader("Persona.txt");
            foreach (Persona persona in listaPersonas)
            {
                String[] arrayPersona = lector.ReadLine().Split(';');
                persona.Identificacion = arrayPersona[0];
                persona.Nombre = arrayPersona[1];
                persona.Edad = Convert.ToInt32(arrayPersona[2]);
                persona.Sexo = Convert.ToChar(arrayPersona[3]);
                persona.Pulsacion = Convert.ToDecimal(arrayPersona[4]);

                listaPersonas.Add(persona);
            }

            lector.Close();
            return listaPersonas;
        }

    }
}
