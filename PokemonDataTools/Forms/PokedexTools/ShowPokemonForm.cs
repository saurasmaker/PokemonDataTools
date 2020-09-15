using System;
using System.Drawing;
using System.Windows.Forms;
using Classes;
using Classes.Lists;

namespace PokemonShowdown.Forms.PokedexTools
{
    public partial class ShowPokemonForm : Form
    {
        public ShowPokemonForm()
        {
            InitializeComponent();
        }

        private void ShowPokemon()
        {
            OPokemon p = /*Pokedex.LoadPokemonFromPokedexXML(textBoxSearchPoke.Text)*/ null;
            if (p != null)
                richTextBoxShowPoke.Text = p.Show();

            else
                MessageBox.Show(textBoxSearchPoke.Text + "Not Finded");
        }

        #region textBoxSearchPokeTools
        private void textBoxSearchPoke_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchPoke.Text == "Enter the name of a pokémon...")
            {
                textBoxSearchPoke.Text = "";
                textBoxSearchPoke.ForeColor = Color.Black;
            }
        }

        private void textBoxSearchPoke_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchPoke.Text == "")
            {
                textBoxSearchPoke.Text = "Enter the name of a pokémon...";
                textBoxSearchPoke.ForeColor = Color.DarkGray;
            }
        }
        #endregion

        private void btnSearchPoke_Click(object sender, EventArgs e)
        {
            ShowPokemon();
        }

        private void textBoxSearchPoke_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
             ShowPokemon();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
