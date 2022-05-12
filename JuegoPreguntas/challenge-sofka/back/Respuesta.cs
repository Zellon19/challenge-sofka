using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_sofka.back
{
    internal class Respuesta
    {
        private int _id;
        private Pregunta _pregunta;
        private bool _correcta;

        public int Id { get { return _id; } set { _id = value; } }
        public Pregunta Pregunta { get { return _pregunta; } }
        public bool Correcta { get { return _correcta; } set { _correcta = value; } }



    }
}
