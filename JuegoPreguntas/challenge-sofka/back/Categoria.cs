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
        private static List<Pregunta> _preguntas = new();

        private static List<Categoria> _listaCategorias = new();
        public List<Categoria> ListaCategorias { get { return _listaCategorias; } }

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public List<Pregunta> Preguntas { get { return _preguntas; } }

        public Categoria? BuscarCategoria(Categoria pCategoria)
        {
            try
            {
                if (pCategoria == null) return null;

                foreach (var cat in _listaCategorias)
                {
                    if (pCategoria.Id.Equals(cat.Id))
                        return cat;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public bool AgregarCategoria(Categoria pCategoria)
        {
            if (pCategoria == null) return false;

            // chequeamos que exista
            if (BuscarCategoria(pCategoria) == null)
            {
                _listaCategorias.Add(pCategoria);
                return true;
            }

            return false;
        }

        public bool AgregarPreguntaEnCategoria(Categoria pCategoria, Pregunta pPregunta)
        {
            if (pCategoria == null || pPregunta == null) return false;

            //chequeamos si existe
            if (BuscarCategoria(pCategoria) == null || pPregunta.BuscarPregunta(pPregunta) == null)
                return false;

            _preguntas.Add(pPregunta);
            return true;

        }

        public Categoria()
        {

        }

        public Categoria(int pId, string pNombre)
        {
            Id = pId;
            Nombre = pNombre;
        }

        public Categoria(int pId, string pNombre, List<Pregunta> pPreguntas)
        {
            Id = pId;
            Nombre = pNombre;
            _preguntas = pPreguntas;
        }
        public Categoria(int pId)
        {
            Id = pId;
        }

    }
}
