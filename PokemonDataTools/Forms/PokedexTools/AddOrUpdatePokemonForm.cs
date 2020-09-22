using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Classes;
using Classes.Attributes;
using Classes.Lists;
using Tools;

namespace Forms.PokedexTools
{
    public partial class AddOrUpdatePokemonForm : Form
    {
        private Pokedex pokedex;
        private OPokemon pokemon;

        private List<OPokemon.MoveWillLearnByLevel> movesWillLearnByLevel;
        private List<PokeMove> canLearnMoves;
        private List<PokeMove> eggMoves;

        public AddOrUpdatePokemonForm(Pokedex pokedex)
        {
            this.pokedex = pokedex;
            InitializeComponent();
            InitializeComboBoxes();
        }

        public AddOrUpdatePokemonForm(Pokedex pokedex, OPokemon pokemon)
        {
            InitializeComponent();
            InitializeComboBoxes();

            this.pokedex = pokedex;
            this.pokemon = pokemon;
            FillData(pokemon);

            labelTitle.Text = "Update Pokémon";
        }

        #region Methods
        private void InitializeComboBoxes()
        {
            for (int i = 0; i < PokeAbility.AbilitiesNames.Length; i++) {             
                comboBoxAbility1.Items.Add(PokeAbility.AbilitiesNames[i]);
                comboBoxAbility2.Items.Add(PokeAbility.AbilitiesNames[i]);
                comboBoxAbilityHidden.Items.Add(PokeAbility.AbilitiesNames[i]);
            }
            comboBoxAbility1.SelectedIndex = 0;
            comboBoxAbility2.SelectedIndex = 0;
            comboBoxAbilityHidden.SelectedIndex = 0;

            for (int i = 0; i < PokeType.TypesNames.Length; i++)
            {
                comboBoxType1.Items.Add(PokeType.TypesNames[i]);
                comboBoxType2.Items.Add(PokeType.TypesNames[i]);
            }
            comboBoxType1.SelectedIndex = 0;
            comboBoxType2.SelectedIndex = 0;

            for (int i = 0; i < PokeLevelType.LevelTypesNames.Length; i++)
            {
                comboBoxLevelType.Items.Add(PokeLevelType.LevelTypesNames[i]);
            }
            comboBoxLevelType.SelectedIndex = 0;

            for (int i = 0; i < PokeEggGroup.EggGroupNames.Length; i++)
            {
                comboBoxEggGroup.Items.Add(PokeEggGroup.EggGroupNames[i]);
            }
            comboBoxEggGroup.SelectedIndex = 0;

            return;
        }

