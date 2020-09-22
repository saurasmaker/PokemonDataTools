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
            this.richTextBoxShowPoke = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.comboBoxPokemon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Pokémon";
            // 
            // btnSearchPoke
            // 
            this.btnSearchPoke.Location = new System.Drawing.Point(10, 23);
            this.btnSearchPoke.Name = "btnSearchPoke";
            this.btnSearchPoke.Size = new System.Drawing.Size(64, 20);
            this.btnSearchPoke.TabIndex = 1;
            this.btnSearchPoke.Text = "Buscar";
            this.btnSearchPoke.UseVisualStyleBackColor = true;
            this.btnSearchPoke.Click += new System.EventHandler(this.btnSearchPoke_Click);
            // 
            // richTextBoxShowPoke
            // 
            this.richTextBoxShowPoke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxShowPoke.Location = new System.Drawing.Point(10, 48);
            this.richTextBoxShowPoke.Name = "richTextBoxShowPoke";
            this.richTextBoxShowPoke.ReadOnly = true;
            this.richTextBoxShowPoke.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxShowPoke.Size = new System.Drawing.Size(538, 303);
            this.richTextBoxShowPoke.TabIndex = 3;
            this.richTextBoxShowPoke.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(10, 357);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(64, 20);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // comboBoxPokemon
            // 
            this.comboBoxPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPokemon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxPokemon.FormattingEnabled = true;
            this.comboBoxPokemon.Location = new System.Drawing.Point(81, 21);
            this.comboBoxPokemon.Name = "comboBoxPokemon";
            this.comboBoxPokemon.Size = new System.Drawing.Size(465, 21);
            this.comboBoxPokemon.TabIndex = 6;
            // 
            // ShowPokemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 387);
            this.Controls.Add(this.comboBoxPokemon);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.richTextBoxShowPoke);
            this.Controls.Add(this.btnSearchPoke);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPokemonForm";
            this.Text = "ShowPokemonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchPoke;
        private System.Windows.Forms.RichTextBox richTextBoxShowPoke;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxPokemon;
    }
}