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
            ((System.ComponentModel.ISupportInitialize)(this.fotoPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // fotoPokemon
            // 
            this.fotoPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotoPokemon.Location = new System.Drawing.Point(214, 41);
            this.fotoPokemon.Name = "fotoPokemon";
            this.fotoPokemon.Size = new System.Drawing.Size(219, 124);
            this.fotoPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoPokemon.TabIndex = 0;
            this.fotoPokemon.TabStop = false;
            this.fotoPokemon.Click += new System.EventHandler(this.fotoPokemon_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 15);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(163, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 15);
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
            this.nombrePokemon.Location = new System.Drawing.Point(214, 143);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(219, 31);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAltura
            // 
            this.LabelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAltura.Location = new System.Drawing.Point(227, 234);
            this.LabelAltura.Name = "LabelAltura";
            this.LabelAltura.Size = new System.Drawing.Size(69, 23);
            this.LabelAltura.TabIndex = 4;
            this.LabelAltura.Text = "Altura: ";
            this.LabelAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAltura.Click += new System.EventHandler(this.Altura_Click);
            // 
            // evo
            // 
            this.evo.BackColor = System.Drawing.Color.Transparent;
            this.evo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.evo.Location = new System.Drawing.Point(527, 252);
            this.evo.Name = "evo";
            this.evo.Size = new System.Drawing.Size(58, 64);
            this.evo.TabIndex = 5;
            this.evo.Text = "Linea de evolución";
            this.evo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.evo.Click += new System.EventHandler(this.evo_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(227, 257);
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
            this.PokedexCompleta.Location = new System.Drawing.Point(90, 70);
            this.PokedexCompleta.Name = "PokedexCompleta";
            this.PokedexCompleta.Size = new System.Drawing.Size(75, 62);
            this.PokedexCompleta.TabIndex = 7;
            this.PokedexCompleta.Text = "POKEDEX COMPLETA";
            this.PokedexCompleta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PokedexCompleta.Click += new System.EventHandler(this.PokedexCompleta_Click);
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(295, 234);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(127, 23);
            this.altura.TabIndex = 8;
            this.altura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.altura.Click += new System.EventHandler(this.altura_Click_1);
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(295, 257);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(127, 23);
            this.peso.TabIndex = 9;
            this.peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curiosidad
            // 
            this.curiosidad.Location = new System.Drawing.Point(227, 280);
            this.curiosidad.Name = "curiosidad";
            this.curiosidad.Size = new System.Drawing.Size(195, 59);
            this.curiosidad.TabIndex = 10;
            this.curiosidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPokemon
            // 
            this.numPokemon.Location = new System.Drawing.Point(227, 143);
            this.numPokemon.Name = "numPokemon";
            this.numPokemon.Size = new System.Drawing.Size(54, 31);
            this.numPokemon.TabIndex = 11;
            this.numPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PokedexBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PruebaBBDD.Properties.Resources.Pokedex;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 414);
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
            this.ResumeLayout(false);

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
    }
}