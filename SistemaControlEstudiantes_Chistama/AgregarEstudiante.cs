﻿using System;
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
    public partial class AgregarEstudiante : Form
    {
        // La siguiente instancia es necesaria para poder mostrar el form panel principal desde este form
        PanelPrincipal frmPanelPrincipal = (PanelPrincipal) Application.OpenForms["PanelPrincipal"];

        Logica_de_Bd logica_De_Bd;

        public AgregarEstudiante()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal.Show();
            Hide();
        }

        private void AgregarEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Solamente se podrá salir del form con el botón Volver
            e.Cancel = true;
        }

        private void bfbRegistrarAlumno_Click(object sender, EventArgs e)
        {
            string[] parametros =
            {
                "@Dni",
                "@Nombre",
                "@Apellidos",
                "@FechaNac",
                "@Carrera",
                "@Especialidad",
                "@NotasAdicionales"
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
            MessageBox.Show("Se insertaron " + logica_De_Bd.EscribirEnBd("SP_RegistrarNuevoAlumno", valoresParametros, parametros));


        }

        private void AgregarEstudiante_Load(object sender, EventArgs e)
        {
            
        }
    }
}
