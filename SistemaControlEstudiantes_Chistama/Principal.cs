using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Referencia necesaria para vincular la Capa Lógica con la Presentación
using Logica;

namespace SistemaControlEstudiantes_Chistama
{
    public partial class Principal : Form
    {
        Logica_de_Bd logica_De_Bd;

        public Principal()
        {
            InitializeComponent();
        }

        private void buntbIniciarSesion_Click(object sender, EventArgs e)
        {
            if (logica_De_Bd.CargarDatosBD("SP_LoginDocente", bmtxNombreUsuario.Text.Trim(), bmtxContrasenia.Text.Trim()).Rows.Count > 0)
            {
                // Al ejecutar la consulta para iniciar sesión, luego de que el user mete sus datos,
                // buscamos que su login coincida con uno en la BD, y si es así, le dejamos entrar.

            }
            
        }
    }
}
