using System;
using System.Drawing;
using System.Windows.Forms;
using Classes;
using Classes.Lists;

namespace PokemonShowdown.Forms.PokedexTools
{
    public partial class ShowPokemonForm : Form
    {
        Pokedex pokedex;
        public ShowPokemonForm(Pokedex pokedex)
        {
            this.pokedex = pokedex;
            InitializeComponent();
            for (int i = 0; i < pokedex.PokemonList.Count; ++i)
                comboBoxPokemon.Items.Add(pokedex.PokemonList[i].Name);
        }

        private void ShowPokemon()
        {
            OPokemon p = pokedex.SearchPokemon(comboBoxPokemon.Text);
            if (p != null)
                richTextBoxShowPoke.Text = p.Show();

            else
                MessageBox.Show(comboBoxPokemon.Text + "Not Finded");
        }    

        private void btnSearchPoke_Click(object sender, EventArgs e)
        {
            ShowPokemon();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
