using Classes.Lists;
using Forms.PokedexTools;
using PokemonShowdown.Forms.PokedexTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tools;
using Microsoft.VisualBasic;
using System.IO;
using System.Linq;

namespace Forms
{
    public partial class Index : Form
    {
        string projectPath = String.Empty;

        Pokedex pokedex; //= new Pokedex(Pokedex.Load());
        MovesList movesList; //= new MovesList(MovesList.Load());
        AbilitiesList abilitiesList; //= new AbilitiesList(AbilitiesList.Load());
        ItemsList itemsList; //= new ItemsList(ItemsList.Load());

        #region Constructors
        public Index()
        {
            InitializeComponent();
            HideSubMenus();
            Log.Execute("Application initilizated.");
        }
        #endregion

        #region General Window Tools
        private void index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.Execute("Application closed.");
        }
        #endregion

        #region Submenu Buttons
        private void btnPokedexTools_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelPokedexToolsSubmenu);
        }

        private void buttonMovesTools_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelMovesTools);
        }

        private void buttonItemsTools_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelItemsTools);
        }

        private void buttonHabilities_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelAbilitiesTools);
        }
        #endregion

        #region Submenu Tools
        Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            return;
        }

        private void HideSubMenus()
        {
            panelPokedexToolsSubmenu.Visible = false;
            panelMovesTools.Visible = false;
            panelItemsTools.Visible = false;
            panelAbilitiesTools.Visible = false;
        }


        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible != true)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;

        }
        #endregion

        #region Pokedex Tools
        private void btnShowPokeFromPokedex_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowPokemonForm());
        }

        private void btnAddPokeToPokedex_Click(object sender, EventArgs e)
        {
            if (pokedex == null)
            {
                if (MessageBox.Show("There is no project loaded. You cannot add a pokémon if there is no project in memory. Do you want to create a project?", "Project error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GenerateNewProyect();
            }
            else if (pokedex.PokemonList.Count.Equals(0))
                MessageBox.Show("ERROR");

            else
                OpenChildForm(new AddOrUpdatePokemonForm(pokedex));
        }

        private void btnUpdatePokeFromPokedex_Click(object sender, EventArgs e)
        {
            if (pokedex == null)
            {
                if (MessageBox.Show("There is no project loaded. You cannot update a pokémon if there is no project in memory. Do you want to create a project?", "Project error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GenerateNewProyect();
            }
            else if (pokedex.PokemonList.Count.Equals(0))
                MessageBox.Show("You cannot update a pokémon if there is no pokemon in memory", "Project error.");

            else
                new SearchPokemonByName(this, SearchPokemonByName.Updates, pokedex).Show();
        }

        private void btnRemovePokeFromPokedex_Click(object sender, EventArgs e)
        {
            if (pokedex == null)
                MessageBox.Show("error");
            else if (pokedex.PokemonList.Count.Equals(0))
                MessageBox.Show("ERROR");
            else
                new SearchPokemonByName(this, SearchPokemonByName.Remove, pokedex).Show();
        }
        #endregion

        #region MovesList Tools
        #endregion

        #region AbilitiesList Tools
        #endregion

        #region ItemsList Tools
        #endregion

        #region Project Tools
        public void GenerateNewProyect()
        {
            string projectName = Interaction.InputBox("What is the name of the project?", "Set Project name", "Project name...");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                projectPath = fbd.SelectedPath + "\\" + projectName;
                Directory.CreateDirectory(projectPath);

                pokedex = new Pokedex();
                movesList = new MovesList();
                abilitiesList = new AbilitiesList();
                itemsList = new ItemsList();

                pokedex.Save();
                movesList.Save();
                abilitiesList.Save();
                itemsList.Save();

            }
            return;
        }

        public void LoadProject()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                pokedex = new Pokedex();
                movesList = new MovesList();
                abilitiesList = new AbilitiesList();
                itemsList = new ItemsList();
                pokedex.FilePath = movesList.FilePath = abilitiesList.FilePath = itemsList.FilePath = fbd.SelectedPath;

                pokedex.Load();
                movesList.Load();
                abilitiesList.Load();
                itemsList.Load();

            }

            return;
        }
        #endregion
    }
}
