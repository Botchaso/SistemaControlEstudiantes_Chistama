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
        // La siguiente instancia es necesaria para poder mostrar el form panel principal desde este form
        PanelPrincipal frmPanelPrincipal = (PanelPrincipal)Application.OpenForms["PanelPrincipal"];

        Logica_de_Bd logica_De_Bd;

        public ListarAlumnos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal.Show();
            Hide();
        }

        private void ListarAlumnos_Load(object sender, EventArgs e)
        {
            logica_De_Bd = new Logica_de_Bd();
            bcdgDatosAlumnos.DataSource = null;

            string[] parametros =
            {
                "@modoCarga",
            };

            string[] valoresParametros =
            {
                "1",
            };

            bcdgDatosAlumnos.DataSource = logica_De_Bd.CargarDatosBD("SP_Listar_alumnos", valoresParametros, parametros);
            bcdgDatosAlumnos.Columns["ID"].Width = 35;
            bcdgDatosAlumnos.Columns["DNI"].Width = 65;
            bcdgDatosAlumnos.Columns["Nombre"].Width = 180;
            bcdgDatosAlumnos.Columns["Especialidad"].Width = 180;
            bcdgDatosAlumnos.Columns["Comentarios"].Width = 200;


        }

        private void ListarAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Solamente se podrá salir del form con el botón Volver
            e.Cancel = true;
        }
    }
}
