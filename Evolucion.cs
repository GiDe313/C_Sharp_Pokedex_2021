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
            LineaEvolutiva();
        }

        private void LineaEvolutiva()
        {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);

            //Pokemon elegido
            fotoPokemon.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            nombrePokemon.Text = pokemonElegido.Rows[0]["nombre"].ToString();

            //Primera evolucion
            string evol1 = pokemonElegido.Rows[0]["posEvolucion"].ToString();
            int evolu1 = Convert.ToInt32(evol1);
            DataTable evolucion1 = miConexion.getPokemonPorId(evolu1);
            ev1.Image = convierteBlobAImagen((byte[])evolucion1.Rows[0]["imagen"]);
            evo1.Text = evolucion1.Rows[0]["nombre"].ToString();

            //Primera preevolucion
            string pree1 = pokemonElegido.Rows[0]["preEvolucion"].ToString();
            int preev1 = Convert.ToInt32(pree1);
            DataTable preevolucion1 = miConexion.getPokemonPorId(preev1);
            pre1.Image = convierteBlobAImagen((byte[])preevolucion1.Rows[0]["imagen"]);
            prev1.Text = preevolucion1.Rows[0]["nombre"].ToString();

            //Segunda evolucion
            string evol2 = pokemonElegido.Rows[0]["posEvolucion"].ToString();
            int evolu2 = Convert.ToInt32(evol2);
            DataTable evolucion2 = miConexion.getPokemonPorId(evolu2);
            ev2.Image = convierteBlobAImagen((byte[])evolucion2.Rows[0]["imagen"]);
            evo2.Text = evolucion2.Rows[0]["nombre"].ToString();

            //Segunda preevolucion
            string pree2 = pokemonElegido.Rows[0]["preEvolucion"].ToString();
            int preev2 = Convert.ToInt32(pree2);
            DataTable preevolucion2 = miConexion.getPokemonPorId(preev2);
            pre2.Image = convierteBlobAImagen((byte[])preevolucion2.Rows[0]["imagen"]);
            prev2.Text = preevolucion2.Rows[0]["nombre"].ToString();
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }
    }
}