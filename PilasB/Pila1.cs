using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasB
{
    internal class Pila1
    {

        numero1 _tope;

        public numero1 tope()
        {
            return _tope;
        }
        public void Apilar(numero1 unNodo)
        {
            if (_tope == null) {
                _tope = unNodo; }
            else
            {
              numero1 auxiliar = _tope;
                _tope = unNodo;
                _tope.Siguiente = auxiliar;
            }
        }
        
        public void Desapilar()
        {
            if ( _tope != null)
            {
                _tope = _tope.Siguiente;

            }
        }

    }
}
