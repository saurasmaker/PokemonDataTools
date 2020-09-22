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

        private Pokedex pokedex;
        private AbilitiesList abilities;
        private MovesList moves;

        public SearchPokemonByName(Index index, byte mode, Pokedex pokedex, MovesList moves, AbilitiesList abilities)
        {
            InitializeComponent();
            this.index = index;
            this.mode = mode;
            this.moves = moves;
            this.abilities = abilities;
            this.pokedex = pokedex;
            label1.Text += Mode[mode];
            Text = Mode[mode];

            for (int i = 0; i < pokedex.PokemonList.Count; ++i)
                if(pokedex.PokemonList[i].Name!=null)
                    comboBoxPoke.Items.Add(pokedex.PokemonList[i].Name);

        }     

        private void button1_Click(object sender, EventArgs e)
        {
            
            OPokemon p = pokedex.SearchPokemon(comboBoxPoke.Text);
            
            if (index != null && p != null)
                if (mode == Updates)
                    index.OpenChildForm(new AddOrUpdatePokemonForm(pokedex, p, moves, abilities));
                else if (mode == Remove)
                    try { pokedex.RemovePokemon(comboBoxPoke.Text); }
                    catch (Exception){ MessageBox.Show("There was an error removing " + p.Name + ". Check the Log for more information.", "Error at Remove"); }
                else
                    MessageBox.Show(comboBoxPoke.Text + "Not Finded");

            Dispose();
        }
    }
}
