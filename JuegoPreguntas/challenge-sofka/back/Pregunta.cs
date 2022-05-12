using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_sofka.back
{
    internal class Pregunta
    {
        private int _id;
        private Categoria _categoria;
        private Dificultad _dificultad;
        private List<Respuesta> _respuestas;
        private int _recompensa;

        private List<Pregunta> _listaPreguntas;

        public int Id { get { return _id; } set { _id = value; } }
        public Categoria CategoriaV { get { return _categoria; } set { _categoria = value; } }
        public Dificultad Dificultad { get { return _dificultad; } set { _dificultad = value; } }
        public List<Respuesta> Respuestas { get { return _respuestas; } }
        public int Recompensa { get { return _recompensa; } set { _recompensa = value; } }

        // aplicamos divide y venceras 5 veces, encontrando la pregunta mas rapido
        public List<Pregunta> SeleccionarPreguntas()
        {
            List<Pregunta> lista = new();
            for (int x = 0; x < 5; x++)
            {
                int pPreguntaId = 1;
                int posicion = _listaPreguntas.Count / 2;

                if (_listaPreguntas[posicion].Id > pPreguntaId)
                {
                    for (int i = posicion; i < _listaPreguntas.Count; i++)
                    {
                        if (_listaPreguntas[i].Id == pPreguntaId)
                            lista.Add(_listaPreguntas[i]);
                        continue;
                    }
                }

                if (_listaPreguntas.Count / 2 < pPreguntaId)
                {
                    for (int i = 0; i < posicion; i++)
                    {
                        if (_listaPreguntas[i].Id == pPreguntaId)
                            lista.Add(_listaPreguntas[i]);
                        continue;
                    }
                }
            }
            return lista;

        }
        
    }

}

