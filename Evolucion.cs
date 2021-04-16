using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBBDD
{
    public partial class Evolucion : Form
    {
        Conexion miConexion = new Conexion();
        int idActual = 2;
        int pre1 = 0;
        int pre2 = 0;
        int ev1 = 0;
        int ev2 = 0;
        public Evolucion()
        {
            InitializeComponent();
            lineaEvol();
        }

        private void lineaEvol()
        {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);
            fotoPokemon.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);

            if (pokemonElegido.Rows[0]["posEvolucion"] != DBNull.Value)
            {
                DataTable pokemonElegido2 = miConexion.getPokemonPorId(idActual - 1);
                Pre1.Image = convierteBlobAImagen((byte[])pokemonElegido2.Rows[0]["imagen"]);
            }
            if (fotoPokemon == Pre1)
            {
                fotoPokemon = null;
            }

            if (pokemonElegido.Rows[0]["posEvolucion"] != DBNull.Value)
            {
                DataTable pokemonElegido2 = miConexion.getPokemonPorId(idActual + 1);
                Ev1.Image = convierteBlobAImagen((byte[])pokemonElegido2.Rows[0]["imagen"]);
            }
            if (fotoPokemon == Ev1)
            {
                fotoPokemon = null;
            }


            //pre1 = pokemonElegido.Rows[0]["preEvolucion"]();
            //Pre1.Image = convierteBlobAImagen((byte[])pre1["imagen"]);
            //Pre2.Image = convierteBlobAImagen((byte[])pre2["imagen"]);
            //Ev1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            //Ev2.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
