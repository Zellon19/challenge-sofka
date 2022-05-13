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
        private static List<Jugador> _jugadores = new List<Jugador>();

        public List<Jugador> ListaJugadores { get { return _jugadores; } }
        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public List<Partida> Partidas { get { return _partidas; } }
        public int TotalGanado { get { return _totalGanado; } set { _totalGanado = value;  } }
    
        public Jugador? BuscarJugador(Jugador pJugador)
        {
            try
            {
                if (pJugador == null) return null;

                foreach (var jugador in _jugadores)
                {
                    if (jugador.Id.Equals(pJugador.Id))
                        return jugador;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public bool AgregarJugador(Jugador pJugador)
        {
            if (pJugador == null) return false;

            if(BuscarJugador(pJugador) != null)
            {
                _jugadores.Add(pJugador);
                return true;
            }
            return false;
        }
    }
}
