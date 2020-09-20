using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Classes;
using Classes.Lists;

namespace Forms.MovesListTools
{
    public partial class SearchMoveByName : Form
    {
        #region Attributes
        public static string[] Mode = new string[] { "none", "Update", "Remove" };

        public static byte Updates = 1;
        public static byte Remove = 2;

        private byte mode;
        private Index index;

        private MovesList movesList;
        #endregion

        #region Constructors
        public SearchMoveByName(Index index, byte mode, MovesList movesList)
        {
            InitializeComponent();
            this.index = index;
            this.mode = mode;
            this.movesList = movesList;
            label1.Text += Mode[mode];
            Text = Mode[mode];

            for (int i = 0; i < movesList.Moves.Count; ++i)
                comboBoxPokemoves.Items.Add(movesList.Moves[i].Name);
        }

        #endregion

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PokeMove p = movesList.SearchPokeMove(comboBoxPokemoves.Text);

            if (index != null && p != null)
                if (mode == Updates)
                    index.OpenChildForm(new AddOrUpdateMoveForm(movesList, p));
                else if (mode == Remove)
                    try { movesList.RemovePokeMove(comboBoxPokemoves.Text); }
                    catch (Exception) { MessageBox.Show("There was an error removing " + p.Name + ". Check the Log for more information.", "Error at Remove"); }
                else
                    MessageBox.Show(comboBoxPokemoves.Text + "Not Finded");

            Dispose();
        }
    }
}
