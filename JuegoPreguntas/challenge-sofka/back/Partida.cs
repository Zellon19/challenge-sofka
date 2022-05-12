using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace challenge_sofka.back
{
    internal class Partida
    {
        private int _id;
        private Jugador _jugador;
        private List<Ronda> _rondas;

        public int Id { get { return _id; } set { _id = value; } }
        public Jugador JugadorV { get { return _jugador; } set { _jugador = value; } }
        public List<Ronda> Rondas { get { return _rondas; } }

        public void IniciarPartida(Jugador pJugador)
        {
            List<Pregunta> listaPreguntas = DefinirPreguntas();
        }

        public List<Pregunta> DefinirPreguntas()
        {
            List<Pregunta> listaPreguntas = new Pregunta().SeleccionarPreguntas();
            return listaPreguntas;
        }

    }
}
