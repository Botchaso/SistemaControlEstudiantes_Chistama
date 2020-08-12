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
    public partial class EliminarAlumno : Form
    {
        // La siguiente instancia es necesaria para poder mostrar el form panel principal desde este form
        PanelPrincipal frmPanelPrincipal = (PanelPrincipal)Application.OpenForms["PanelPrincipal"];

        Logica_de_Bd logica_De_Bd;
        DataTable datosAlumnos;
        bool estanDatosCargados = false;
        int totalAlumnos = 0, idAlumnoSeleccionado = 0;

        public EliminarAlumno()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal.Show();
            Hide();
        }

        private void bibDarBajaAlumno_Click(object sender, EventArgs e)
        {
            // Verificamos que se haya seleccionado al menos un alumno
            if (idAlumnoSeleccionado != 0)
            {
                // Pedimos confirmación antes de proceder a dar de baja al alumno
                if (MessageBox.Show("Vas a dar de baja al alumno " + cbListaAlumnos.SelectedText + ", confirma que lo quieres hacer:", "Dando de baja un alumno - Alumnia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    // Procedemos a ejecutar el procedimiento almacenado para dar de baja al alumno
                    string[] parametros =
                    {
                        "@idAlumno"
                    };

                    string[] valoresParametros =
                    {
                        idAlumnoSeleccionado.ToString()
                    };

                    logica_De_Bd = new Logica_de_Bd();
                    if (logica_De_Bd.EscribirEnBd("SP_Dar_de_bajaAlumno", valoresParametros, parametros) > 0)
                    {
                        MessageBox.Show("El alumno ha sido dado de baja.");
                        //MessageBox.Show("ID del alumno: " + cbListaAlumnos.SelectedValue.ToString());
                        // Finalmente, llamamos al método Load() del form para que nos refresque la lista de alumnos
                        estanDatosCargados = false;
                        EliminarAlumno_Load(sender, e);

                    }

                }
            }
        }

        private void EliminarAlumno_Load(object sender, EventArgs e)
        {
            logica_De_Bd = new Logica_de_Bd();

            cbListaAlumnos.DataSource = null;
            cbListaAlumnos.DataSource = logica_De_Bd.CargarDatosBD("SP_CargarNombresAlumno", null);
            totalAlumnos = cbListaAlumnos.Items.Count;

            cbListaAlumnos.DisplayMember = "Nombre";
            cbListaAlumnos.ValueMember = "IdAlumno";
            // La variable estanDatosCargados permite mostrar los ID de los alumnos solamente cuando el ComboBox
            // ha sido cargado completamente. Se coloca debajo del DisplayMember y ValueMember porque estos actualizan al Combo,
            // haciendo que se ejecute el Método SelectedIndexChanged() del Combo.
            estanDatosCargados = true;
        }

        private void EliminarAlumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Solamente se podrá salir del form con el botón Volver
            e.Cancel = true;
        }

        private void cbListaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si los datos están cargados, ahí recién registramos el ID del alumno seleccionado
            if (estanDatosCargados)
            {
                idAlumnoSeleccionado = Convert.ToInt32(cbListaAlumnos.SelectedValue);
            }
        }
    }
}
