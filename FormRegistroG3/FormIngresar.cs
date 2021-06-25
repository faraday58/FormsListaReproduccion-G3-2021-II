using System;
using FormsListaReproduccion_G3_2021_II;
using LibreriaUsuario;
using System.Collections;
using System.Windows.Forms;

namespace FormRegistroG3
{
    public partial class FormIngresar : System.Windows.Forms.Form
    {

        ArrayList usuarios;
        bool correcto = false;
        public FormIngresar()
        {
            InitializeComponent();
            usuarios = new ArrayList();
            usuarios.Add(new Usuario("Armando", "123"));
            usuarios.Add(new Usuario("Jorge", "456"));
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            string usuario = txtbUsuario.Text;
            string contrasena = txtbContrasena.Text;

           if( usuario == "Armando" && contrasena == "123"  )
            */
            if(ValidaUsuario())            
            {
                FormListReproduccion formListReproduccion = new FormListReproduccion(this);
                formListReproduccion.Show();
                this.Hide();

            }else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }           

        }

        public bool ValidaUsuario()
        {
            foreach ( Usuario usuario in usuarios)
            {
                if( usuario.NombreUsuario == txtbUsuario.Text && usuario.Password == txtbContrasena.Text    )
                {
                    correcto = true;
                    break;
                }
                else
                {
                    correcto = false;
                    break;
                }

            }

            return correcto;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtbContrasena.PasswordChar = '\0';
        }
    }
}
