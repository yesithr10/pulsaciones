using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;
using Entity;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
        public void CalcularPulsacion(Persona persona)
        {
            if (persona.Sexo == 'F')
            {
                persona.Pulsacion = (220 - persona.Edad) / 10;
            }else if (persona.Sexo == 'M')
            {
                persona.Pulsacion = (210 - persona.Edad) / 10;
            }
            else
            {
                persona.Pulsacion = 0;
            }
        }

        public void Guardar(Persona persona)
        {
            personaRepository.Guardar(persona);
        }

        public void Leer()
        {
            personaRepository.Leer();
        }
    }
}
