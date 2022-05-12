using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_sofka.back
{
    internal class Jugador
    {
        private int _id;
        private string _nombre;
        private List<Partida> _partidas = new List<Partida>();
        private int _totalGanado;

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public List<Partida> Partidas { get { return _partidas; } }
        public int TotalGanado { get { return _totalGanado; } set { _totalGanado = value;  } }
    }
}
