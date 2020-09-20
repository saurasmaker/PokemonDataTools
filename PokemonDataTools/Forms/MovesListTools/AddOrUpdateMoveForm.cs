using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Classes;
using Classes.Attributes;
using Classes.Lists;
using Tools;

namespace Forms.MovesListTools
{
    public partial class AddOrUpdateMoveForm : Form
    {
        #region Attributes
        private MovesList movesList;
        private PokeMove pokeMove;
        #endregion

        #region Constructors
        public AddOrUpdateMoveForm(MovesList movesList)
        {
            this.movesList = movesList;
            pokeMove = null;
            InitializeComponent();
            InitializeComboBoxes();
        }

        public AddOrUpdateMoveForm(MovesList movesList, PokeMove pokeMove)
        {
            this.pokeMove = pokeMove;
            this.movesList = movesList;
            InitializeComponent();
            InitializeComboBoxes();

            FillData(pokeMove);
        }
        #endregion


        private void InitializeComboBoxes()
        {
            for (int i = 0; i < PokeType.TypesNames.Length; ++i)
                comboBoxType.Items.Add(PokeType.TypesNames[i]);
            comboBoxType.SelectedIndex = 0;

            for (int i = 0; i < PokeMove.TargetNames.Length; ++i)
                comboBoxTarget.Items.Add(PokeMove.TargetNames[i]);
            comboBoxTarget.SelectedIndex = 0;

            for (int i = 0; i < 100; ++i)
                comboBoxEffectCode.Items.Add(i);
            comboBoxEffectCode.SelectedIndex = 0;

            for (int i = 0; i < PokeMove.CategoryNames.Length; ++i)
                comboBoxCategory.Items.Add(PokeMove.CategoryNames[i]);
            comboBoxCategory.SelectedIndex = 0;

            return;
        }

        private void AddPokeMove()
        {
            if (CheckData())
            {
                //try
                {
                    SetDataInPokeMove();

                    movesList.AddPokeMove(pokeMove);

                    MessageBox.Show("Congratulations. You added a Pokemove succesfuly.", "Pokemove Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dispose();
                }
                /*catch (Exception e)
                {
                    Log.Execute("Error adding " + pokeMove.Name + ".", e);
                    MessageBox.Show("There was a problem adding the Pokemove. Please, check the Log for more information.", "Add Pokemove Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

            }

            return;
        }

        private void UpdatePokeMove()
        {
            if (CheckData())
            {
                //try
                {
                    SetDataInPokeMove();

                    for (int i = 0; i < movesList.Moves.Count; ++i)
                        if (movesList.Moves[i].Id.Equals(pokeMove.Id))
                        {
                            movesList.Moves[i] = pokeMove;
                            MessageBox.Show("Congratulations. You Updated a Pokemove succesfuly.", "Pokemove Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dispose();
                        }

                    MessageBox.Show("There was a problem updating the Pokemove. Please, check the Log for more information.", "Update Pokemove Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /*catch (Exception)
                {
                    MessageBox.Show("There was a problem updating the Pokemove. Please, check the Log for more information.", "Update Pokemove Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }

            return;
        }

        private void SetDataInPokeMove()
        {
            pokeMove = new PokeMove();

            pokeMove.Name = textBoxName.Text;
            pokeMove.Description = richTextBoxDescription.Text;
            pokeMove.Accuracy = Convert.ToByte(numericUpDownAccuarcy.Value);
            pokeMove.Category = Convert.ToByte(comboBoxCategory.SelectedIndex);
            pokeMove.Contact = checkBoxContact.Checked;
            pokeMove.EffectCode = comboBoxEffectCode.Text;
            pokeMove.EffectProbability = Convert.ToByte(numericUpDownEffectProbability.Value);
            pokeMove.Power = Convert.ToSByte(numericUpDownPower.Value);
            pokeMove.PP = Convert.ToByte(numericUpDownPP.Value);
            pokeMove.Priority = Convert.ToByte(numericUpDownPriority.Value);
            pokeMove.Recover = Convert.ToSByte(numericUpDownRecover.Value);
            pokeMove.Repetitions = Convert.ToByte(numericUpDownRepetitions.Value);
            pokeMove.RepetitionsInTurn = Convert.ToByte(numericUpDownRepetitionsInTurn.Value);
            pokeMove.Target = Convert.ToByte(comboBoxTarget.SelectedIndex);
            pokeMove.Type = Convert.ToByte(comboBoxType.SelectedIndex);

            return;
        }

        private bool CheckData()
        {
            if (textBoxName.Text == null || textBoxName.Text == "" || textBoxName.Text == "Name...")
            {
                MessageBox.Show("You can not create a Pokemove without Name.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxCategory.Text == null || comboBoxCategory.Text == "" || comboBoxCategory.SelectedIndex == 0)
            {
                MessageBox.Show("You can not create a Pokemove without Category.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (richTextBoxDescription.Text == null || richTextBoxDescription.Text == "" || richTextBoxDescription.Text == "Description...")
            {
                MessageBox.Show("You can not create a Pokemove without Description.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxType.Text == null || comboBoxType.Text == "" || comboBoxType.SelectedIndex == 0)
            {
                MessageBox.Show("You can not create a Pokemove without a Type.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(comboBoxCategory.SelectedIndex == PokeMove.State)
            {
                MessageBox.Show("You can not create a Pokemove that has 'state' category with more power than '0'.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void FillData(PokeMove pokeMove)
        {
            textBoxName.Text = pokeMove.Name;
            textBoxName.ForeColor = Color.Black;

            richTextBoxDescription.Text = pokeMove.Description;
            richTextBoxDescription.ForeColor = Color.Black;

            comboBoxCategory.SelectedIndex = pokeMove.Category;
            comboBoxEffectCode.SelectedIndex =Convert.ToByte(pokeMove.EffectCode);
            comboBoxType.SelectedIndex = pokeMove.Type;
            comboBoxTarget.SelectedIndex = pokeMove.Target;

            numericUpDownAccuarcy.Value = pokeMove.Accuracy;
            numericUpDownEffectProbability.Value = pokeMove.EffectProbability;
            numericUpDownPower.Value = pokeMove.Power;
            numericUpDownPP.Value = pokeMove.PP;
            numericUpDownRecover.Value = pokeMove.Recover;
            numericUpDownRepetitions.Value = pokeMove.Repetitions;
            numericUpDownRepetitionsInTurn.Value = pokeMove.RepetitionsInTurn;
            numericUpDownPriority.Value = pokeMove.Priority;
        }
        
        #region TextBoxes
            private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Name...")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Name...";
                textBoxName.ForeColor = Color.DarkGray;
            }
        }

        private void richTextBoxDescription_Enter(object sender, EventArgs e)
        {
            if (richTextBoxDescription.Text == "Description...")
            {
                richTextBoxDescription.Text = "";
                richTextBoxDescription.ForeColor = Color.Black;
            }
        }

        private void richTextBoxDescription_Leave(object sender, EventArgs e)
        {
            if (richTextBoxDescription.Text == "")
            {
                richTextBoxDescription.Text = "Description...";
                richTextBoxDescription.ForeColor = Color.DarkGray;
            }
        }
        #endregion

        #region Buttons
        private void buttonAddMove_Click(object sender, EventArgs e)
        {
            if (pokeMove != null)
            {
                UpdatePokeMove();
                Log.Execute("Pokemove updated");
            }
            else { AddPokeMove(); Log.Execute("Pokemove added."); }

            return;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to close this form? All changes realized will desapear.", "Close advise", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Dispose();

            return;
        }
        #endregion
    }
}
