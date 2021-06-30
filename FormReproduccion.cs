using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsListaReproduccion_G3_2021_II
{
    public partial class FormListReproduccion : Form
    {
        #region Atributos
        private Form formPadre;
        private List<Musica> ListaCanciones;
        #endregion

        /// <summary>
        /// formPadre nos permite referenciar al formulario que invoca a FormListReproduccion
        /// </summary>
        /// <param name="formPadre"></param>
        public FormListReproduccion(Form formPadre)
        {
            InitializeComponent();
            ListaCanciones = new List<Musica>();
            this.formPadre = formPadre;
        }

        private void FormListReproduccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Show();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarCanciones();
            foreach(Musica musica in ListaCanciones  )
            {
                lstReproduccion.Items.Add(musica.Cancion);
            }
        }

        private void cargarCanciones()
        {
            ListaCanciones.Add(new Musica("Las mañanitas","Cepillín","Hits"));
            ListaCanciones.Add(new Musica("Cielito lindo", "Luciano Pavaroti", "Los tres grandes"));

        }
    }
}
