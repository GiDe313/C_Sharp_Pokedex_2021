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
    public partial class Evolucion : Form
    {
        Conexion miConexion = new Conexion();
        public int idActual = 1;
        public Evolucion(int idActual)
        {
            InitializeComponent();
            asignaPokemon();
        }


        private void asignaPokemon()
        {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);

            //Pokemon elegido
            fotoPokemon.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            nombrePokemon.Text = pokemonElegido.Rows[0]["nombre"].ToString();

            //Primera evolucion
            ev1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            evo1.Text = pokemonElegido.Rows[0]["nombre"].ToString();

            //Primera preevolucion
            pre1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            prev1.Text = pokemonElegido.Rows[0]["nombre"].ToString();

            //Segunda evolucion
            ev2.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            evo2.Text = pokemonElegido.Rows[0]["nombre"].ToString();

            //Segunda preevolucion
            pre2.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            prev2.Text = pokemonElegido.Rows[0]["nombre"].ToString();
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }
    }
}
