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
    public partial class EditarAlumno : Form
    {
        PanelPrincipal frmPanelPrincipal = (PanelPrincipal)Application.OpenForms["PanelPrincipal"];

        Logica_de_Bd logica_De_Bd;

        bool estanDatosCargados = false;
        int idAlumnoSeleccionado = 0, indiceSeleccionado = 0;
        DataTable datosAlumnos;


        public EditarAlumno()
        {
            InitializeComponent();
        }

        private void cbListaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si los datos están cargados, ahí recién registramos el ID del alumno seleccionado
            if (estanDatosCargados)
            {
                idAlumnoSeleccionado = Convert.ToInt32(cbListaAlumnos.SelectedValue);

                foreach (DataRow fila in datosAlumnos.Rows)
                {
                    if (Convert.ToInt32(fila[0]) == idAlumnoSeleccionado)
                    {

                        bmtNombreAlumno.Text = fila["Nombre"].ToString();
                        bmtApellidosAlumno.Text = fila["Apellidos"].ToString();
                        bmtDniAlumno.Text = fila["DNI"].ToString();
                            bdpFechaNacAlumn.Value = Convert.ToDateTime(fila["Fecha Nacimiento"]);
                        bmtCarreraAlumn.Text = fila["Carrera"].ToString();
                        bmtEspecialidadAlumn.Text = fila["Especialidad"].ToString();
                        txtComentariosAlumno.Text = fila["Comentarios"].ToString();
                        break;
                    }
                }


            }
        }

        private void EditarAlumno_Load(object sender, EventArgs e)
        {
            logica_De_Bd = new Logica_de_Bd();
            datosAlumnos = new DataTable();

            string[] parametros =
            {
                "@modoCarga",
            };

            string[] valoresParametros =
            {
                "0",
            };

            datosAlumnos = logica_De_Bd.CargarDatosBD("SP_Listar_alumnos", valoresParametros, parametros);

            cbListaAlumnos.DataSource = null;
            cbListaAlumnos.DataSource = datosAlumnos;
            cbListaAlumnos.DisplayMember = "Nombre Completo";
            cbListaAlumnos.ValueMember = "ID";

            estanDatosCargados = true;


        }

        private void bfbActualizarDatosAlumn_Click(object sender, EventArgs e)
        {
            string[] parametros =
            {
                "@Dni",
                "@Nombre",
                "Apellidos",
                "@FechaNac",
                "@Carrera",
                "@Especialidad",
                "@NotasAdicionales",
            };

            string[] valoresParametros =
            {
                bmtDniAlumno.Text.Trim(),
                bmtNombreAlumno.Text.Trim(),
                bmtApellidosAlumno.Text.Trim(),
                bdpFechaNacAlumn.Value.ToShortDateString(),
                bmtCarreraAlumn.Text.Trim(),
                bmtEspecialidadAlumn.Text.Trim(),
                txtComentariosAlumno.Text.Trim(),
            };

            logica_De_Bd = new Logica_de_Bd();
            MessageBox.Show("Se actualizaron los datos: " + logica_De_Bd.EscribirEnBd("SP_Actualizar_alumno", valoresParametros, parametros));

        }

        private void EditarAlumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal.Show();
            Hide();
        }
    }
}
