using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace datos

{
    public class conexionbd
    {
        public SqlConnection ruta = new SqlConnection("Data Source = DESKTOP - 13BO6VM\\SQLEXPRESS; Initial Catalog = ferreteria; Integrated Security = True; Encrypt=False;Trust Server Certificate=True");
        public SqlConnection abrirconexion()
        {
            if (ruta.State == ConnectionState.Closed)
                ruta.Open();
            return ruta;
        }
        public SqlConnection CerrarConexion()
        {

            if (ruta.State == ConnectionState.Closed)
                ruta.Close();
            return ruta;
        }
    }
}
