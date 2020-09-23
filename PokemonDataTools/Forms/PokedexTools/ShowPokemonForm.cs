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
        MovesList movesList;
        AbilitiesList abilitiesList;
        ItemsList itemsList;

        public ShowPokemonForm(Pokedex pokedex, MovesList movesList, AbilitiesList abilitiesList, ItemsList itemsList)
        {
            this.pokedex = pokedex;
            this.movesList = movesList;
            this.abilitiesList = abilitiesList;
            this.itemsList = itemsList;
            InitializeComponent();
            for (int i = 0; i < pokedex.PokemonList.Count; ++i)
                comboBoxPokemon.Items.Add(pokedex.PokemonList[i].Name);
        }

        private void ShowPokemon()
        {
            OPokemon p = pokedex.SearchPokemon(comboBoxPokemon.Text);
            if (p != null)
                richTextBoxShowPoke.Text = p.Show(movesList, abilitiesList, itemsList);

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
