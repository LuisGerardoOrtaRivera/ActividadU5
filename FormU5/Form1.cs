using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormU5
{
    public partial class Form1 : Form
    {
        private RegistroGrupo grupo = new RegistroGrupo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                double nota = double.Parse(txtCalificacion.Text);

                // Validación lógica de calificaciones
                if (nota < 0 || nota > 100)
                    throw new ArgumentOutOfRangeException();

                // Intentamos meter el dato al arreglo de la clase
                if (grupo.AgregarCalificacion(nota))
                {
                    // Texto corto para evitar desbordamiento en el ListBox
                    lstCalificaciones.Items.Add($"Alumno {grupo.ObtenerContador()}: Nota {nota:F1}");

                    // Si llegamos al límite del arreglo (5), mostramos el promedio final
                    if (grupo.ObtenerContador() == 5)
                    {
                        lstCalificaciones.Items.Add("------------------------");
                        lstCalificaciones.Items.Add($"PROMEDIO GRUPO: {grupo.CalcularPromedio():F1}");
                        lstCalificaciones.Items.Add("------------------------");
                        btnAgregar.Enabled = false; // Deshabilitamos para evitar desbordar el vector
                    }
                }

                txtCalificacion.Clear();
                txtCalificacion.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresa una calificación válida entre 0 y 100.", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
