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
        private static List<Respuesta> _respuestas = new List<Respuesta>();

        public List<Respuesta> ListaRespuestas { get { return _respuestas; } }
        public int Id { get { return _id; } set { _id = value; } }
        public Pregunta Pregunta { get { return _pregunta; } }
        public bool Correcta { get { return _correcta; } set { _correcta = value; } }

        public Respuesta? BuscarRespuesta(Respuesta pRespuesta)
        {
            try
            {
                if (pRespuesta == null) return null;

                foreach (var respuesta in _pregunta.Respuestas)
                {
                    if (pRespuesta.Id.Equals(pRespuesta.Id))
                        return respuesta;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public bool AgregarRespuesta(Respuesta pRespuesta)
        {
            if (pRespuesta == null || pRespuesta.Pregunta == null) return false;

            if(BuscarRespuesta(pRespuesta) == null)
            {
                pRespuesta.Pregunta.Respuestas.Add(pRespuesta);
                _respuestas.Add(pRespuesta);
                return true;
            }
            return false;
        }

    }
}