        private void AddPokemon()
        {
            pokemon = new OPokemon();

            if (CheckData())
            {
                try
                {
                    SetDataInPokemon();

                    pokedex.AddPokemon(pokemon);

                    MessageBox.Show("Congratulations. You added a Pokémon succesfuly.", "Pokémon Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log.Execute("Pokémon " + pokemon.Name + " with ID " + pokemon.Id + " added. ");
                    Dispose();

                }catch(Exception e)
                {
                    MessageBox.Show("There was a problem adding the Pokémon. Please, check the Log for more information.", "Add Pokémon Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Execute("Error adding pokémon.", e);
                }

            }

            return;
        }

        private void UpdatePokemon()
        {
            if (CheckData())
            {
                try
                {
                    SetDataInPokemon();

                    for (int i = 0; i < pokedex.PokemonList.Count; ++i)
                        if (pokedex.PokemonList[i].Id.Equals(pokemon.Id))
                        {
                            pokedex.PokemonList[i] = pokemon;
                            MessageBox.Show("Congratulations. You Updated a Pokémon succesfuly.", "Pokémon Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Log.Execute("Pokémon " + pokemon.Name + " with ID " + pokemon.Id + " updated. ");
                            Dispose();
                        }

                    MessageBox.Show("There was a problem updating the Pokémon. Please, check the Log for more information.", "Add Pokémon Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception e)
                {
                    MessageBox.Show("There was a problem updating the Pokémon. Please, check the Log for more information.", "Add Pokémon Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Execute("Error updating pokémon.", e);
                }

            }

            return;
        }

        private void SetDataInPokemon()
        {
            pokemon.Name = textBoxName.Text;
            pokemon.Category = textBoxCategory.Text;
            pokemon.Description = richTextBoxDescription.Text;
            pokemon.Weight = Convert.ToUInt16(numericUpDownWeight.Value);
            pokemon.Height = Convert.ToUInt16(numericUpDownHeight.Value);

            pokemon.GenresPercentage[0] = Convert.ToByte(numericUpDownMale.Value);
            pokemon.GenresPercentage[1] = Convert.ToByte(numericUpDownFemale.Value);

            pokemon.BaseStats[PokeStat.Health] = Convert.ToByte(numericUpDownHealth.Value);
            pokemon.BaseStats[PokeStat.Attack] = Convert.ToByte(numericUpDownAttack.Value);
            pokemon.BaseStats[PokeStat.SpecialAttack] = Convert.ToByte(numericUpDownSpecialAttack.Value);
            pokemon.BaseStats[PokeStat.Defense] = Convert.ToByte(numericUpDownDefense.Value);
            pokemon.BaseStats[PokeStat.SpecialDefense] = Convert.ToByte(numericUpDownSpecialDefense.Value);
            pokemon.BaseStats[PokeStat.Speed] = Convert.ToByte(numericUpDownSpeed.Value);

            pokemon.GivedEVs[PokeStat.Health] = Convert.ToByte(numericUpDownHealthEVs.Value);
            pokemon.GivedEVs[PokeStat.Attack] = Convert.ToByte(numericUpDownAttackEVs.Value);
            pokemon.GivedEVs[PokeStat.Defense] = Convert.ToByte(numericUpDownDefenseEVs.Value);
            pokemon.GivedEVs[PokeStat.SpecialAttack] = Convert.ToByte(numericUpDownSpecialAttackEVs.Value);
            pokemon.GivedEVs[PokeStat.SpecialDefense] = Convert.ToByte(numericUpDownSpecialDefenseEVs.Value);
            pokemon.GivedEVs[PokeStat.Speed] = Convert.ToByte(numericUpDownSpeedEVs.Value);

            pokemon.Types[0] = Convert.ToByte(comboBoxType1.SelectedIndex);
            pokemon.Types[1] = Convert.ToByte(comboBoxType2.SelectedIndex);

            pokemon.Abilities[0] = comboBoxAbility1.Text;
            pokemon.Abilities[1] =comboBoxAbility2.Text;
            pokemon.HiddenAbility = comboBoxAbilityHidden.Text;

            pokemon.LevelType = Convert.ToByte(comboBoxLevelType.SelectedIndex);
            pokemon.EggGroups[0] = Convert.ToByte(comboBoxEggGroup.SelectedIndex);

            return;
        }

        private bool CheckData()
        {
            if (textBoxName.Text == null || textBoxName.Text == "") {
                MessageBox.Show("You can not create a Pokémon without Name.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (textBoxCategory.Text == null || textBoxCategory.Text == "")
            {
                MessageBox.Show("You can not create a Pokémon without Category.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (richTextBoxDescription.Text == null || richTextBoxDescription.Text == "")
            {
                MessageBox.Show("You can not create a Pokémon without Description.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (comboBoxType1.Text == null || comboBoxType1.Text == "" || comboBoxType1.SelectedIndex == 0)
            {
                MessageBox.Show("You can not create a Pokémon without a Type.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxAbility1.Text == null || comboBoxType1.Text == "" || comboBoxAbility1.SelectedIndex == 0)
            {
                MessageBox.Show("You can not create a Pokémon without an Ability.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxEggGroup.Text == null || comboBoxEggGroup.Text == "" || comboBoxEggGroup.SelectedIndex == 0)
            {
                MessageBox.Show("You can not create a Pokémon without an Egg Group.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for(int i = 0; i < pokedex.PokemonList.Count; ++i)
            {
                if (pokedex.PokemonList[i].Name.ToUpper().Equals(textBoxName.Text.ToUpper()))
                {
                    MessageBox.Show("There cannot be two or more pokémon with the same name.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }



            return true;
        }

        private void FillData(OPokemon pokemon)
        {
            textBoxName.Text = pokemon.Name;
            textBoxName.ForeColor = Color.Black;

            textBoxCategory.Text = pokemon.Category;
            textBoxCategory.ForeColor = Color.Black;

            richTextBoxDescription.Text = pokemon.Description;
            richTextBoxDescription.ForeColor = Color.Black;

            numericUpDownHeight.Value = Convert.ToDecimal(pokemon.Height);
            numericUpDownWeight.Value = Convert.ToDecimal(pokemon.Weight);

            try
            { numericUpDownHealth.Value = pokemon.BaseStats[PokeStat.Health]; }
            catch (Exception)
            {numericUpDownHealth.Value = 1;}
            try
            { numericUpDownAttack.Value = pokemon.BaseStats[PokeStat.Attack]; }
            catch (Exception)
            { numericUpDownAttack.Value = 1; }
            try
            { numericUpDownDefense.Value = pokemon.BaseStats[PokeStat.Defense]; }
            catch (Exception)
            { numericUpDownDefense.Value = 1; }
            try
            { numericUpDownSpecialAttack.Value = pokemon.BaseStats[PokeStat.SpecialAttack]; }
            catch (Exception)
            { numericUpDownSpecialAttack.Value = 1; }
            try
            { numericUpDownSpecialDefense.Value = pokemon.BaseStats[PokeStat.SpecialDefense]; }
            catch (Exception)
            { numericUpDownSpecialDefense.Value = 1; }
            try
            { numericUpDownSpeed.Value = pokemon.BaseStats[PokeStat.Speed]; }
            catch (Exception)
            { numericUpDownSpeed.Value = 1; }

            numericUpDownHealthEVs.Value = pokemon.GivedEVs[PokeStat.Health];
            numericUpDownAttackEVs.Value = pokemon.GivedEVs[PokeStat.Attack];
            numericUpDownDefenseEVs.Value = pokemon.GivedEVs[PokeStat.Defense];
            numericUpDownSpecialAttackEVs.Value = pokemon.GivedEVs[PokeStat.SpecialAttack];
            numericUpDownSpecialDefenseEVs.Value = pokemon.GivedEVs[PokeStat.SpecialDefense];
            numericUpDownSpeedEVs.Value = pokemon.GivedEVs[PokeStat.Speed];

            for(int i = 0; i < comboBoxAbility1.Items.Count; ++i)
                if(comboBoxAbility1.Items[i].ToString().ToUpper().Equals(pokemon.Abilities[0].ToUpper()))
                    comboBoxAbility1.SelectedIndex = i;
            
            for (int i = 0; i < comboBoxAbility2.Items.Count; ++i)
                if (comboBoxAbility2.Items[i].ToString().ToUpper().Equals(pokemon.Abilities[1].ToUpper()))
                    comboBoxAbility2.SelectedIndex = i;

            for (int i = 0; i < comboBoxAbilityHidden.Items.Count; ++i)
                if (comboBoxAbilityHidden.Items[i].ToString().ToUpper().Equals(pokemon.HiddenAbility.ToUpper()))
                    comboBoxAbilityHidden.SelectedIndex = i;

            comboBoxLevelType.SelectedIndex = pokemon.LevelType;

            comboBoxType1.SelectedIndex = pokemon.Types[0];
            comboBoxType2.SelectedIndex = pokemon.Types[1];

            numericUpDownMale.Value = pokemon.GenresPercentage[0];
            numericUpDownMale.Value = pokemon.GenresPercentage[1];

            return;
        }


        #endregion

        #region Buttons
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to close this form? All changes realized will desapear.", "Close advise", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Dispose();

            return;
        }
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (pokemon != null) {
                UpdatePokemon();
            }
            else { AddPokemon();}

            return;
        }
        #endregion

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

        private void textBoxCategory_Enter(object sender, EventArgs e)
        {
            if (textBoxCategory.Text == "Category...")
            {
                textBoxCategory.Text = "";
                textBoxCategory.ForeColor = Color.Black;
            }
        }

        private void textBoxCategory_Leave(object sender, EventArgs e)
        {
            if (textBoxCategory.Text == "")
            {
                textBoxCategory.Text = "Category...";
                textBoxCategory.ForeColor = Color.DarkGray;
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

        private void textBoxHabitat_Enter(object sender, EventArgs e)
        {
            if (textBoxHabitat.Text == "Habitat...")
            {
                textBoxHabitat.Text = "";
                textBoxHabitat.ForeColor = Color.Black;
            }
        }

        private void textBoxHabitat_Leave(object sender, EventArgs e)
        {
            if (textBoxHabitat.Text == "")
            {
                textBoxHabitat.Text = "Habitat...";
                textBoxHabitat.ForeColor = Color.DarkGray;
            }
        }
        #endregion

        private void numericUpDownMale_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownFemale.Value = (100-numericUpDownMale.Value);
        }

        private void numericUpDownFemale_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownMale.Value = (100 - numericUpDownFemale.Value);

        }

    }
}
