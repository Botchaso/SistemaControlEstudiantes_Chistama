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
    public partial class PrincipalLogin : Form
    {
        Logica_de_Bd logica_De_Bd;

        public PrincipalLogin()
        {
            InitializeComponent();
        }

        private void buntbIniciarSesion_Click(object sender, EventArgs e)
        {
            string[] parametros =
            {
                "@NomUsuario",
                "@Contrasenia"
            };

            string[] valoresParametros =
            {
                bmtxNombreUsuario.Text.Trim(),
                bmtxContrasenia.Text.Trim(),
            };

            // Al ejecutar la consulta para iniciar sesión, luego de que el user mete sus datos,
            // buscamos que su login coincida con uno en la BD, y si es así, le dejamos entrar.
            if (bmtxNombreUsuario.Text.Length != 0 && bmtxContrasenia.Text.Length != 0)
            {
                logica_De_Bd = new Logica_de_Bd();

                if (logica_De_Bd.CargarDatosBD("SP_LoginDocente", valoresParametros, parametros).Rows.Count > 0)
                {
                    Hide();
                    // Guardamos el nombre de usuario para mostrarlo en las siguientes pantallas
                    Properties.Settings.Default.NombreUsuario = bmtxNombreUsuario.Text.Trim();
                    PanelPrincipal frmPanelPrincipal = new PanelPrincipal();
                    frmPanelPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Asegúrate que tus datos estén correctos");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa tu usuario y contraseña");
            }

        }
    }
}
