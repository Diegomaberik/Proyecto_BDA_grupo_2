using MySql.Data.MySqlClient;

namespace CData.SQL
{
    public class UserLoginValidator
    {
        private readonly ConnectionDB connectionDB;

        public UserLoginValidator()
        {
            connectionDB = new ConnectionDB();
        }

        public bool ValidarUsuario(string usuarioCorreo, string contrasena)
        {
            using (MySqlConnection conn = connectionDB.OpenConnection())
            {
                string query = @"SELECT COUNT(*) FROM users 
                                 WHERE (usuario = @valor OR correo = @valor) 
                                 AND clave = @clave";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@valor", usuarioCorreo);
                    cmd.Parameters.AddWithValue("@clave", contrasena);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}

