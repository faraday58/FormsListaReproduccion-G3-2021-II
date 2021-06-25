namespace LibreriaUsuario
{
    public class Usuario
    {

        #region Atributos
        private string nombreUsuario;
        private string password;       
        #endregion

        #region Propiedades
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        #endregion


        #region Constructor

        /// <summary>
        /// nombreUsuario: Es el nombre que el usuario eligió para iniciar sesión
        /// password: Contraseña del usuario
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="password"></param>

        public Usuario(string nombreUsuario, string password)
        {
            NombreUsuario = nombreUsuario;
            Password = password;
        }

        #endregion




    }
}
