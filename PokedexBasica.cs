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
            if (idActual > 151)
            {
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

            //Cambiar la foto del tipo principal del pokemon
            tipo1.Text = pokemonElegido.Rows[0]["tipo1"].ToString();
            if (tipo1.Text == "Bicho") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Bicho.png"); }
            if (tipo1.Text == "Siniestro") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Oscuridad.png"); }
            if (tipo1.Text == "Dragon") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Dragon.png"); }
            if (tipo1.Text == "Electrico") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Electrico.png"); }
            if (tipo1.Text == "Hada") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Hada.png"); }
            if (tipo1.Text == "Lucha") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Lucha.png"); }
            if (tipo1.Text == "Fuego") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Fuego.png"); }
            if (tipo1.Text == "Volador") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Volador.png"); }
            if (tipo1.Text == "Fantasma") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Fantasma.png"); }
            if (tipo1.Text == "Planta") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Planta.png"); }
            if (tipo1.Text == "Tierra") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Tierra.png"); }
            if (tipo1.Text == "Hielo") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Hielo.png"); }
            if (tipo1.Text == "Normal") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Normal.png"); }
            if (tipo1.Text == "Veneno") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Veneno.png"); }
            if (tipo1.Text == "Psiquico") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Psiquico.png"); }
            if (tipo1.Text == "Roca") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Roca.png"); }
            if (tipo1.Text == "Acero") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Metal.png"); }
            if (tipo1.Text == "Agua") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Agua.png"); }
            if (tipo1.Text == "") { this.tipoPrincipal.Image = System.Drawing.Image.FromFile("f:/Pokedex/Null.png"); }

            //Cambiar la foto del tipo secundario del pokemon
            tipo2.Text = pokemonElegido.Rows[0]["tipo2"].ToString();
            if (tipo2.Text == "Bicho") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Bicho.png"); }
            if (tipo2.Text == "Siniestro") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Oscuridad.png"); }
            if (tipo2.Text == "Dragon") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Dragon.png"); }
            if (tipo2.Text == "Electrico") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Electrico.png"); }
            if (tipo2.Text == "Hada") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Hada.png"); }
            if (tipo2.Text == "Lucha") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Lucha.png"); }
            if (tipo2.Text == "Fuego") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Fuego.png"); }
            if (tipo2.Text == "Volador") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Volador.png"); }
            if (tipo2.Text == "Fantasma") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Fantasma.png"); }
            if (tipo2.Text == "Planta") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Planta.png"); }
            if (tipo2.Text == "Tierra") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Tierra.png"); }
            if (tipo2.Text == "Hielo") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Hielo.png"); }
            if (tipo2.Text == "Normal") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Normal.png"); }
            if (tipo2.Text == "Veneno") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Veneno.png"); }
            if (tipo2.Text == "Psiquico") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Psiquico.png"); }
            if (tipo2.Text == "Roca") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Roca.png"); }
            if (tipo2.Text == "Acero") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Metal.png"); }
            if (tipo2.Text == "Agua") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Agua.png"); }
            if (tipo2.Text == "") { this.tipoSecundario.Image = System.Drawing.Image.FromFile("f:/Pokedex/Null.png"); }
        }

        private Image convierteBlobAImagen(byte[] img) {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }

        private void PokedexCompleta_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
        }

        private void evo_Click(object sender, EventArgs e)
        {
            Evolucion ventana = new Evolucion(idActual);
            ventana.id = idActual;
            ventana.Show();
        }
    }
}
