using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_sofka.back
{
    internal class Dificultad
    {
        private int _id;
        private string _nombre;
        private List<Pregunta> _listaPreguntas;
        private static List<Dificultad> _dificultades = new List<Dificultad>();

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public List<Pregunta> ListaPreguntas { get { return _listaPreguntas; } }
        public List<Dificultad> ListaDificultades {  get { return _dificultades; } }


        public Dificultad? BuscarDificultad(Dificultad pDificultad)
        {
            try
            {
                if (pDificultad == null) return null;

                foreach(var dificultad in _dificultades)
                {
                    if (dificultad.Id.Equals(pDificultad.Id))
                        return dificultad;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public bool AgregarDificultad(Dificultad pDificultad)
        {
            if (pDificultad == null) return false;

            if(BuscarDificultad(pDificultad) == null)
            {
                _dificultades.Add(pDificultad);
                return true;
            }
            return false;
        }

        public Dificultad()
        {

        }

        public Dificultad(int pId, string pNombre)
        {
            Id = pId;
            Nombre = pNombre;
        }

    }
}
