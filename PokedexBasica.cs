
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PruebaBBDD
{
    public partial class PokedexBasica : Form
    {
        Conexion miConexion = new Conexion();
        int idActual = 1;
        public PokedexBasica()
        {
            InitializeComponent();
            asignaPokemon();
         }
  
        private void button2_Click(object sender, EventArgs e)
        {//boton derecha
            idActual++;
            if (idActual > 151) {
                idActual = 1;
            }
            asignaPokemon();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual < 1)
            {
                idActual = 151;
            }
            asignaPokemon();
        }

        private void asignaPokemon() {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = pokemonElegido.Rows[0]["nombre"].ToString();
            fotoPokemon.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            altura.Text = pokemonElegido.Rows[0]["altura"].ToString() + " m";
            peso.Text = pokemonElegido.Rows[0]["peso"].ToString() + " kg";
            numPokemon.Text = pokemonElegido.Rows[0]["id"].ToString();
            curiosidad.Text = pokemonElegido.Rows[0]["descripcion"].ToString();
        }

        private Image convierteBlobAImagen(byte[] img) {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }

        private void fotoPokemon_Click(object sender, EventArgs e)
        {

        }

        private void Altura_Click(object sender, EventArgs e)
        {

        }

        private void PokedexCompleta_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
        }

        private void altura_Click_1(object sender, EventArgs e)
        {

        }

        private void evo_Click(object sender, EventArgs e)
        {
            Evolucion ventana = new Evolucion(idActual);
            ventana.Show();
        }
    }
}
