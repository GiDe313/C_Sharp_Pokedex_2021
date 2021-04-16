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
        public int id = 0;
        public Evolucion(int idActual)
        {
            InitializeComponent();
            lineaEvol();
            asignaPokemon();
        }


        private void asignaPokemon()
        {
            //DataTable pokemonElegido = miConexion.getPokemonPorId(id);
            //fotoPokemon.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
        }
        private void lineaEvol()
        {

        }

        private Image convierteBlobAImagen(byte[] img)
        {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }

    }
}
