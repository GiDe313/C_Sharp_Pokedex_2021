namespace PruebaBBDD
{
    partial class PokedexBasica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fotoPokemon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.LabelAltura = new System.Windows.Forms.Label();
            this.evo = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.PokedexCompleta = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.curiosidad = new System.Windows.Forms.Label();
            this.numPokemon = new System.Windows.Forms.Label();
            this.tipoPrincipal = new System.Windows.Forms.PictureBox();
            this.tipoSecundario = new System.Windows.Forms.PictureBox();
            this.tipo1 = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoSecundario)).BeginInit();
            this.SuspendLayout();
            // 
            // fotoPokemon
            // 
            this.fotoPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotoPokemon.Location = new System.Drawing.Point(314, 76);
            this.fotoPokemon.Name = "fotoPokemon";
            this.fotoPokemon.Size = new System.Drawing.Size(198, 147);
            this.fotoPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoPokemon.TabIndex = 0;
            this.fotoPokemon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(154, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 29);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(218, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 29);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(314, 226);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(259, 30);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAltura
            // 
            this.LabelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAltura.Location = new System.Drawing.Point(322, 377);
            this.LabelAltura.Name = "LabelAltura";
            this.LabelAltura.Size = new System.Drawing.Size(69, 23);
            this.LabelAltura.TabIndex = 4;
            this.LabelAltura.Text = "Altura: ";
            this.LabelAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // evo
            // 
            this.evo.BackColor = System.Drawing.Color.Transparent;
            this.evo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.evo.Location = new System.Drawing.Point(716, 391);
            this.evo.Name = "evo";
            this.evo.Size = new System.Drawing.Size(95, 112);
            this.evo.TabIndex = 5;
            this.evo.Text = "Linea de evolución";
            this.evo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.evo.Click += new System.EventHandler(this.evo_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(322, 413);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(69, 23);
            this.labelPeso.TabIndex = 6;
            this.labelPeso.Text = "Peso:";
            this.labelPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PokedexCompleta
            // 
            this.PokedexCompleta.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PokedexCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokedexCompleta.ForeColor = System.Drawing.Color.OliveDrab;
            this.PokedexCompleta.Location = new System.Drawing.Point(127, 116);
            this.PokedexCompleta.Name = "PokedexCompleta";
            this.PokedexCompleta.Size = new System.Drawing.Size(110, 93);
            this.PokedexCompleta.TabIndex = 7;
            this.PokedexCompleta.Text = "POKEDEX COMPLETA";
            this.PokedexCompleta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PokedexCompleta.Click += new System.EventHandler(this.PokedexCompleta_Click);
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(385, 377);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(127, 23);
            this.altura.TabIndex = 8;
            this.altura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(385, 413);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(127, 23);
            this.peso.TabIndex = 9;
            this.peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curiosidad
            // 
            this.curiosidad.Location = new System.Drawing.Point(311, 450);
            this.curiosidad.Name = "curiosidad";
            this.curiosidad.Size = new System.Drawing.Size(262, 79);
            this.curiosidad.TabIndex = 10;
            this.curiosidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPokemon
            // 
            this.numPokemon.Location = new System.Drawing.Point(311, 226);
            this.numPokemon.Name = "numPokemon";
            this.numPokemon.Size = new System.Drawing.Size(54, 30);
            this.numPokemon.TabIndex = 11;
            this.numPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoPrincipal
            // 
            this.tipoPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.tipoPrincipal.Location = new System.Drawing.Point(518, 85);
            this.tipoPrincipal.Name = "tipoPrincipal";
            this.tipoPrincipal.Size = new System.Drawing.Size(55, 66);
            this.tipoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tipoPrincipal.TabIndex = 12;
            this.tipoPrincipal.TabStop = false;
            // 
            // tipoSecundario
            // 
            this.tipoSecundario.BackColor = System.Drawing.Color.Transparent;
            this.tipoSecundario.Location = new System.Drawing.Point(518, 157);
            this.tipoSecundario.Name = "tipoSecundario";
            this.tipoSecundario.Size = new System.Drawing.Size(55, 66);
            this.tipoSecundario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tipoSecundario.TabIndex = 13;
            this.tipoSecundario.TabStop = false;
            // 
            // tipo1
            // 
            this.tipo1.AutoSize = true;
            this.tipo1.BackColor = System.Drawing.Color.Transparent;
            this.tipo1.ForeColor = System.Drawing.Color.Transparent;
            this.tipo1.Location = new System.Drawing.Point(27, 31);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(0, 13);
            this.tipo1.TabIndex = 14;
            // 
            // tipo2
            // 
            this.tipo2.AutoSize = true;
            this.tipo2.BackColor = System.Drawing.Color.Transparent;
            this.tipo2.ForeColor = System.Drawing.Color.Transparent;
            this.tipo2.Location = new System.Drawing.Point(34, 69);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(0, 13);
            this.tipo2.TabIndex = 15;
            // 
            // PokedexBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PruebaBBDD.Properties.Resources.Pokedex;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 655);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.tipoSecundario);
            this.Controls.Add(this.tipoPrincipal);
            this.Controls.Add(this.numPokemon);
            this.Controls.Add(this.curiosidad);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.PokedexCompleta);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.evo);
            this.Controls.Add(this.LabelAltura);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPokemon);
            this.DoubleBuffered = true;
            this.Name = "PokedexBasica";
            this.Text = "PokedexBasica";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoSecundario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoPokemon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Label LabelAltura;
        private System.Windows.Forms.Label evo;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label PokedexCompleta;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label curiosidad;
        private System.Windows.Forms.Label numPokemon;
        private System.Windows.Forms.PictureBox tipoPrincipal;
        private System.Windows.Forms.PictureBox tipoSecundario;
        private System.Windows.Forms.Label tipo1;
        private System.Windows.Forms.Label tipo2;
    }
}