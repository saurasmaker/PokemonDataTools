using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using Classes.Lists;

namespace PokemonDataTools.Forms.MovesListTools
{
    public partial class ShowMoveForm : Form
    {
        MovesList movesList;
        public ShowMoveForm(MovesList movesList)
        {
            this.movesList = movesList;
            InitializeComponent();
            for (int i = 0; i < movesList.Moves.Count; ++i)
                comboBoxPokemove.Items.Add(movesList.Moves[i].Name);
        }

        private void ShowPokeMove()
        {
            PokeMove p = movesList.SearchPokeMove(comboBoxPokemove.Text);
            if (p != null)
                richTextBoxShowPokeMove.Text = p.Show();

            else
                MessageBox.Show(comboBoxPokemove.Text + "Not Finded");
        }

        private void btnSearchPokeMove_Click(object sender, EventArgs e)
        {
            ShowPokeMove();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
