using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Logica;

namespace SistemaControlEstudiantes_Chistama
{
    public partial class ListarAlumnos : Form
    {
        Logica_de_Bd logica_De_Bd;

        public ListarAlumnos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarAlumnos_Load(object sender, EventArgs e)
        {
            logica_De_Bd = new Logica_de_Bd();
            bcdgDatosAlumnos.DataSource = null;
            bcdgDatosAlumnos.DataSource = logica_De_Bd.CargarDatosBD("SP_Listar_alumnos", null);
            bcdgDatosAlumnos.Columns["ID"].Width = 35;
            bcdgDatosAlumnos.Columns["DNI"].Width = 65;
            bcdgDatosAlumnos.Columns["Nombre"].Width = 180;
            bcdgDatosAlumnos.Columns["Especialidad"].Width = 180;
            bcdgDatosAlumnos.Columns["Comentarios"].Width = 200;


        }
    }
}
