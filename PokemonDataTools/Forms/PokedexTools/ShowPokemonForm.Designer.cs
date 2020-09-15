namespace PokemonShowdown.Forms.PokedexTools
{
    partial class ShowPokemonForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchPoke = new System.Windows.Forms.Button();
            this.textBoxSearchPoke = new System.Windows.Forms.TextBox();
            this.richTextBoxShowPoke = new System.Windows.Forms.RichTextBox();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Pokémon";
            // 
            // btnSearchPoke
            // 
            this.btnSearchPoke.Location = new System.Drawing.Point(12, 27);
            this.btnSearchPoke.Name = "btnSearchPoke";
            this.btnSearchPoke.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPoke.TabIndex = 1;
            this.btnSearchPoke.Text = "Buscar";
            this.btnSearchPoke.UseVisualStyleBackColor = true;
            this.btnSearchPoke.Click += new System.EventHandler(this.btnSearchPoke_Click);
            // 
            // textBoxSearchPoke
            // 
            this.textBoxSearchPoke.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchPoke.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearchPoke.Location = new System.Drawing.Point(93, 28);
            this.textBoxSearchPoke.Name = "textBoxSearchPoke";
            this.textBoxSearchPoke.Size = new System.Drawing.Size(546, 23);
            this.textBoxSearchPoke.TabIndex = 2;
            this.textBoxSearchPoke.Text = "Enter the name of a pokémon...";
            this.textBoxSearchPoke.Enter += new System.EventHandler(this.textBoxSearchPoke_Enter);
            this.textBoxSearchPoke.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchPoke_KeyPress);
            this.textBoxSearchPoke.Leave += new System.EventHandler(this.textBoxSearchPoke_Leave);
            // 
            // richTextBoxShowPoke
            // 
            this.richTextBoxShowPoke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxShowPoke.Location = new System.Drawing.Point(12, 55);
            this.richTextBoxShowPoke.Name = "richTextBoxShowPoke";
            this.richTextBoxShowPoke.ReadOnly = true;
            this.richTextBoxShowPoke.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxShowPoke.Size = new System.Drawing.Size(627, 98);
            this.richTextBoxShowPoke.TabIndex = 3;
            this.richTextBoxShowPoke.Text = "";
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPokemon.Location = new System.Drawing.Point(13, 159);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(252, 249);
            this.pictureBoxPokemon.TabIndex = 4;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 412);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ShowPokemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 447);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.richTextBoxShowPoke);
            this.Controls.Add(this.textBoxSearchPoke);
            this.Controls.Add(this.btnSearchPoke);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPokemonForm";
            this.Text = "ShowPokemonForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchPoke;
        private System.Windows.Forms.TextBox textBoxSearchPoke;
        private System.Windows.Forms.RichTextBox richTextBoxShowPoke;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Button buttonClose;
    }
}