using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaControlEstudiantes_Chistama
{
    public partial class PanelPrincipal : Form
    {
        int contadorTimer = 0;

        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void PanelPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (Properties.Settings.Default.NombreUsuario.Length > 0)
            {
                lbBienvenidaUser.Text = $"¡Hola, {Properties.Settings.Default.NombreUsuario}!";
            }
            else
            {
                lbBienvenidaUser.Text = "No se cargó el nombre de usuario";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            AgregarEstudiante frmAgregarEstudiante = new AgregarEstudiante();
            frmAgregarEstudiante.Show();
            Hide();
        }

        private void btnEditarEstudiante_Click(object sender, EventArgs e)
        {
            EditarAlumno frmEditarAlumno = new EditarAlumno();
            frmEditarAlumno.Show();
            Hide();
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            EliminarAlumno frmEliminarAlumno = new EliminarAlumno();
            frmEliminarAlumno.Show();
            Hide();
        }

        private void btnListarEstudiantes_Click(object sender, EventArgs e)
        {
            ListarAlumnos frmListarAlumnos = new ListarAlumnos();
            frmListarAlumnos.Show();
            Hide();
            
        }

        private void PanelPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bfbLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
