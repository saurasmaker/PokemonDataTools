using Classes.Lists;
using Forms.PokedexTools;
using PokemonShowdown.Forms.PokedexTools;
using System;
using System.Windows.Forms;
using Tools;
using Microsoft.VisualBasic;
using System.IO;
using Forms.MovesListTools;
using PokemonDataTools.Forms.MovesListTools;
using Classes.Tools;
using PokemonDataTools.Classes.Tools;

namespace Forms
{
    public partial class Index : Form
    {
        string projectPath = string.Empty;
        string projectName = string.Empty;

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
            OpenChildForm(new ShowPokemonForm(pokedex));
        }

        private void btnAddPokeToPokedex_Click(object sender, EventArgs e)
        {
            if (pokedex == null)
            {
                if (MessageBox.Show("There is no project loaded. You cannot add a pokémon if there is no project in memory. Do you want to create a project?", "Project error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GenerateNewProyect();
            }
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

        private void btnShowPokedex_Click(object sender, EventArgs e)
        {
            if (pokedex == null)
            {
                if (MessageBox.Show("There is no project loaded. You cannot show a pokémon if there is no project in memory. Do you want to create a project?", "Project error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GenerateNewProyect();
            }
            else if (pokedex.PokemonList.Count.Equals(0))
                MessageBox.Show("You cannot show a pokémon if there is no pokemon in memory", "Project error.");

            else
                OpenChildForm(new ShowPokemonForm(pokedex));
        }
        #endregion

        #region MovesList Tools
        private void buttonCreateMove_Click(object sender, EventArgs e)
        {
            if (movesList == null)
            {
                if (MessageBox.Show("There is no project loaded. You cannot add a pokémon if there is no project in memory. Do you want to create a project?", "Project error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GenerateNewProyect();
            }
            else
                OpenChildForm(new AddOrUpdateMoveForm(movesList));
        }

        private void buttonUpdateMove_Click(object sender, EventArgs e)
        {
            if (movesList == null)
            {
                if (MessageBox.Show("There is no project loaded. You cannot update a pokémon if there is no project in memory. Do you want to create a project?", "Project error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    GenerateNewProyect();
            }
            else if (movesList.Moves.Count.Equals(0))
                MessageBox.Show("You cannot update a pokemove if there is no pokemove in memory", "Project error.");

            else
                new SearchMoveByName(this, SearchMoveByName.Updates, movesList).Show();
        }

        private void buttonRemoveMove_Click(object sender, EventArgs e)
        {
            if (movesList == null)
                MessageBox.Show("error");
            else if (movesList.Moves.Count.Equals(0))
                MessageBox.Show("ERROR");
            else
                new SearchMoveByName(this, SearchMoveByName.Remove, movesList).Show();
        }

        private void buttonShowMovesList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowMoveForm(movesList));
        }
        #endregion

        #region AbilitiesList Tools
        #endregion

        #region ItemsList Tools
        #endregion

        #region Project Tools
        public void GenerateNewProyect()
        {
            projectName = Interaction.InputBox("What is the name of the project?", "Set Project name", "Project name...");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            if (!Directory.Exists(XMLTools.DefaultPath))
                Directory.CreateDirectory(XMLTools.DefaultPath);

            fbd.SelectedPath = XMLTools.DefaultPath;
            if (projectName != string.Empty && fbd.ShowDialog() == DialogResult.OK )
            {
                projectPath = fbd.SelectedPath + "\\" + projectName;
                Directory.CreateDirectory(projectPath);

                pokedex = new Pokedex();
                movesList = new MovesList();
                abilitiesList = new AbilitiesList();
                itemsList = new ItemsList();

                pokedex.FilePath = movesList.FilePath = abilitiesList.FilePath = itemsList.FilePath = projectPath;

                try
                {
                    pokedex.Save();
                    movesList.Save();
                    abilitiesList.Save();
                    itemsList.Save();

                    MessageBox.Show("Project " + projectName + " generated succesfully.","Message Info.",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log.Execute("Project " + projectName + " generated in " + projectPath);
                }catch(Exception e)
                {
                    MessageBox.Show("Error to generate new project. Check the log for more information.", "Message Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Execute("Error to generate new project.", e);
                }
            }
            return;
        }

        public void LoadProject()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            if (!Directory.Exists(XMLTools.DefaultPath))
                Directory.CreateDirectory(XMLTools.DefaultPath);

            fbd.SelectedPath = XMLTools.DefaultPath;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                pokedex = new Pokedex();
                movesList = new MovesList();
                abilitiesList = new AbilitiesList();
                itemsList = new ItemsList();
                pokedex.FilePath = movesList.FilePath = abilitiesList.FilePath = itemsList.FilePath = fbd.SelectedPath;

                projectPath = fbd.SelectedPath;
                string[] split = projectPath.Split('\\');
                projectName = split[split.Length-1];

                try
                {
                    pokedex.Load();
                    movesList.Load();
                    abilitiesList.Load();
                    itemsList.Load();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Fatal Error. Project cannot load. Check the log for more information.", "Message Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Execute("Error loading project " + projectName + ".", e);

                    return;
                }

                MessageBox.Show("Project loaded succesfully.", "Message Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Log.Execute("Project " + projectName + " loaded from " + projectPath);

            }

            return;
        }

        public void SaveProject()
        {
            try
            {
                try { pokedex.Save(); }
                catch(Exception t) { Log.Execute("Error saving pokedex of " + projectName+ ".", t); }

                try { movesList.Save(); }
                catch (Exception t) { Log.Execute("Error saving moves list of " + projectName + ".", t); }


                try { abilitiesList.Save(); }
                catch (Exception t) { Log.Execute("Error saving abilities list of " + projectName + ".", t); }

                try { itemsList.Save(); }
                catch (Exception t) { Log.Execute("Error saving items list of " + projectName + ".", t); }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error to save project. Check the log for more information.", "Message Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Execute("Error saving project " + projectName + ".", e);
            }

            MessageBox.Show("Project saved succesfully.", "Message Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Log.Execute("Project " + projectName + " saved in " + projectPath);
        }

        private void CloseProject()
        {
            if (MessageBox.Show("Are you sure that you want to close this project?", "Message Question.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Do yo want to save the projecto before close?", "Message Question.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)                
                    SaveProject();

                Dispose();
            }
        }
        #endregion

        #region ToolStrip
        private void toolStripMenuItemNewProject_Click(object sender, EventArgs e)
        {
            GenerateNewProyect();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #region Essentials Translator
        //Pokémon essentials translator
        private void essentialsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = OpenTxtFile();
            if (ofd.ShowDialog() == DialogResult.OK)
                pokedex = EssentialsTranslator.Pokedex(ofd.FileName);

            return;
        }

        //Moves essentials translator
        private void essentialsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = OpenTxtFile();
            if (ofd.ShowDialog() == DialogResult.OK)
                EssentialsTranslator.AbilitiesList(ofd.FileName);

            return;
        }

        //Abilities essentials translator
        private void essentialsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = OpenTxtFile();
            if (ofd.ShowDialog() == DialogResult.OK)
                EssentialsTranslator.AbilitiesList(ofd.FileName);

            return;
        }

        //Items essentials translator
        private void essentialsToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = OpenTxtFile();
            if (ofd.ShowDialog() == DialogResult.OK)
                EssentialsTranslator.AbilitiesList(ofd.FileName);

            return;
        }
        #endregion //end of essentials translator

        #endregion //end of Tool strip



        #region Aux Tools
        private OpenFileDialog OpenTxtFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (!Directory.Exists(XMLTools.DefaultPath))
                Directory.CreateDirectory(XMLTools.DefaultPath);

            ofd.InitialDirectory = XMLTools.DefaultPath;

            return ofd;
        }


        #endregion

        
    }
}
