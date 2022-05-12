using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_sofka.back
{
    internal class Categoria
    {
        private int _id;
        private string _nombre;
        private List<Pregunta> _preguntas;

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public List<Pregunta> Preguntas { get { return _preguntas; } }
    }
}
