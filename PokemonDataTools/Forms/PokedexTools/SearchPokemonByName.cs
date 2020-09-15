using System;
using System.Windows.Forms;
using Classes;
using Classes.Lists;

namespace Forms.PokedexTools
{
    public partial class SearchPokemonByName : Form
    {
        public static string[] Mode = new string[] { "none", "Update", "Remove" };

        public static byte Updates = 1;
        public static byte Remove = 2;

        private byte mode;
        private Index index;

        public SearchPokemonByName(Index index, byte mode)
        {          
            InitializeComponent();
            this.index = index;
            this.mode = mode;

            if (mode == Updates)
            {
                label1.Text += "Update";
                Text = "Update";
            }
            else if (mode == Remove)
            {
                label1.Text += "Remove";
                Text = "Remove";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPokemon p = /*Pokedex.LoadPokemonFromPokedexXML(textBoxSearchPoke.Text)*/ null;

            if (index != null && p != null)
                if (mode == Updates)
                    index.OpenChildForm(new AddOrUpdatePokemonForm(p));
                /*else if (mode == Remove)
                    try { Pokedex.RemovePokemonFromPokedexXML(p.Name); }
                    catch (Exception){ MessageBox.Show("There was an error removing " + p.Name + ". Check the Log for more information.", "Error at Remove"); }*/
                else
                    MessageBox.Show(textBoxSearchPoke.Text + "Not Finded");

            Dispose();
        }
    }
}
