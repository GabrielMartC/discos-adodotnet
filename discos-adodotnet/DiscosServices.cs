using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace discos_adodotnet
{
    internal class DiscosServices
    {
        public List<Disco> listar()
        {
            List<Disco> listaDiscos = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "Select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion As Estilo, T.Descripcion As Edicion From DISCOS D, ESTILOS E, TIPOSEDICION T Where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id";
                comando.Connection = conexion;
                comando.Connection.Open();
                lector = comando.ExecuteReader();

                while(lector.Read()){
                    Disco disco = new Disco();

                    disco.Titulo = (string)lector["Titulo"];
                    disco.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    disco.CantidadCanciones = (int)lector["CantidadCanciones"];
                    disco.UrlImagen = (string)lector["UrlImagenTapa"];
                    disco.Estilo = new Estilo();
                    disco.Estilo.Descripcion = (string)lector["Estilo"];
                    disco.Edicion = new Edicion();
                    disco.Edicion.Descripcion = (string)lector["Edicion"];

                    listaDiscos.Add(disco);

                }

                conexion.Close();
                return listaDiscos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
