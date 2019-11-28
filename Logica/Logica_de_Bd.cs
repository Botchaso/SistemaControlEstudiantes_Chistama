using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

// Referencia a la capa Datos necesaria para poder trabajar.
using Datos;



namespace Logica
{
    public class Logica_de_Bd
    {
        OperacionesBD operacionesBD;

        public DataTable CargarDatosBD(string procedimientoAlmacenado, string[] valoresParametros, params string[] parametros)
        {
            operacionesBD = new OperacionesBD();
            return operacionesBD.CargarDatosBD(procedimientoAlmacenado, valoresParametros, parametros);
        }

        public int EscribirEnBd(string procedimientoAlmacenado, string[] valoresParametros, params string[] parametros)
        {
            operacionesBD = new OperacionesBD();
            return operacionesBD.EscribirEnBd(procedimientoAlmacenado, valoresParametros, parametros);
        }
    }
}
