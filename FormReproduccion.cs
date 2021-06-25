using System;
using System.Windows.Forms;

namespace FormsListaReproduccion_G3_2021_II
{
    public partial class FormListReproduccion : Form
    {
        #region Atributos
        private Form formPadre;
        #endregion

        /// <summary>
        /// formPadre nos permite referenciar al formulario que invoca a FormListReproduccion
        /// </summary>
        /// <param name="formPadre"></param>
        public FormListReproduccion(Form formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
        }

        private void FormListReproduccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Show();
        }
    }
}
