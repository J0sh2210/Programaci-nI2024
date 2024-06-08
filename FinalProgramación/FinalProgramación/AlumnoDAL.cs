using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramación
{
    public class AlumnoDAL
    {
        public static int AgregarPersona(Usuario usuario)
        {
            int retorna = 0;
            using (SqlConnection conn = GeneralDB.BDConectar())
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                string query = "insert into Alumnos (Carnet,Nombre,Telefono,Grado) values('" + usuario.Carnet + "', '" +usuario.Nombre+"' ,'" + usuario.Telefono + "', '"+usuario.Grado+"')";
                SqlCommand comando = new SqlCommand(query, conn);
                retorna = comando.ExecuteNonQuery();

            }
            return retorna;
        }
        public static List<Usuario> PresentarGrid()
        {
            List<Usuario> Lista = new List<Usuario>();
            using (SqlConnection conec = GeneralDB.BDConectar())
            {
                string query = "select *from Alumnos";
                SqlCommand sqlCommand = new SqlCommand(query, conec);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Carnet = reader.GetString(0);
                    usuario.Nombre = reader.GetString(1);
                    usuario.Telefono= reader.GetString(2);
                    usuario.Grado = reader.GetString(3);
                   

                    Lista.Add(usuario);

                }
                conec.Close();
                return Lista;
            }
        }
        public static int Modificar(Usuario usuario)
        {
            int result = 0;
            using (SqlConnection connection = GeneralDB.BDConectar())
            {
                string query = "update Persona set Nombre = '" + usuario.Nombre + "',Telefono = '" + usuario.Telefono + "'. Usuario = '"+usuario.User+"' where id=" + usuario.Carnet + " ";
                SqlCommand sqlCommand1 = new SqlCommand(query, connection);
                result = sqlCommand1.ExecuteNonQuery();
                connection.Close();


            }
            return result;
        }
        public static int EliminarPersona(int id)
        {
            int retorna = 0;
            using (SqlConnection conn = GeneralDB.BDConectar())
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                string query = "delete from Persona where id=" + id + "";
                SqlCommand comando = new SqlCommand(query, conn);
                retorna = comando.ExecuteNonQuery();

            }
            return retorna;
        }
    
}
}
