using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace challenge_sofka.back
{
    internal class Pregunta
    {
        private int _id;
        private Categoria _categoria;
        private Dificultad _dificultad;
        private List<Respuesta> _respuestas = new();
        private int _recompensa;

        private List<Pregunta> _listaPreguntas;

        public int Id { get { return _id; } set { _id = value; } }
        public Categoria CategoriaV { get { return _categoria; } set { _categoria = value; } }
        public Dificultad Dificultad { get { return _dificultad; } set { _dificultad = value; } }
        public List<Respuesta> Respuestas { get { return _respuestas; } set { _respuestas = value; } }
        public int Recompensa { get { return _recompensa; } set { _recompensa = value; } }

        public Pregunta? BuscarPregunta(Pregunta pPregunta)
        {
            try
            {
                if (pPregunta == null) return null;

                foreach (var pregunta in _listaPreguntas)
                {
                    if (pregunta.Id.Equals(pPregunta.Id))
                        return pregunta;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public bool AgregarPregunta(Pregunta pPregunta)
        {
            if (pPregunta == null) return false;

            if(BuscarPregunta(pPregunta) == null)
            {
                _listaPreguntas.Add(pPregunta);
                return true;
            }
            return false;
        }

        public List<Pregunta> SeleccionarPreguntas()
        {
            List<Pregunta> listaRet = new();
            int max = _listaPreguntas.Count;
            for(int i = 0; i < 5; i++)
                listaRet.Add(_listaPreguntas[RandomNumberGenerator.GetInt32(1, max)]);

            return listaRet;
        }

        public Pregunta()
        {

        }

        public Pregunta(int pId, Categoria categoria, Dificultad dificultad, List<Respuesta> respuestas, int recompensa)
        {
            Id = pId;
            CategoriaV = categoria;
            Dificultad = dificultad;
            Respuestas = respuestas;
            Recompensa = recompensa;
        }
    }

}

