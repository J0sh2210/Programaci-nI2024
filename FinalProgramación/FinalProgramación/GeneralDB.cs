using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProgramación
{
    public class GeneralDB
    {
        public static SqlConnection BDConectar()
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-EEIL3D5; DataBase= Mantenimiento_fInal; Integrated Security= true");

            conn.Open();
            return conn;
        }
    }
}
