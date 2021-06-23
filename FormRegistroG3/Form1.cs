using System;
using FormsListaReproduccion_G3_2021_II;
using System.Windows.Forms;

namespace FormRegistroG3
{
    public partial class FormIngresar : System.Windows.Forms.Form
    {
        public FormIngresar()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtbUsuario.Text;
            string contrasena = txtbContrasena.Text;

            if( usuario == "Armando" && contrasena == "123"  )
            {
                FormListReproduccion formListReproduccion = new FormListReproduccion();
                formListReproduccion.Show();

            }else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbContrasena.PasswordChar = '\0';
        }
    }
}
