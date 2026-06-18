using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormU5
{
    internal class RegistroGrupo
    {
        private double[] _calificaciones = new double[5];
        private int _contador = 0;

        // Método para insertar elementos en el arreglo
        public bool AgregarCalificacion(double nota)
        {
            if (_contador < _calificaciones.Length)
            {
                _calificaciones[_contador] = nota;
                _contador++;
                return true; // Se agregó con éxito
            }
            return false; // Arreglo lleno
        }

        // Método para procesar los datos del arreglo
        public double CalcularPromedio()
        {
            double suma = 0;
            for (int i = 0; i < _contador; i++)
            {
                suma += _calificaciones[i];
            }
            return _contador > 0 ? suma / _contador : 0;
        }

        public int ObtenerContador() => _contador;
    }
}
