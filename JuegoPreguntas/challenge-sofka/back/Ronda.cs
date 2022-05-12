using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_sofka.back
{
    internal class Ronda
    {
        private int _id;
        private Partida _partida;
        private List<Pregunta> _preguntas;
        private int _recompensaTotal;

        public int Id { get { return _id; } set { _id = value; } }
        public Partida PartidaV { get { return _partida; } set { _partida = value; } }
        public List<Pregunta> Preguntas { get { return _preguntas; } }
        public int RecompensaTotal { get { return _recompensaTotal; } set { _recompensaTotal = value; } }



    }
}
